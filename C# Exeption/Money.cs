using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exeption
{
    public class Money
    {
        public int Hryvna { get; set; }
        public int Kopechks { get; set; }
        public Money(int hryvna, int kopechks)
        {
            Hryvna = hryvna ;
            Kopechks = kopechks;
            if(hryvna < 0||kopechks<0) 
            {
                throw new ArgumentException("Денгьги не могут быть меньше 0!!!");
            }
        }

        public static Money operator +(Money m1, Money m2) 
        {
            int totalKopecks = m1.Hryvna*100+m1.Kopechks+m2.Hryvna*100+m2.Kopechks;
            return new Money(totalKopecks/100,totalKopecks%100);
       
        }
        public static Money operator -(Money m1, Money m2)
        {
            int totalKopecks = m1.Hryvna * 100 + m1.Kopechks - m2.Hryvna * 100 - m2.Kopechks;
            if(totalKopecks < 0)
            {
                throw new Bancrupt("Вы банкрот");
            }
            return new Money(totalKopecks / 100, totalKopecks % 100);

        }

        public static Money operator *(Money m1, int multiplier) 
        {
            int totalKopeck = (m1.Hryvna * 100 + m1.Kopechks) * multiplier;
            return new Money(totalKopeck/100,totalKopeck % 100);
        }
        public static Money operator /(Money m1, int divisor)
        {
            if(divisor == 0)
            {
                throw new DivideByZeroException("Делить на ноль нельзя");
            }
            int totalKopecks = m1.Hryvna * 100 + m1.Kopechks;
            return new Money(totalKopecks/divisor/100, totalKopecks % divisor%100);
        }
        public static bool operator<(Money m1, Money m2)
        {
            return m1.Hryvna < m2.Hryvna||m1.Hryvna==m2.Hryvna&&m1.Kopechks<m2.Kopechks;
        }
        public static bool operator >(Money m1, Money m2)
        {
            return m1.Hryvna > m2.Hryvna || m1.Hryvna == m2.Hryvna && m1.Kopechks > m2.Kopechks;
        }

        public static bool operator ==(Money m1, Money m2)
        {
            return m1.Hryvna == m2.Hryvna && m1.Kopechks== m2.Kopechks;
        }
        public static bool operator !=(Money m1, Money m2)
        {
            return !(m1==m2);
        }
        public static Money operator++(Money m)
        {
            return m + new Money(0, 1);
        }
        public static Money operator --(Money m)
        {
            return m - new Money(0, 1);
        }

        public override string ToString()
        {
            return $"{Hryvna} грн, {Kopechks}коп";
        }





    }
}

namespace C__Exeption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Money money1 = new Money(10, 50);
            Money money2 = new Money(5, 52);
            Console.WriteLine(money1.ToString());
            Console.WriteLine(money2.ToString());
            try
            {
                Money sum = money1 + money2;
                Console.WriteLine(sum.ToString());

                Money diff = money1 - money2;
                Console.WriteLine(diff.ToString());

                Money div = money1 / 2;
                Console.WriteLine(div.ToString());

                Money mul = money2 * 3;
                Console.WriteLine(mul.ToString());

                Money inc = ++money1;
                Console.WriteLine(inc.ToString());

                Money decx = --money2;
                Console.WriteLine(decx.ToString());

                Console.WriteLine("Money1 > Money2" + (money1 > money2));
                Console.WriteLine("Money1 < Money2" + (money1 < money2));
                Console.WriteLine("Money1 = Money2" + (money1 == money2));
            }
            catch (Bancrupt ex) { Console.WriteLine("Bankrut ex" + ex.Message); }
            catch(Exception ex) { Console.WriteLine(ex.Message); } */

            /* try
             {
                 Console.WriteLine("Введите строку:");
                 int num = Convert.ToInt32(Console.ReadLine());

             }
             catch (OverflowException) 
             {
                 Console.WriteLine("Неверный ввод");
             }*/

            /*try
            {
                Console.WriteLine("Введите возраст:");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age > 18)
                    Console.WriteLine("Добро пожаловать");
                else
                    throw new UnderRageExeption("Вам нет 18");
            }
            catch (UnderRageExeption ex) { 
                Console.WriteLine(ex.Message);
            }*/

            StudentManagmentSystem students = new StudentManagmentSystem();
            students.AddStudent("Petya", 18);
            students.AddStudent("Vasya", 20);
            students.AddStudent("Kolya", 26);
            students.Print();
            //students.GetStudentByName("Petya");
            
            
            
        }
    }
}

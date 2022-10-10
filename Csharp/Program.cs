namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            var str = Console.ReadLine();
            int a= Convert.ToInt32(str);
            if (a>=6 && a<=7)
                Console.WriteLine($"{Environment.NewLine}Выходной!");
            else
                if (a<=5 && a>=1)
                    Console.WriteLine($"{Environment.NewLine}Рабочий день!");
                else 
                    Console.WriteLine($"{Environment.NewLine}Вы ввели не верное число..");
            Console.Write($"{Environment.NewLine}Нажмите любую кнопку...");
            Console.ReadKey(true);
        }
    }
}
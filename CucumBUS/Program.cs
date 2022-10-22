namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту массива:");
            var str = Console.ReadLine();
            int a= Convert.ToInt32(str);
            Console.Write("Введите длинну массива массива:");
            var str1 = Console.ReadLine();
            int b= Convert.ToInt32(str1);
            int [,] arr = new int[a,b];

            Random rand = new Random();
             for (int i=0;i<a;i++){
                for (int j=0;j<b;j++){
                   arr[i,j]=rand.Next(100);
                }
            }  

            for (int i=0;i<a;i++){
                for (int j=0;j<b;j++){
                    Console.Write(arr[i , j]+" ");
                }
                Console.WriteLine();
            }    
            
            Console.WriteLine("Введите позицию элемента:");
            var fir = Console.ReadLine();
            var sec = Console.ReadLine();
            int f= Convert.ToInt32(fir);
            int s= Convert.ToInt32(sec);

            if (f>a || s>b)
                Console.WriteLine("Такого элемента не существует!");
            else
                Console.WriteLine("Значение элемента:"+arr[f-1,s-1]);

            Console.Write($"{Environment.NewLine}Нажмите любую кнопку...");
            Console.ReadKey(true);
        }
    }
}

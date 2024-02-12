string input;
do
{
    Console.WriteLine("Quyidagilardan birini tanlang : ");
    Console.WriteLine("1. Tublikka tekshirish");
    Console.WriteLine("2. Fibonachi sonlar");
    Console.WriteLine("3. Dasturni tugatish");
    input = Console.ReadLine();
    switch(input)
    {
        case "1" :
            {
                Console.Write("Sonni kiriting : ");
                string strNumber = Console.ReadLine();
                Console.WriteLine("\n");
                int num = Convert.ToInt32(strNumber), cnt = 0;
                for(int i = 2; i * i <= num; i++)
                {
                    if(i * i == num)
                    {
                        cnt++;
                    }
                    else if(num % i == 0)
                    {
                        cnt += 2;
                    }
                }
                if(cnt == 0)
                {
                    Console.WriteLine($"{num} tub son");
                }
                else
                {
                    Console.WriteLine($"{num} tub son emas");
                }
            } 
            break;
        case "2" :
            {
                Console.Write("Sonni kiriting : ");
                string strNumber = Console.ReadLine();
                Console.WriteLine("\n");
                int num = Convert.ToInt32(strNumber);
                int fib0 = 0, fib1 = 1, fib = fib0 + fib1;
                if(num > 0) Console.Write(fib0 + " ");
                if(num > 1) Console.Write(fib1 + " ");
                while(fib <= num)
                {
                    Console.Write(fib + " ");
                    fib0 = fib1;
                    fib1 = fib;
                    fib = fib0 + fib1;
                }
            }
            break;
    }
    Console.WriteLine("\n");
}while(input != "3");
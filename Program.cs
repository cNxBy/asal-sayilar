namespace asal_sayılar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asal sayıları belirle!");
            int a, b;
            int kontrol;
            Console.WriteLine("*** Bir sayı giriniz ***");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*** Bir sayı giriniz ***");
            b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            if (a == 1) 
            {
                a++;
            }
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    kontrol = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            kontrol++;
                            break;
                        }

                    }
                    if (kontrol == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            
            
               
            
            else if (b < a) 
            {
                if (b == 1) 
                {
                    b++;
                }
                for (int i = b; i <= a; i++)
                { 
                    kontrol = 0;
                    for(int j = 2;j < i; j++)
                    {
                        if(i % j == 0) 
                        {
                            kontrol++;
                            break;
                        }
                    }
if(kontrol == 0) {
                        Console.WriteLine(i); 
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

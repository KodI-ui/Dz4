using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {

            While8();

        }
        static void Example1()
        {
            int hp = 100;
            Random random = new Random();
            while (hp > 0)
            {
                int Damage = random.Next(1, 7);
                hp -= Damage;
                Console.WriteLine($"Took {Damage}, left {hp}");
                Console.ReadKey(true);
            }
            Console.WriteLine("GG");
        }
        static void Example2()
        {
            int TicketCost = 8;
            for (int i = 1; i <= 10; i++)
            {
                int AllCosts = TicketCost * i;
                Console.WriteLine($"Total cost for {i} friends: {AllCosts}");
                Console.ReadKey(true);
            }
        }
        static void While1()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            while (A >= B)
            {
                A -= B;
            }
            Console.WriteLine(A);
        }
        static void While2()
        {
            int A, B, i;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            i = 0;

            while (A >= B)
            {
                A -= B;
                ++i;
            }
            Console.WriteLine(i);
        }
        static void While3()
        {
            int N, K;
            N = int.Parse(Console.ReadLine());
            K = int.Parse(Console.ReadLine());
            int i = 0;
            while (N >= K)
            {
                N -= K;
                ++i;
            }
            Console.WriteLine($"Остаток - {N}, частное - {i}");
        }
        static void While4()
        {
            int N = int.Parse(Console.ReadLine());
            while (N > 3)
            {
                N /= 3;

            }
            Console.WriteLine(N == 3);

        }
        static void While5()
        {
            int N = int.Parse(Console.ReadLine());
            int i = 1;
            while (N > 2)
            {
                N /= 2;
                ++i;
            }
            Console.WriteLine(i);
        }
        static void While6()
        {

            int N = int.Parse(Console.ReadLine());
            int L = N;
            int i = 2;
            int numbers = 2;

            while (N >= numbers)
            {
                L = L * (N - i);
                i += 2;

                numbers *= 2;
            }


            Console.WriteLine(L);

        }
        static void While7()
        {
            int N = int.Parse(Console.ReadLine());
            int K;
            K = N * N;
            while ((K * K) > N)
            {
                K--;
            }
            K++;
            Console.WriteLine($"{K}^2");
        }
        static void While8()
        {
            int N = int.Parse(Console.ReadLine());
            int K;
            K = 0;
            while ((K * K) <= N)
            {
                K++;
                Console.WriteLine($"{K}^2");
            }
            K--;
            Console.WriteLine($"{K}^2");
        }
        static void While9()
        {
            int N = int.Parse(Console.ReadLine());
            int K;
            K = 1;
            int num = 3;
            while(num <= N)
            {
                num *= 3;
                ++K;
            }
            Console.WriteLine(K);

        }
        static void While10()
        {
            int N = int.Parse(Console.ReadLine());
            int K = 0;
            int num = 3;
            while(num < N)
            {
                num *= 3;
                ++K;
            }
            Console.WriteLine(K);
        }
        static void While11()
        {
            int N = int.Parse(Console.ReadLine());
            int K = 0;
            int R = 0;
            while(R < N)
            {
                ++K;
                R += K;
            }
            Console.WriteLine($"{K} {R}");
        }
        static void While12()
        {
            int N = int.Parse(Console.ReadLine());
            int K = 0;
            int num = 0;
            while(!(num + K + 1 > N))
            {
                ++K;
                num += K;
            }
            Console.WriteLine($"{K} {num}");
        }
    }
}

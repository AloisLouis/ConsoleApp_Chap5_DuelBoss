namespace ConsoleApp_Chap5_Ex2_DuelBoss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PV du héros:");
            int heroPV = int.Parse(Console.ReadLine());
            Console.WriteLine("PV du boss:");
            int bossPV = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            int tour = 1;

            while (heroPV > 0 && bossPV > 0)
            {
                Console.WriteLine("Tour {0}", tour);
                tour++;

                Random rand = new Random();
                int degatsHero = rand.Next(10, 26);
                bossPV -= degatsHero;
                
                if (bossPV <= 0)
                {
                    Console.WriteLine("Le boss est vaincu !");
                    break;
                }
                else
                {
                    Console.WriteLine("PV du boss : {0}", bossPV);
                    Random rand2 = new Random();
                    int degatsBoss = rand2.Next(5, 21);
                    heroPV -= degatsBoss;
                    
                    if (heroPV <= 0)
                    {
                        Console.WriteLine("Vous avez échoué !");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("PV du héros : {0}", heroPV);
                        Console.WriteLine(" ");
                        continue;
                    }
                }
            }
        }
    }
}

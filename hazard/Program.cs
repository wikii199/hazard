namespace hazard
{
class program
    {
        static void Main(string[] args) 
        {
            double odds = .75;
            Random random = new Random();
            guy player = new guy() { Cash = 500, Name = "gracz" };

            Console.WriteLine("siema witam prawododonienstwo ze wygrasz;" + odds);
            while (player.Cash >0) 
            {
                player.info();
                Console.WriteLine(" ile obstawiasz chuju:");
                string ile = Console.ReadLine();
                if (int.TryParse(ile, out int amout )) 
                {
                    int bet = player.dajhajs(amout) * 2;
                    if (bet > 0) 
                    {
                        if (random.NextDouble() > odds) 
                        {
                            int win = bet; 
                            Console.WriteLine(" wygrales " + win);
                            player.dawajhajshuju(win);
                           
                        }
                        else 
                        {
                            Console.WriteLine(" giga przegryw ");

                        }
                    }
                }   else
                {
                    Console.WriteLine(" dawaj liczbe ");

                }
            }
            Console.WriteLine("chuj ci bo kasyno wygrywa ");
        }
        
    }
}
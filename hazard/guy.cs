
    class guy
    {
        public string Name;
        public int Cash;

        public void info()
        {
            Console.WriteLine(Name + " ma " + Cash + " hajsu. ");

        }
        public int dajhajs(int amout)
        {
            if (amout <= 0)
            {
                Console.WriteLine(Name + " mowi" + amout + "jest chujowa kwota");
                return 0;
            }
            if (amout > Cash)
            {
                Console.WriteLine(Name + "mowi: " + " nie mam hajsu na tyle kurwo" + amout);
                return 0;

            }
            Cash -= amout;
            return amout;
        }
        public void dawajhajshuju(int amout)
        {
            if (amout <= 0)
            {
                Console.WriteLine(Name + "mowi" + amout + " to za malo chuju");

            }
            else
            {
                Cash += amout;

            }
        }

    }


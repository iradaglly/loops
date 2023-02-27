            int number = 3487;
            int mod = 0;
            int largdig = 0;
            while (number > 0)
            {
                mod = number % 10;
                if(largdig<mod)
                {
                    largdig = mod;
                }
                number= number / 10;    
            }
Console.WriteLine("the largest digit is "+ largdig);
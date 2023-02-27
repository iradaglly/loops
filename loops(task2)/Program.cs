
            int n = 2345;
            int sum1 = 0;
            int sum2 = 0;
            int rem = 0;
            while (n>0)
            {
                rem = n % 10;
                if (rem % 2 == 0)
                {

                    sum1 += rem;
                    n = n / 10;
                } 
                if (rem % 2 == 1)
    {
                sum2 += rem;
                n= n / 10;
    }
                
            }
Console.WriteLine(sum1*sum2);

int num = 9;
            if (num < 1){
                Console.WriteLine(false);
            }
            else if(num==1) {
    Console.WriteLine("the number is not prime or composite");
            }
      else if (num % 1 == 0)
{
    for (int i = 2; i <= num/2 ; i++)
    {
       Console.WriteLine("the number is composite ");
    }

    
    }
            else { Console.WriteLine("the number is prime"); }
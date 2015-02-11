using System;

    class Program
    {
        static void Main()
        {
            string secretNumber =(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows=int.Parse(Console.ReadLine());
            string guessNumber="";
            int brBulls = 0,brCows=0;
            int[] pomSecret=new int[]{0,0,0,0};
            int[] pomGuess={0,0,0,0};
            int flag=0;
            int flagZeroNumbers = 0;
            bool isBull = false, isCow = false;
            if ((bulls > 4 || cows > 4))
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = 1111; i < 10000; i++)
            {
                guessNumber=i.ToString();
                if (guessNumber.Contains("0"))
                    continue;
                for (int j = 0; j < 4;j++)
                {
                    if (secretNumber[j].Equals(guessNumber[j]))
                    {
                        brBulls++;
                        pomSecret[j] = 1;
                        pomGuess[j] = 1;

                    }
                    
                }
                if (bulls == brBulls)
                {
                    isBull = true;
                }
                for(int j=0;j<4;j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (k == j)
                            continue;
                        
                        if (secretNumber[j].Equals(guessNumber[k]) && pomSecret[j] == 0 && pomGuess[k] == 0)
                        {
                            pomSecret[j] = 1;
                            pomGuess[k] = 1;
                            brCows++;
                        }
                    }
                   

                }
                
                
               
                if (cows == brCows)
                {
                    isCow = true;
                }
                if (isBull && isCow)
                {
                    flagZeroNumbers = 1;
                    if (flag == 0)
                    {
                        Console.Write("{0}", guessNumber);
                        flag = 1;
                    }
                    else
                        Console.Write(" {0}", guessNumber);
                }
                
                    
                brBulls = 0;
                brCows = 0;
                pomGuess=new int[]{0,0,0,0};
                pomSecret = new int[] { 0, 0, 0, 0 };
                isBull = false;
                isCow = false;

            }
            if (flagZeroNumbers == 0)
            {
                Console.WriteLine("No");
            }
        }
    }


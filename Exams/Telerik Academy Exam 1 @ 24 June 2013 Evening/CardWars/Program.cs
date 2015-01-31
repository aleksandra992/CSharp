using System;
using System.IO;
using System.Numerics;

class Program
{
    static void Main()
    {
      // StreamReader reader=new StreamReader("..\\..\\sample-test.txt");
       //Console.SetIn(reader);
        int n = int.Parse(Console.ReadLine());
        string[] cardsFirstPLayer = new String[n];
        string[] cardSecondPlayer = new String[n];
        BigInteger scoreFirst = 0, scoreSecond = 0,score=0;
        string s = "";
        int gamesWonFirst = 0;
        int gamesWonSecond = 0;
        int flag = 0;
        long strengthFirst = 0, stengthSecond = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                s += Console.ReadLine().ToUpper();
            }
            cardsFirstPLayer[i] = s;
            s = "";
            for (int j = 0; j < 3; j++)
            {
                s += Console.ReadLine().ToUpper();
            }
            cardSecondPlayer[i] = s;
            s = "";

        }
        string pom = "", cardsFirst = "", cardsSecond = "";

        for (int i = 0; i < n; i++)
        {
            pom = cardsFirstPLayer[i];

            if (pom.Length == 4)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (pom[j] == '1')
                    {
                        cardsFirst += '1';//one is same as 10 for me :)
                        j++;
                    }
                    else
                        cardsFirst += pom[j];
                }
                cardsFirstPLayer[i] = cardsFirst;

            }
            pom = cardSecondPlayer[i];
            
            if (pom.Length == 4)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (pom[j] == '1')
                    {
                        cardsSecond += '1';//one is same as 10 for me :)
                        j++;
                    }
                    else
                        cardsSecond += pom[j];
                }
                cardSecondPlayer[i] = cardsSecond;

            }
            
             if (cardsFirstPLayer[i].Contains('X'.ToString()) && cardSecondPlayer[i].Contains('X'.ToString())&& flag==0)
                {
                    
                        scoreFirst += 50;
                        scoreSecond += 50;
                        
                    
                    flag = 1;
                    continue;

                    
                }
            for (int h = 0; h < 3; h++)
            {
                flag = 0;
                
                    if (cardsFirstPLayer[i][h] == 'Z')
                    {
                        scoreFirst *= 2;
                    }
                    else
                        if (cardsFirstPLayer[i][h] == 'Y')
                        {
                            scoreFirst -= 200;
                        }
                        else
                            if (cardsFirstPLayer[i][h] == 'X' && flag==0)
                            {
                                Console.WriteLine("X card drawn! Player one wins the match!");
                                return;
                            }



                    if (flag == 0)
                    {
                        strengthFirst += Strength(cardsFirstPLayer[i][h]);
                    }
                
            }


            for (int h = 0; h < 3; h++)
            {
                
               
                   

                    if (cardSecondPlayer[i][h] == 'Z')
                    {
                        scoreSecond *= 2;
                    }
                    else
                        if (cardSecondPlayer[i][h] == 'Y')
                        {
                            scoreSecond -= 200;
                        }
                        else
                            if (cardSecondPlayer[i][h] == 'X' && flag==0)
                            {
                                Console.WriteLine("X card drawn! Player two wins the match!");
                                return;
                            }



                    if (flag == 0)
                    {
                        stengthSecond += Strength(cardSecondPlayer[i][h]);
                    }
            }



            if (strengthFirst > stengthSecond)
            {
                scoreFirst += strengthFirst;
                gamesWonFirst++;
            }
            else
                if (stengthSecond > strengthFirst)
                {
                    scoreSecond += stengthSecond;
                    gamesWonSecond++;
                }
               


            strengthFirst = 0;
            stengthSecond = 0;
            flag = 0;

        }
        if (scoreFirst > scoreSecond)
        {
            Console.WriteLine("First player wins!\nScore: {0}\nGames won: {1}", scoreFirst, gamesWonFirst);
        }
        else
            if (scoreSecond > scoreFirst)
            {
                Console.WriteLine("Second player wins!\nScore: {0}\nGames won: {1}", scoreSecond, gamesWonSecond);
            }
            else
            {
                Console.WriteLine("It's a tie!\nScore: {0}", scoreSecond);
            }
    }

    static int Strength(char card)
    {

        int value = 0;
        switch (card)
        {
            case '2':
                {
                    value = 10;
                    break;
                }
            case '3':
                {
                    value = 9;
                    break;
                }
            case '4':
                {
                    value = 8;
                    break;
                }
            case '5':
                {
                    value = 7;
                    break;
                }
            case '6':
                {
                    value = 6;
                    break;
                }
            case '7':
                {
                    value = 5;
                    break;
                }
            case '8':
                {
                    value = 4;
                    break;
                }
            case '9':
                {
                    value = 3;
                    break;
                }
            case '1':
                {
                    value = 2;
                    break;
                }
            case 'A':
                {
                    value = 1;
                    break;
                }
            case 'J':
                {
                    value = 11;
                    break;
                }
            case 'Q':
                {
                    value = 12;
                    break;
                }
            case 'K':
                {
                    value = 13;
                    break;
                }
            default:
                {
                    value = 0;
                    break;

                }

        }
        return value;
    }
}

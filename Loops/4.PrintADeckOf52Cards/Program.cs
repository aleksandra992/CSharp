using System;

    class Program
    {
        static void Main()
        {
            string[] s = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" }; 
            for (int i = 0; i <s.Length; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    switch(j)
                    {
                        case 1:
                            {
                                Console.Write(s[i] + " of spades, ");
                                break;
                            }
                        case 2:
                            {
                                Console.Write(s[i] + " of clubs, ");
                                break;
                            }
                        case 3:
                            {
                                Console.Write(s[i] + " of hearts, ");
                                break;
                            }
                        case 4:
                            {
                                Console.Write(s[i] + " of diamonds\n");
                                break;
                            }
                        default:
                            break;
                          

                    }
                }
            }
        }
    }


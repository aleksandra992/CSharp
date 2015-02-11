using System;

    class Program
    {
        static void Main()
        {
            string [] matrix=new string[18];
            matrix[0]="000000000000000000";
            decimal price=0M;
            string word="";
            int x,y;
            string pomMatrix;
            
            for(int i=1;i<17;i++)
            {
            
             matrix[i]="0"+Console.ReadLine()+"0";
             
            }
            matrix[17]="000000000000000000";
            while(true)
            {
            word=Console.ReadLine();


            if (word == "paypal")
            {
                Console.WriteLine("{0:0.00}", price);
                break;
            }
            else
            {
                x = 1 + int.Parse(Console.ReadLine());
                y = 1 + int.Parse(Console.ReadLine());
                if (word == "what is")
                {
                    if (matrix[x][y] == '1')
                    {
                        pomMatrix = matrix[x - 1].Substring(y - 1, 3) + matrix[x].Substring(y - 1, 1) + matrix[x].Substring(y + 1, 1) + matrix[x + 1].Substring(y - 1, 3);
                        if (!pomMatrix.Contains("0"))
                        {
                            Console.WriteLine("cookie");


                        }
                        else
                            if (!pomMatrix.Contains("1"))
                            {
                                Console.WriteLine("cookie crumb");
                            }
                            else
                            {
                                Console.WriteLine("broken cookie");
                            }
                    }
                    else
                    {
                        Console.WriteLine("smile");
                    }
                }
                else
                    if (word == "buy")
                    {

                        if (matrix[x][y] == '0')
                        {
                            Console.WriteLine("smile");
                        }
                        else
                        {
                            pomMatrix = matrix[x - 1].Substring(y - 1, 3) + matrix[x].Substring(y - 1, 1) + matrix[x].Substring(y + 1, 1) + matrix[x + 1].Substring(y - 1, 3);
                            if (!pomMatrix.Contains("0"))
                            {
                                char[] a = matrix[x - 1].ToCharArray();
                                a[y - 1] = '0';
                                a[y] = '0';
                                a[y + 1] = '0';
                                char[] b = matrix[x].ToCharArray();
                                b[y - 1] = '0';
                                b[y] = '0';
                                b[y + 1] = '0';
                                char[] c = matrix[x + 1].ToCharArray();
                                c[y - 1] = '0';
                                c[y] = '0';
                                c[y + 1] = '0';
                                matrix[x - 1] = new string(a);
                                matrix[x] = new string(b);
                                matrix[x + 1] = new string(c);





                                price += 1.79M;
                            }
                            else
                            {
                                Console.WriteLine("page");
                            }
                        }

                    }
            }
            }
        }
        }

    


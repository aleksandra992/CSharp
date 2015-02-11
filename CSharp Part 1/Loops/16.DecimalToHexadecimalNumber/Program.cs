using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            List<string> s = new List<string>();
            int i=0;
            string pom = " ";
            while (n != 0)
            {
                s.Add((n % 16).ToString());
                n = n / 16;
                

            }
            
            string [] str=s.ToArray();

              for (int j = s.Count-1; j >=0; j--)
              {
                  pom = str[j].ToString();

                  switch (pom)
                  {
                      case "10":
                          {
                              pom = "A";
                              break;
                          }
                      case "11":
                          {
                              pom = "B";
                              break;
                          }
                      case "12":
                          {
                              pom = "C";
                              break;
                          }
                      case "13":
                          {
                              pom = "D";
                              break;
                          }
                      case "14":
                          {
                              pom = "E";
                              break;
                          }
                      case "15":
                          {
                              pom = "F";
                              break;
                          }
                      default: { break;}

                  }
                  Console.Write(pom);
 
              }
             
        }
    }


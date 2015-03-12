using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DecodeAndDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
           // StreamReader reader=new StreamReader("..\\..\\test.txt");
            //Console.SetIn(reader);
            string input = Console.ReadLine();
            
            string messageWithoutCypherLen = input.TrimEnd(new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
           
            
            int lenghtDigits=input.Length-messageWithoutCypherLen.Length;
            int lenghtCypher =int.Parse( input.Substring(input.Length-lenghtDigits,lenghtDigits));
                string encodedMessage = Encode(messageWithoutCypherLen);
            string Cypher = encodedMessage.Substring(encodedMessage.Length - lenghtCypher, lenghtCypher);
            string Message = encodedMessage.Substring(0, encodedMessage.Length - lenghtCypher);
            int lenghtMessage = Message.Length;
           
            
            StringBuilder result =new StringBuilder();
            int k = 0;
            if (lenghtMessage >= lenghtCypher)
            {
                
                for (int i = 0; i < lenghtMessage; i++)
                {
                    int prv = Message[i] - 65;
                    int vtor = Cypher[k] - 65;
                    result.Append((char)((prv ^ vtor) + 65));

                    k++;
                    if (k == lenghtCypher)
                    {
                        k = 0;
                    }
                }
                Console.WriteLine(result);
            }
            else
            {
                for (int i = 0; i < lenghtCypher; i++)
                {
                    int prv = Message[k] - 65;
                    int vtor = Cypher[i] - 65;
                    result.Append((char)((prv ^ vtor) + 65));
                    k++;
                    if (k == lenghtMessage)
                    {
                        k = 0;
                        Message = new String(result.ToString().ToCharArray());
                        result.Clear();
                    }
                }
                
               Console.WriteLine(result + Message.Substring(k, Message.Length - k));
            }
        }
        static string Encode(string str)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder number=new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if(char.IsDigit(str[i]))
                {
                while(char.IsDigit(str[i]))
                {
                    number.Append(str[i]);
                    
                    i++;

                }
                result.Append(new String(str[i], int.Parse(number.ToString())));
                number.Clear();
                }
                else
                    result.Append(str[i]);
               
            }
            return result.ToString();
        }
    }
}

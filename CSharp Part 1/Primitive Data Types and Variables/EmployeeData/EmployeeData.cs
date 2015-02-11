using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Aleksandra";
            string lastName = "Stoycheva";
            byte age = 22;
            string gender = "female";
            string personalID = "123456789";
            string uniqueEmployeeNumber = "222222222";


            Console.WriteLine("First name:{0},Last name:{1},Age:{2},Gender{3},Personal ID:{4},Unique employee number:{5}", firstName, lastName, age, gender, personalID, uniqueEmployeeNumber);

        }
    }
}

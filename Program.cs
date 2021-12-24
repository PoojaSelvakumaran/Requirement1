using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Requirement1

{

   internal class Program

    {

        static void Main(string[] args)

        {

            User[] users = new User[2];

            for (int i = 0; i < 2; i++)

            {

                Console.WriteLine("Enter user {0} details: ", i + 1);

                string userdetails = Console.ReadLine();

                string[] users_de = userdetails.Split(',');

                users[i] = new User(users_de[0], users_de[1], users_de[2]);

            }

            for (int i = 0; i < 2; i++)

            {

                Console.WriteLine("User {0} :", i + 1);

                Console.WriteLine(users[i]);



            }



            if (users[0].Equals(users[1]))

            {

                Console.WriteLine("User 1 is same as User 2");



            }

            else

            {

                Console.WriteLine("User 1 and User 2 are different");



            }



        }

    }

}

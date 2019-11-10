using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocailNetwork
{
    class Profile
    {
        public List<User> Friends;
        public List <Interests> Interests { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            User myUser = new User();
            myUser.Name = "Anna";
            myUser.Dateofbirth = new DateTime(2000, 10, 11);
            myUser.Gender = "Female";

            User johnuser = new User()
            {
                Name = " John",
                Dateofbirth = new DateTime(2000, 11, 22),
                Gender = "Male"

            };

            User jackuser = new User("Jack", new DateTime(2000, 5, 11), "Male");




        }



    }
}

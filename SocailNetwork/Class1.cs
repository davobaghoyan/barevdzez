using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocailNetwork
{
    class User
    {
        private string gender;
        private  DateTime dateofbirth;
        public string Name { get; set; }
        public DateTime Dateofbirth
        {
            get { return this.Dateofbirth; }
            set
            {
                if (this.Dateofbirth.Year < 2010)
                {
                    this.dateofbirth = value;
                 }

                else
                {
                    this.dateofbirth = DateTime.Now;
                    this.dateofbirth = DateTime.Now;
                }
            }
        }

        public string Gender { get; set; }

        public User ()
        { }

        public User (String name, DateTime dateofbirth,string gender)
        {
            this.Name = name;
            this.Dateofbirth = dateofbirth;
            this.Gender = gender;
        }


        public Profile Userprofile { get; set; }



        public void Createprofile ()

        {
            this.Userprofile = new Profile();
        }

    }
}

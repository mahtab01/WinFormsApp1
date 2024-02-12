using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
     public class St
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public int ID { get; set; }

        public bool Gender { get; set; }

        public string GenderName
        {
            get
            {
                if (Gender)
                    return "زن";
                else
                    return "مرد";
            }
        }
    }
}

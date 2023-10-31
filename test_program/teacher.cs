using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0809
{
    internal class teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CodeTC { get; set; }

        public int CodeID { get; set; }

        public teacher(string firstname, string lastname, int codetc, int codeid)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.CodeTC = codetc;
            this.CodeID = codeid;
        }





    }
}

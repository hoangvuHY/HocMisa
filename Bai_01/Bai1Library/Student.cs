using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Library
{
    public class Student
    {
        
        public string studentCode { get; set; }
        public string fullName { get; set; }
        public string address {
            get { return "HCM";     }
            set { } 
        }
        //Field
        public string Email;
    }
}

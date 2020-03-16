using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai2Library;
namespace Bai2Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Helo");
            student.studentCode = "saddsa";
            student.fullName = " SDSAD ASDSAD";
            student.address = " HA NOI";
            student.Email = "sdfsd@fsdf.com";
            Console.WriteLine(student.address);
        }
    }
}

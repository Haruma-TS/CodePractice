using ClassLibrary1_BL.Controller;
using ClassLibrary1_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ку");
            Console.WriteLine("Ti RODIPIT. Enter UserName");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Gender");
            var gender = Console.ReadLine();
            Console.WriteLine("Enter BirthDate");
            var birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Weight");
            var weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            var height = double.Parse(Console.ReadLine());
            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();
        }
    }
}

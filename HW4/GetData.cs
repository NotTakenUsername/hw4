using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW3;

namespace HW4
{
    public class GetData
    {
        // get name 
        static public string Name()
        {
            string name = "";
            bool isEntered = false;
            while (!isEntered)
            {
                Console.WriteLine("\nName:");
                name = Console.ReadLine();
                if (name.Length > 0)
                {
                    isEntered = true;
                }
            }
            return name;
        }

        //get date 
        static public DateTime Date()
        {
            DateTime isDate;
            Console.WriteLine("Date of birth:");
            while (!DateTime.TryParse(Console.ReadLine(), out isDate))
            {
                Console.WriteLine("Invalid date. Format is mm.dd.yyyy");
            }
            return isDate;
        }

        //get Profile
        static public string Profile()
        {
            string profile = "";
            bool isEntered = false;
            while (!isEntered)
            {
                Console.WriteLine("Profile:");
                profile = Console.ReadLine();
                if (profile.Length > 0)
                {
                    isEntered = true;
                }
            }
            return profile;


        }

        //base salary
        static public float Salary()
        {
            float salary;
            Console.WriteLine("Base Salary($): ");
            while (!Single.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Please, enter float value:");
            }
            return salary;
        }    
       
        //filepath
        static public string filePath()
        {
            bool isEntered = false;
            string filePath ="";
            while (!isEntered)
            {
                Console.WriteLine("Specify filepath: ");
                filePath = Console.ReadLine();
                if (filePath.Length > 0)
                {
                    isEntered = true;
                }
            }
            return filePath;
        }
    }
}

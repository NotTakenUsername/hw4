using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Worker : Person, IWorker, IComparable
    {
        public float baseSalary { get; set; }
        public string work { get; set; }
        public string Profile { get; set; }
        private int completedWork;

        public int DoSomething(string work)
        {
            if (work.Length > 0)
                completedWork++;
            return completedWork;
        }

        public float CalculateSalary(int counter)
        {
            float salary;
            salary = completedWork * baseSalary;
            return salary;
        }

        public Worker()
        {
            Name = "Undefined";
            this.birthDate = new DateTime(14, 11, 1988);
            baseSalary = 350;
            completedWork = 0;
            work = "";
        }

        public Worker(string name, DateTime birthDate, float baseSalary)
        {
            this.Name = name;
            this.birthDate = birthDate;
            this.work = "play tekken with buddy";
            this.baseSalary = baseSalary;
        }
        public void Reset()
        {
            this.completedWork = 0;
        }

        public int CompareTo(Worker other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return this.Name.CompareTo(other.Name);
            }
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Decision
    {
        static public bool AddOrQuit(bool AddWorker)
        {
            bool correctKey = false;
                       
            while (!correctKey)
            {
                ConsoleKeyInfo choise = Console.ReadKey();
                if (choise.KeyChar == 'y' || choise.KeyChar == 'Y')
                {
                    AddWorker = true;
                    correctKey = true;
                }
                else if (choise.KeyChar == 'n' || choise.KeyChar == 'N')
                {
                    AddWorker = false;
                    correctKey = true;
                }
                else
                {
                    Console.WriteLine("Incorrect input.Press Y to add new record. Press N to quit:");
                    correctKey = false;
                }
            }

            return AddWorker;

        }
    }
}

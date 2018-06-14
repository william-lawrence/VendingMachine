using Capstone.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
			VendingMachine vm = new VendingMachine();

            MainMenu mainmenu = new MainMenu(vm);
            mainmenu.Display();
        }
    }
}

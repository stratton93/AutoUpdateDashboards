using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace AutoUpdateDashboards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dashboardNames = { "Bedford", "Blacksburg", "Botetourt", "Cave Spring", "Christiansburg", "Fairlawn", "Galax"};
            addListValues(dashboardNames);
        }

        static List<string> addListValues(string[] x)
        {
            List<string> t = new List<string>();
            foreach (string v in x)
            {
                t.Add(v);
            }
            return t;
        }
        static void printListValues(List<string> w)
        {
            foreach (string s in w)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}

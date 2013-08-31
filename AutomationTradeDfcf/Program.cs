using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTradeDfcf
{
    class Program
    {
        static void Main(string[] args)
        {
            Dfcf app = new Dfcf();
            app.StartApp();
            app.Test1();
            app.Test2();
            app.CloseApp();
        }
    }
}

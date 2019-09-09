using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Demo
{
    class Logger
    {
        private Logger()
        {

        }

        //propfull + TAB + TAB

        private static Logger instance;
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                    instance = new Logger();
                return instance;
            }
        }



        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"[{DateTime.Now.ToShortTimeString()}]: {message}");
            Console.ResetColor();
        }
    }
}

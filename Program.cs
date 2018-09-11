using System;

namespace Stopwatch
{
    class Stopwatch
    {
        DateTime startTime;
        DateTime stopTime;
        DateTime duration;
        
        public void start()
        {
            this.startTime = DateTime.Now;
            
        }
        public void stop()
        {
            this.stopTime = DateTime.Now;
            this.duration = this.stopTime - this.startTime;
            
        }        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var myWatch = new Stopwatch();
            myWatch.start();
            string myString = Console.ReadLine();
            
            while(myString != "")
                {
                     myString = Console.ReadLine();
                }
            
            myWatch.stop();
         

            
        }
    }
}

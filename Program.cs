using System;

namespace Stopwatch
{
    class Stopwatch
    {
        DateTime startTime;
        DateTime stopTime;
        TimeSpan duration;
        
        public void start()
        {
            this.startTime = DateTime.Now;
            
        }
        public void stop()
        {
            this.stopTime = DateTime.Now;
            this.duration = this.stopTime - this.startTime;
        
            
        }        
        public void printDuration()
        {
            Console.WriteLine(String.Format("Duraation {0} ", this.duration));
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
            myWatch.printDuration();
         

            
        }
    }
}

using System;

namespace DesignPatternsDemo
{
    
    public abstract class Handler
    {
        protected Handler next;

        public void SetNext(Handler handler)
        {
            next = handler;
        }

        public abstract void Handle(int level);
    }

    
    public class InfoHandler : Handler
    {
        public override void Handle(int level)
        {
            if (level == 1)
            {
                Console.WriteLine("Info handled.");
            }
            else
            {
                next?.Handle(level);
            }
        }
    }

    
    public class ErrorHandler : Handler
    {
        public override void Handle(int level)
        {
            if (level == 2)
            {
                Console.WriteLine("Error handled.");
            }
            else
            {
                next?.Handle(level);
            }
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Handler infoHandler = new InfoHandler();
            Handler errorHandler = new ErrorHandler();

            // Setting up the chain
            infoHandler.SetNext(errorHandler);
          
            infoHandler.Handle(2);  // Output: Error handled.

            infoHandler.Handle(1);  // Output: Info handled.

            infoHandler.Handle(3);  // No output
        }
    }
}

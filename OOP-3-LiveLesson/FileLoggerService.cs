using System;
namespace OOP_3_LiveLesson
{
    public class FileLoggerService : IloggerService
    {
        public void log()
        {
            Console.WriteLine("log has been added to the file");
        }
    }
}


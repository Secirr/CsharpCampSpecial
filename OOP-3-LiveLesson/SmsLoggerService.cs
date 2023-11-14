using System;
namespace OOP_3_LiveLesson
{
    public class SmsLoggerService : IloggerService
    {
        public void log()
        {
            Console.WriteLine("Sended the SMS");
        }
    }
}


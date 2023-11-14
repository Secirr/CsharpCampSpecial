using System;
namespace OOP_3_LiveLesson
{
    public class EntrepreneurCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Entrepreneur Credit payment plan has been calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}


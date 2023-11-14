using System;
namespace OOP_3_LiveLesson
{
	public class HouseCreditManager : ICreditManager
	{

        public void Calculate()
        {
            Console.WriteLine("House Credit payment plan has been calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}


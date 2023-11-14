using System;
namespace OOP_3_LiveLesson
{
	public class VehicleCreditManager : ICreditManager
	{

        public void Calculate()
        {
            Console.WriteLine("Vehicle Credit payment plan has been calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}


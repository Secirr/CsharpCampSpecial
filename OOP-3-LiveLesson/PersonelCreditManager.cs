using System;
namespace OOP_3_LiveLesson
{
	public class PersonelCreditManager : ICreditManager
	{

        public void Calculate()
        {
            Console.WriteLine("Personel Credit payment plan has been calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}


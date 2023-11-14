using System;
namespace OOP_3_LiveLesson
{
	public class ApplicationManager
	{
		public void Apply(ICreditManager creditManager, List<IloggerService> loggers)
		{
			creditManager.Calculate();
			foreach (var logger in loggers)
			{
				logger.log();
			}
		}

		public void CheckCreditInfo(List<ICreditManager> credits, List<IloggerService> loggers)
		{
			foreach (var credit in credits)
			{
				credit.Calculate();
			}
			foreach (var logger in loggers)
			{
				logger.log();
			}

		}
	}
}


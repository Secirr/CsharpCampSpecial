using OOP_3_LiveLesson;

ICreditManager houseCreditManager = new HouseCreditManager();
ICreditManager personelCreditManager = new PersonelCreditManager();
ICreditManager vehicleCreditManager = new VehicleCreditManager();
ICreditManager entrepreneurCreditManager = new EntrepreneurCreditManager();


IloggerService databaseLoggerService = new DatabaseLoggerService();
IloggerService smsLoggerService = new SmsLoggerService();
IloggerService fileLoggerService = new FileLoggerService();

List<ICreditManager> credits = new List<ICreditManager>() {entrepreneurCreditManager, personelCreditManager};
List<IloggerService> loggers = new List<IloggerService>() {databaseLoggerService, smsLoggerService};




ApplicationManager applicationManager = new ApplicationManager();
applicationManager.Apply(entrepreneurCreditManager,loggers);
//applicationManager.CheckCreditInfo(credits,loggers);


Console.ReadKey();
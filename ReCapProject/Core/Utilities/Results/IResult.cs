using System;
namespace Core.Utilities.Results
{
	//Temel Yapı: Bir dönüş tipi olmayan metotlar (Void)

	public interface IResult
	{
		bool Success { get; }

		string Message { get; }
	}
}


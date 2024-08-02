using System;
namespace FactoryPattern
{
	public class Sedan : IVehicle
	{
		public void Drive()
		{
			Console.WriteLine("Sedan is driving.");
		}
		public Sedan()
		{
		}
	}
}


using System;
namespace FactoryPattern
{
	public class Batmobile : IVehicle
	{
		public void Drive()
		{
			Console.WriteLine("Batmobile is zooming.");
		}
		public Batmobile()
		{
		}
	}
}


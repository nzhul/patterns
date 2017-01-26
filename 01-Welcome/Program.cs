using _01_Welcome.Behaviors.Implementation;

namespace _01_Welcome
{
	class Program
	{
		static void Main(string[] args)
		{
			//Duck mallard = new MallardDuck();
			//mallard.PerformQuack();
			//mallard.PerformFly();

			Duck model = new ModelDuck();
			model.PerformFly();
			model.SetFlyBehavior(new FlyRocketPowered());
			model.PerformFly();
		}
	}
}

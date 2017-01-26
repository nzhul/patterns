namespace _03_StarbuzzCoffee_Decorator.Beverages.Abstraction
{
	public abstract class Beverage
	{
		public string Description { get; protected set; }
		public BeverageType Type { get; protected set; }

		public BeverageType GetSize()
		{
			return Type;
		}

		public void SetSize(BeverageType type)
		{
			Type = type;
		}

		public virtual string GetDescription()
		{
			return Description;
		}

		public abstract double Cost();
	}
}

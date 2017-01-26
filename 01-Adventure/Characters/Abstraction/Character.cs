using _01_Adventure.Behaviors.Abstraction;

namespace _01_Adventure.Characters.Abstraction
{
	public abstract class Character
	{
		public IWeapon weapon { get; protected set; }

		public abstract void Display();

		public void Fight()
		{
			weapon.UseWeapon();
		}

		public void SetWeaponBehavior(IWeapon wb)
		{
			this.weapon = wb;
		}
	}
}

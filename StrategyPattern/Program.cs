using System;

namespace StrategyPattern
{
    public abstract class Duck {
		protected IFlyBehavior flyBehavior;
		protected IQuackBehavior quackBehavior;
		public IQuackBehavior QuackBehavior{ //this is a C# property
			get {return quackBehavior;}
			set {quackBehavior = value;}
		}
		public IFlyBehavior FlyBehavoir { //this is a C# property
		  	get {return flyBehavior;}
      		set {flyBehavior = value;}
		}
		public abstract void Display();
		public void PerformFly() {FlyBehavoir.Fly();}
		public void PerformQuack() {QuackBehavior.Quacking();}
		public void Swim() {Console.WriteLine("All ducks float, even decoys!");}
	}
public class RubberDuck : Duck {
		public RubberDuck() {
			quackBehavior = new Squeak();
			flyBehavior = new FlyNoWay();
		}
		public override void Display() {
			Console.WriteLine("I'm a rubber duck");
		}
}

    //Fly behaviour interface and implementations
public interface IFlyBehavior {void Fly();}
public class FlyWithWings : IFlyBehavior {
 	public void Fly() {Console.WriteLine("I'm flying!!");}
}
public class FlyNoWay : IFlyBehavior {
 	public void Fly() {Console.WriteLine("I can't fly.");}
}
//Quack behaviour interface and implementations
public interface IQuackBehavior {void Quacking();}
public class Quack : IQuackBehavior {
 	public void Quacking() {Console.WriteLine("Quack");}
}
public class Squeak : IQuackBehavior {
 	public void Quacking() {Console.WriteLine("Squeak");}
}
//Main Demo class
class MainDucks {
    static void Main() {
      Duck RubberDuck = new RubberDuck();
      RubberDuck.PerformFly();
      RubberDuck.PerformQuack();
      Console.ReadKey();
    }
}
}

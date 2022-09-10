using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
        public bool IsAsleep { get; private set; } = false;

        public abstract string Setting { get; protected set; }

        public abstract int AverageHeight { get; protected set; }
               
        public void GoToSleep() => IsAsleep = true;
      
        public void WakeUp() => IsAsleep = false;

        public abstract string Eat();
       
    }
}

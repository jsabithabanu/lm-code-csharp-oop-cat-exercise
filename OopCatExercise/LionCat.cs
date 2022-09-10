using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class LionCat : Cat
    {
        private const int _AVERAGE_HEIGHT = 1100;
        private const string _COMMENT_FOLLOWING_EATING = "Roar!!!!";

        public override int AverageHeight { get; protected set; } = _AVERAGE_HEIGHT;

        public override string Setting { get; protected set; } 

        public override string Eat() => _COMMENT_FOLLOWING_EATING;

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class CheetahCat : Cat
    {
        private const string _COMMENT_FOLLOWING_EATING = "Zzzzzzz";
        public override int AverageHeight { get; protected set; }

        public override string Setting { get; protected set; }

        public override string Eat() => _COMMENT_FOLLOWING_EATING;
    }
}
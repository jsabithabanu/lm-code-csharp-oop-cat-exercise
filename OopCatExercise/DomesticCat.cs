using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        private const string _SETTING = "domestic";
        private const int _AVERAGE_HEIGHT = 23;
        private const string _COMMENT_FOLLOWING_EATING = "Purrrrrrr";
        private const string _RANDOM_COMMENT_FOLLOWING_EATING = "It will do I suppose";

        public bool _someDomesticCat { get; private set; }

        // Default constructor (to use if they are ordinary domestic cats)
        public DomesticCat()
        {
        }

        /// <summary>
        /// Overloaded constructor (to use if they are some domestic cats
        /// that make a random dismissive following eating)
        /// </summary>
        /// <param name="someDomesticCats"></param>
        public DomesticCat(bool someDomesticCats)
        {
            _someDomesticCat = someDomesticCats;
        }
       
        public override int AverageHeight { get; protected set; } = _AVERAGE_HEIGHT;

        public override string Setting { get; protected set; } = _SETTING;

        // Ordinary domestic cat
        public override string Eat() => _COMMENT_FOLLOWING_EATING;
       
        // Method to generate a random dismissive following eating for some domestic cats
        public string Eat(bool _someDomesticCat)
        {
            var someRandomDomesticCat = new Random();
            // Checks if the random number generated is 0 within the range 0 to 2
            // and return value
            return (someRandomDomesticCat.Next(0, 2) == 0)
                ? _RANDOM_COMMENT_FOLLOWING_EATING
                : _COMMENT_FOLLOWING_EATING;            
        }
    }
}
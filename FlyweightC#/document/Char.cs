using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    abstract class Char
    {
        //stan wewnętrzny
        protected char @char;

        public Char(char @char)
        {
            this.@char = @char;
        }

        public void DisplayText()
        {
            Console.Write(@char);
        }
    }
}

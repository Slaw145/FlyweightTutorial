using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class CharsFactory
    {
        private Dictionary<char,Char> chars=new Dictionary<char,Char>();
        Char letter = null;
        public int NumberRepeatingChars;

        public Char GetChar(char GiveChar)
        {
            
            if (chars.Keys.Contains(GiveChar))
            {
                letter = chars[GiveChar];
                NumberRepeatingChars++;
            }
            else
            {
                switch (GiveChar)
                {
                    case 'P':
                        letter = new CharP();
                        break;
                    case 'Z':
                        letter = new CharZ();
                        break;
                    case 'R':
                        letter = new CharR();
                        break;
                    case 'K':
                        letter = new CharK();
                        break;
                    case 'L':
                        letter = new CharL();
                        break;
                    case 'A':
                        letter = new CharA();
                        break;
                    case 'D':
                        letter = new CharD();
                        break;
                    case 'O':
                        letter = new CharO();
                        break;
                    case 'W':
                        letter = new CharW();
                        break;
                    case 'T':
                        letter = new CharT();
                        break;
                    case 'E':
                        letter = new CharE();
                        break;
                    case 'S':
                        letter = new CharS();
                        break;
                    case 'Y':
                        letter = new CharY();
                        break;
                    case ' ':
                        letter = new Space();
                        break;
                }
                chars.Add(GiveChar, letter);
            }
            return letter;
        }
    }
}

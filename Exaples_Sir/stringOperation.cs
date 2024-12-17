using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.Exaples_Sir
{
    public class stringOperation
    {

        public  string RemoveArrows(string T)
        {
            // Convert the string to a list of characters for easier manipulation.
            var chars = new System.Collections.Generic.List<char>(T);
            bool arrowFound;
            do
            {
                arrowFound = false;
                for (int i = 0; i < chars.Count; i++)
                {
                    if (chars[i] == '<' && i > 0)
                    {
                        // Left arrow found, remove the arrow and the character to its left.
                        chars.RemoveAt(i); // Remove the '<'
                        chars.RemoveAt(i - 1); // Remove the character to its left
                        arrowFound = true;
                        break; // Restart the loop since the indices have shifted.
                    }
                    else if (chars[i] == '>' && i < chars.Count - 1)
                    {
                        // Right arrow found, remove the arrow and the character to its right.
                        chars.RemoveAt(i + 1); // Remove the character to its right
                        chars.RemoveAt(i); // Remove the '>'
                        arrowFound = true;
                        break; // Restart the loop since the indices have shifted.
                    }
                }
            } while (arrowFound);
            // Convert the list back to a string and return it.
            return new string(chars.ToArray());
        }
    }

}


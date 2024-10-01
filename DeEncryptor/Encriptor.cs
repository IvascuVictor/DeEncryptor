using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeEncryptor
{
    internal class Encriptor
    {
        public char findHighestOccurence(Dictionary<char, int> dictionary)
        {
            Dictionary<char, int> orderedD = new Dictionary<char, int>();   
            char max = (char)0;
            int amount = 0;
            foreach (KeyValuePair<char, int> kvp in dictionary)
            {
                orderedD[kvp.Key] = kvp.Value;
                if (kvp.Value > amount && 97 <= kvp.Key && kvp.Key <= 122)
                {
                    amount=kvp.Value;
                    max= kvp.Key;
                }
                
            }
            orderedD.OrderByDescending(key => key.Value);
            Console.WriteLine("The highest occuring character is: " + orderedD.ElementAt(0) + "occuring " + orderedD.ElementAt(0).Value + " times");
            Console.WriteLine("followed by " + orderedD.ElementAt(1) + "occuring " + orderedD.ElementAt(1).Value + " times");


            return max;
        }
        public int getOffset(Dictionary<char, int> sourceD, Dictionary<char, int> fileD) { 
            int offset = 0;
            
            offset = (int)findHighestOccurence(sourceD)-(int)findHighestOccurence(fileD);
            Console.WriteLine("It was determined the offset is : "+offset);
            return offset;

        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeEncryptor
{
    internal class Reader
    {
        int letterTotal ;
        int lineTotal ;
        string fileName ="";
        public Reader(string s)
        {
            fileName = s;
            letterTotal = 0;
            lineTotal = 0;
            
        }
       
        public Dictionary<char, int>  readAndCounter()
        {
            Console.WriteLine("Reading input file: \""+fileName+"\".");
            Dictionary<char, int> letterCountD = new Dictionary<char, int>();
            try
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = String.Empty;
                    while ((s = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(s);
                        foreach (char c in s)
                        {
                            if (letterCountD.ContainsKey(c))
                            {
                                letterCountD[c]++;
                                letterTotal++;

                            }
                            else
                            {
                                letterCountD[c] = 1;
                                letterTotal++;
                            }
                            lineTotal++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            return letterCountD;

        }
        public void printLinesNChars()
        {
            Console.WriteLine("The file : \"" + fileName + "\" has " + lineTotal + "lines and " + letterTotal + "characters");
        }
       



    }
}

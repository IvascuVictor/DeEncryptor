using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeEncryptor
{
    internal class Writer
    {
        string fileOut = "";
        public Writer(string s)
        {
            fileOut = s;
        }
        public void withOffset(string fileIn, int o)
        {
            Console.WriteLine("Writing output file to : \"" + fileOut + "\"");
            try
            {
                using (StreamReader readtext = new StreamReader(fileIn))

                {
                    using (StreamWriter writetext = new StreamWriter(fileOut))
                    {
                        string str = String.Empty;
                        while ((str = readtext.ReadLine()) != null)
                        {
                            writetext.Write(postOffset(str, o));

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


        }
        public string postOffset(string s, int o)
        {

            string decodeString = "";
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in s)
            {

                stringBuilder.Append(charDeEncriptor(c, o));
                decodeString = stringBuilder.ToString();

            }
            return decodeString;
        }
        public char charDeEncriptor(char c, int o)
        {
            char decoded = c;
            if (c >= 'a' && c <= 'z')
            {
                int value = (int)c;
                decoded = (char)(((int)c - 97 + o) % 26 + 97);
            }
            else if (c >= 'A' && c <= 'Z')
            {
                decoded = (char)(((int)c - 65 + o) % 26 + 65);

            }
            return decoded;
        }
        public void displayFile()
        {
            Console.WriteLine("Do you wish to open the file:");
            Console.WriteLine("Y (display the decrypted file to the screen)\r\nN (End the program).");
            String choice = Console.ReadLine();
            choice = choice.Trim().ToLower();
            if (choice.StartsWith("y"))
            {
                //execute open the file
            }
            else if (choice.StartsWith("n"))
            {
                //execute close file
            }
            else
            {
                Console.WriteLine("invalid input.......Goodbye");
            }

        }
    }
    }


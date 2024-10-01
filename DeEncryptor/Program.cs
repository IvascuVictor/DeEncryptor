using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeEncryptor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string filePath00 = "C:\\Users\\MCS\\Desktop\\school\\.NET\\2024-09-23_DeEncryptor\\DeEncryptor\\DeEncryptor\\a_Test_File.txt";
            //string warNPeace = "C:\\Users\\MCS\\Desktop\\school\\.NET\\2024-09-23_DeEncryptor\\DeEncryptor\\DeEncryptor\\War and peace.txt";
            //string outFile = "OutputTest.txt";

            string filePath00 = args[1];
            string warNPeace = args[0];
            string outFile = args[2];


            Reader testFileReader = new Reader(filePath00);
            testFileReader.printLinesNChars();

            Reader warReader = new Reader(warNPeace);

            Encriptor encriptor = new Encriptor();
            int offset = encriptor.getOffset(warReader.readAndCounter(),testFileReader.readAndCounter());
            Writer testWriter = new Writer(outFile);
            testWriter.withOffset(filePath00, offset);

            

        }
    }
}

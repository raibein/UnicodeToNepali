using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnicodeToNepali
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * // Start : 1st Method
            string inputString = new string(new char[] { '\u70B9', '\u83DC' }); // 点菜
            byte[] stringBytes = Encoding.Unicode.GetBytes(inputString);
            char[] stringChars = Encoding.Unicode.GetChars(stringBytes);
            StringBuilder builder = new StringBuilder();
            Array.ForEach<char>(stringChars, c => builder.AppendFormat("\n convert into unicode : {0:X}", (int)c));
            Console.WriteLine(builder);

            Console.ReadKey(true);
            // End : 1st Method
            */




             // Start : 2nd Method
             /*
            char a = '\u091A';

            Console.WriteLine(String.Format("{0} Character has code : {1}", a, ((int)a).ToString()));
            //Console.WriteLine(Encoding.UTF8.GetBytes("{0}").ToString() + String.Format(" - Character has code : {1}", a, ((int)a).ToString()));

            File.WriteAllBytes("D:\\file.txt", Encoding.UTF8.GetBytes(a.ToString()));

            Console.Read();
            */
            // End : 2nd Method



            // Start : 3rd Method
            /*
            string[] a = { "ka" };

            Encoding unicodeEncoding = Encoding.Unicode;

            byte[] unicodeBytes;

            foreach (var stringValue in a)
            {
                unicodeBytes = unicodeEncoding.GetBytes(stringValue);

                Console.Write("Encoded bytes: ");
                for (int ctr = 0; ctr < unicodeBytes.Length; ctr++)
                    Console.Write("{0} has value {1:X2}", ctr % 20 == 0 ? Environment.NewLine : "\n", unicodeBytes[ctr]);
                    Console.WriteLine();
                    File.WriteAllBytes("D:\\file.txt", unicodeBytes);
            }
            
            Console.ReadKey(true);

            //byte[] unicodeBytes = unicodeEncoding.GetBytes(a);
            //string[] stringChars = Encoding.Unicode.GetString(a);

            //Console.WriteLine(String.Format("{0} Character has code : {1}", a));

            //File.WriteAllBytes("D:\\file.txt", Encoding.UTF8.GetBytes(a.ToString()));
            */
            // End : 3rd Method



            // Start : 4th Method
            /*
            string value = "ka";
            decimal d = Convert.ToDecimal(value);
            string s = d.ToString();
            Console.Write("{0} has value {1}", value, s);
            Console.Read();
            */
            // End : 4th Method



            // Start : 5th Method
            string a = new string(new char[] { '\u0915', '\u0916', '\u0917', '\u0918', '\u0919', '\u091A', '\u091B'});
            string b = "\u0915\u0916\u0917\u0918\u0919\u091A\u091B";
            string[] locResult = Regex.Split(a, "[\r\n]+");

            byte[] stringBytes = Encoding.Unicode.GetBytes(a);
            char[] stringChars = Encoding.Unicode.GetChars(stringBytes);

            StringBuilder builder = new StringBuilder();
            Array.ForEach<char>(stringChars, c => builder.AppendFormat("\n convert into unicode : {0:X}", (int)c));
            Console.WriteLine(builder);

            Console.WriteLine(String.Format("\n Character has code : {1}", a, ((string)a)));
            File.WriteAllBytes("D:\\file.txt", Encoding.UTF8.GetBytes(a.ToString()));

            Console.ReadKey(true);
            // End : 5th Method



            // Start : 6th Method
            /*
            string unicodeString = "This string contains the unicode character Pi (\u03a0)";

            // Create two different encodings.
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            // Convert the string into a byte array.
            byte[] unicodeBytes = unicode.GetBytes(unicodeString);

            // Perform the conversion from one encoding to the other.
            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

            // Convert the new byte[] into a char[] and then into a string.
            char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);

            // Display the strings created before and after the conversion.
            Console.WriteLine("Original string: {0}", unicodeString);
            Console.WriteLine("Ascii converted string: {0}", asciiString);

            Console.ReadKey(true);
            */
            //End : 6th Method
        }
    }
}

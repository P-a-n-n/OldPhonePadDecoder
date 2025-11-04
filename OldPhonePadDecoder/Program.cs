using System;
using OldPhonePadDecoderApp;

namespace OldPhonePadDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Old Phone Keypad Decoder");

            string[] testInputs = new string[]
            {
                "33#", //E
                "227*#",//B
                "4433555 555666#",//HELLO
                "8 88777444666*664#",//TUTOR
                "84426655 099966688#",   // Thank You
                "2224426622233#",         // Chance
                "5558822255999#",         // Lucky
                "7 77733 7 2 77733#",        // Prepare
                "4 666 666 3#"     // good
            };

            foreach (var input in testInputs)
            {
                Console.WriteLine($"Input: {input} => Output: {OldPhonePadDecoderApp.OldPhonePadDecoder.OldPhonePad(input)}");
            }
        }
    }
}

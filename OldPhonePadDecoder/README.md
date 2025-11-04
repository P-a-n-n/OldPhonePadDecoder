# OldPhonePad Decoder - C# .NET

## Overview
This project implements a decoder for an **old mobile phone keypad**. It converts numeric input sequences (like "4433555 555666#") into text, simulating the behavior of classic phones with multi-tap keypads.

**Features:**
- Converts numeric sequences into letters (A-Z) using multi-tap logic.
- Handles spaces (pauses) between repeated key presses.
- Supports backspace (`*`) for deleting previous characters.
- Recognizes `#` as the end of input (send button).
- Robust error handling for invalid or empty inputs.

---

## Key Mapping

| Key | Letters |
|-----|---------|
| 2   | ABC     |
| 3   | DEF     |
| 4   | GHI     |
| 5   | JKL     |
| 6   | MNO     |
| 7   | PQRS    |
| 8   | TUV     |
| 9   | WXYZ    |
| 0   | Space   |

---

## Usage

```csharp
using System;
using OldPhonePadApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(OldPhonePadDecoder.OldPhonePad("33#")); // Output: E
        Console.WriteLine(OldPhonePadDecoder.OldPhonePad("227*#")); // Output: B
        Console.WriteLine(OldPhonePadDecoder.OldPhonePad("4433555 555666#")); // Output: HELLO
        Console.WriteLine(OldPhonePadDecoder.OldPhonePad("8 88777444666*664#")); // Output: TUTOR
        Console.WriteLine(OldPhonePadDecoder.OldPhonePad("84426655 099966688#")); // Output: Thank You
        Console.WriteLine(OldPhonePadDecoder.OldPhonePad("2224426622233#")); // Output: Chance
        Console.WriteLine(OldPhonePadDecoder.OldPhonePad("5558822255999#")); // Output: lucky
        Console.WriteLine(OldPhonePadDecoder.OldPhonePad("7 77733 7 2 77733#")); // Output: Prepare
        Console.WriteLine(OldPhonePadDecoder.OldPhonePad("4 666 666 3#")); // Output: Good
    }
}

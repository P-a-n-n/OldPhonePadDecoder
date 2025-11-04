# OldPhonePad Decoder - C# .NET

## Overview
This project decodes input from an **old mobile phone keypad** into text, simulating multi-tap key presses on classic phones. It is implemented in C# as a console application.

---

## Features
- Converts numeric sequences to letters (A-Z) and spaces.
- Handles pauses (` `) between repeated key presses.
- Supports backspace (`*`) to remove previous characters.
- Recognizes `#` as the "send" key to finish input.
- Includes comprehensive test cases to demonstrate correctness.
- Clean, refactored, maintainable, and well-documented code.

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
using OldPhonePadDecoderApp;

string output = OldPhonePadDecoder.OldPhonePad("4433555 555666#");
Console.WriteLine(output); // Output: HELLO

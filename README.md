# Number Prettifier

## Overview

The **Number Prettifier** is a console application designed to convert large numbers into a more readable format. It simplifies numbers by appending **"M"** for millions, **"B"** for billions, and **"T"** for trillions suffixes. 

## Approach

The application follows a straightforward process:

1. **Input Handling:**  
   The program asks the user to enter a numeric value and then validates the input to check it is a valid number.

2. **Prettifying:**  
   Based on the length of the number, the program adds the right suffix (like "M", "B", "T") and formats the number. If the number isn’t a whole number, it shows one digit after the decimal point.

3. **Output:**  
   The program shows the shortened number on the screen and waits for the user to press a key before closing, so the user has time to see the result.

## How to Run the Prettifier

To run the Number Prettifier:

1. **Download the Executable:**  
   The executable file for the program is located in the `bin/Debug/net8.0` folder. You can find it in the project directory after building the project in Visual Studio.

2. **Run the Program:**  
   Double-click the executable file or run it from the command line. The program will open a console window where you can enter a number. After you press `Enter`, the program will show the prettified number.

3. **View the Result:**  
   The program will display the prettified number and wait for you to press a key before closing the window.

## Code Location

The source code for the Number Prettifier is located in the main project directory:

- **`Program.cs:`** This file contains the main logic for the Number Prettifier.
- **`NumberPrettifier.Tests:`** This folder contains NUnit tests to verify the functionality of the program.


## Assumptions

- The program assumes the user enters a valid number.
- It works with both whole numbers and decimal numbers but doesn’t handle negative numbers or special cases like `NaN`.

## Design Choices

- **Simple and Clear:**  
  The code is written in a clear way, using underscores in numbers to make them easy to read. The focus is on making the numbers look nice and simple.

- **User-Friendly:**  
  The program uses a `Console.ReadKey()` command to keep the window open after showing the result, so the user can see the output before the program closes.

## Testing

- **Manual Testing:**  
  Users can run the program, enter different numbers, and check the results on the screen.

- **Automated Testing:**  
  The program can be tested automatically using NUnit to make sure the prettifying process works correctly in different cases.

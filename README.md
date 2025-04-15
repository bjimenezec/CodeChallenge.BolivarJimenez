# Old Phone Keypad Emulator

![Application Screenshot](https://github.com/bjimenezec/CodeChallenge.BolivarJimenez/blob/main/Screenshot.png)

## Coding Challenge - Bolivar Jimenez

## Overview

The **Old Phone Keypad Emulator** is a Windows Forms application designed to replicate the classic mobile phone keypad for text input. It simulates the multi-tap input method used on older phones, converting keypress sequences into text based on the traditional rules.


## Main Features

-   **Multi-Tap Input**: Implements the classic multi-tap input method, allowing users to cycle through characters associated with each numeric key.
    
-   **Pause Detection**: The space key simulates a time delay, providing a brief pause to allow for the input of new characters.

## Usage

Each key on the alphanumeric keypad corresponds to one or more letters. For instance, pressing the **2** key cycles through the letters **A**, **B**, and **C** in that order. Here’s how it works:

-   **2** → A
    
-   **22** → B
    
-   **222** → C    

When you press a key multiple times, the number of presses determines which letter is selected.

The **0** key represents the space bar. Pressing it simulates a pause of more than one second, signaling that you’re ready to type a new letter or group of letters. For example:

-   **2 _ 22** → AB  
    (_Here, the underscore _ represents the pause between key presses, so "2" becomes "A" and "22" becomes "B_.*)    

The * key acts as a backspace. It deletes the last entered character, so:

-   **22*** → 2 → B  
    (_Here, "22" originally entered "B", but after pressing *, the "B" is deleted, leaving just "B" as the final input._)

Finally, the **#** key submits the entered sequence for processing.

**Important Note**: This application simulates the manual key-by-key typing process of an old-fashioned mobile phone. It does _not_ support the direct input of pre-built character strings like "22 2 222". Each key press must be done sequentially.

## How to Run

1.- **Clone the Repository**
  
   

    git clone https://github.com/bjimenezec/CodeChallenge.BolivarJimenez
    cd CodeChallenge.BolivarJimenez 

2.- **Open, build and run the application**

Using Visual Studio /VS Code, open *Challenge.BolivarJimenez.sln*

 
Build  and Run

## Solution 

![Solution structure](https://github.com/bjimenezec/CodeChallenge.BolivarJimenez/blob/main/solution_estructure.png)   


## Unit Tests
The solution includes a unit testing project built with NUnit version 3, for Visual Studio.
# V-ENCRYPT

This program converts a phrase into a cipher text based off of a key given

The program is written in C# and could be run using both the .dll file or compiled from the program.cs file

## ARGULEMTS

The program takes in 3 arguments
    - process type
    - phrase
    - keyword

    ### PROCESS-TYPE
    The process type can be either "encrypt" or "decrypt", anything other than that would raise an error

    ### PHRASE
    The phrase is the phrase to either be encrypted or decrypted, and should be all in CAPS

    ### KEYWORD
    The keyword is what would be used to make a key that would be used to encrypt or decrypt the phrase
    

## RUN EXAMPLE

DOTNET can be used to run the Program.cs file as so
- dotnet run encrypt JOE AYU

    i. the process type being "encrypt"
    ii. the phrase being "JOE"
    iii. the keyword being "AYU"

DOTNET can also be used to run the .dll file as so
- dotnet VENCRYPT.dll encrypt JOE AYU


The program could be compiled into a .exe file and run directly as so
- csc Program.cs
- Program.exe
using System;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            // get all the parameters from the cli
            string type = args[0];
            string phrase = args[1];
            string keyword = args[2];

            // get the key by generating it 
            string key = generateKey(phrase, keyword);

            // perform either encryption or decryption
            if (type == "encrypt") Console.WriteLine(encrypt(phrase, key));
            if (type == "decrypt") Console.WriteLine(decrypt(phrase, key));
        }
        catch (Exception error)
        {
            // catch any error that would occur
            Console.WriteLine("Error occured: Check the arguments or " + error.Message);
        }
    }

    static string generateKey(string phrase, string keyword)
    {
        // check if the length of the keyword matches the pass phrase and return if true
        if (keyword.Length == phrase.Length) return keyword;

        string key = keyword;

        int watch = phrase.Length - keyword.Length;

        // keep repeating the process of adding the next character to the new key
        for (int i = 0; i < watch; i++) key += (key[i]);

        return key;
    }

    static string encrypt(string phrase, string key)
    {
        string cipher_text = "";

        for (int i = 0; i < phrase.Length; i++)
        {
            // using the formula Ei = (Pi + Ki) mod 26 to get the position of the character in the ASCII chart
            int position = (phrase[i] + key[i]) % 26;

            // convert it to character
            position += 'A';

            cipher_text += (char)(position);
        }

        return cipher_text;
    }

    static string decrypt(string phrase, string key)
    {
        string response = "";

        for (int i = 0; i < phrase.Length && i < key.Length; i++)
        {
            int position = (phrase[i] - key[i] + 26) % 26;

            position += 'A';

            response += (char)(position);
        }

        return response;

    }
}

// note that both keyword and phrase must be in capital for this program to work. Haven't figured it out yet
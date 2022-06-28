
bool runProgram = true;
while (runProgram == true)
{
    Console.WriteLine("Enter a word");
    string userInput = Console.ReadLine();
    string word = MakeLower(userInput);

    ConvertWord(ref word);
    Console.WriteLine(word);
    Console.WriteLine("Translate another line? y/n");
    string response = Console.ReadLine();

    if(response == "y")
    {
        runProgram = true;
    } 
    else
    {
        Console.WriteLine("Goodbye!");
        runProgram =false;
    }
}


static string MakeLower(string word)
{
    return word.ToLower();
}

static string MoveFirstLetter(string word)
{
    string modified;
    modified = word.Substring(1, word.Length - 1) + word.Substring(0, 1);
    return modified;
}

static void ConvertWord( ref string word)
{
    char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u'};
    if (vowels.Contains(word[0]))
    {
        foreach (char vowel in vowels)
        {
            if (word.StartsWith(vowel) == true)
            {
                word = word + "way";
            }
        }
    } 
    else
    { 
        for(int i = 0; i < word.Length; i++)
        {
            if (vowels.Contains(word[i]))
            {
                word = word.Substring(i) + word.Substring(0, i) + "ay";
                break;
            }
        }
    } 
}
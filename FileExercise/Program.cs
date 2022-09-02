/*1- Write a program that reads a text file and 
displays the number of words.
var path=@"C:\Users\Lilith\Desktop\C# Course\FileExercise\TextFile.txt";
var text=File.ReadAllText(path);

var numberOfWords=text.Split(" ");

System.Console.WriteLine("Number of words: "+numberOfWords.Length);
*/
/*2- Write a program that reads a text file and 
displays the longest word in the file. */

var path = @"C:\Users\Lilith\Desktop\C# Course\FileExercise\TextFile.txt";
var text = File.ReadAllText(path);
var newText = text.Trim('.');
var withoutComma = newText.Replace(",", "");



var words = withoutComma.Split(" ");


foreach (var w in words)
{
    System.Console.WriteLine(w);

}

string longestWord = "";
int wordlength = 0;

foreach (var word in words)
{
    if (word.Length > wordlength)
    {
        longestWord = word;
        wordlength = word.Length;
    }
}

System.Console.WriteLine("Longest word in text: " + longestWord);



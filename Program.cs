

using System.Text;

static string AppendString(string wordArg, int numArg)
{
    StringBuilder sb = new StringBuilder();

    for(int i = 0; i < numArg; i++)
    {
        sb.Append(wordArg);
    }
    return sb.ToString();
};


static string RemoveChars(string wordArg, int numArg)
{
    return wordArg.Substring(0, wordArg.Length - numArg);
}

StringDel newDel = new StringDel(RemoveChars);

Console.WriteLine(newDel("mynewstring", 4));
newDel = PrintWord;
Console.WriteLine(newDel("cat", 3));

public delegate string StringDel(string wordArg, int numArg);


using System.Text;

StringBuilder sb = new StringBuilder();

Console.Write("Digite um palavra: ");

string word = Console.ReadLine();

foreach (char c in word)
{
    sb.Append((char)((c * c) % 255));
}

Console.WriteLine(sb.ToString());

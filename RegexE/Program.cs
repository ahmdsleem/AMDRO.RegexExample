using System.Text.RegularExpressions;

string pattern = @"\d";
Regex regul = new Regex(pattern);

string texts = "Hi there, my number is 1234";
MatchCollection matchCollect = regul.Matches(texts);

Console.WriteLine("{0} hits found:\n {1}", matchCollect.Count, texts);

foreach (Match mt in matchCollect)
{
    GroupCollection group = mt.Groups;
    Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
}
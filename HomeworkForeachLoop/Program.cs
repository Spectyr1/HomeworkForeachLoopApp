

List<string> firstNames = new();
bool done = false;

Console.Write("Please enter your first name: ");

firstNames.Add(Console.ReadLine());

do
{
    Console.WriteLine("Please enter another name. Enter a BLANK to finish: ");
    string text = Console.ReadLine();

    if (text != "")
    firstNames.Add(text);
    else
        done = true;

} while (done != true);


foreach (var name in firstNames)
{
    Console.WriteLine($"Hello {name}");
}
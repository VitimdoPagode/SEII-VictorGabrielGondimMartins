//enum
Console.WriteLine((int)Warning.CodeYellow);

var status = Warning.CodeYellow;

if(status == Warning.CodeYellow)
{
    Console.WriteLine("CODE YELLOW!!!!1");
}
enum Warning
{
    codeRed,
    CodeBlue,
    CodeYellow
}
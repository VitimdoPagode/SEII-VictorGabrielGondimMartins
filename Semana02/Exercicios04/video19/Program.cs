using System.Security.Cryptography.X509Certificates;

Action loggerAction = () =>
{
    System.Console.WriteLine("simple");
};

SuperCustom loggerFunc = (int x) =>
{
    return x + 2;
};

var list = Enumerable.Range(1,10).Select(i => i*3).ToList();

var callcall = (Action func) => 
{
    func();
};

callcall(loggerAction);

public delegate int SuperCustom(int x);

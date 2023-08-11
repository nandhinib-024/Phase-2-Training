// See https://aka.ms/new-console-template for more information
using ExceptionHandling;

//Console.WriteLine("Hello, World!");

ExceptionClass exceptionClass =new ExceptionClass(10,0,0,2);
Console.WriteLine(exceptionClass.Add());
try
{
    Console.WriteLine(exceptionClass.Div());
    exceptionClass.Checkgae();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


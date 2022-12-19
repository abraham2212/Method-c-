



using method;


Calculate();
static void Calculate()
{
    Calculator Calculator = new Calculator();

    Console.WriteLine("add first number :");

  Number1: string number1 = Console.ReadLine();
    int checkedNum1;
    bool isParseNum1 =int.TryParse (number1, out checkedNum1);

    if (!isParseNum1)
    {

        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("please add correct format number one ");
        Console.ResetColor();
        goto Number1;
   
    }

    Console.WriteLine("add operation :");
    string operation = Console.ReadLine();

    Console.WriteLine("add second number:");

Number2: string number2 = Console.ReadLine();
    int checkedNum2;
    bool isParseNum2=int.TryParse (number2, out checkedNum2);

    if (!isParseNum2)
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("please add correct format number two");
        Console.ResetColor();
        goto Number2;

    }

    if (checkedNum1==0 && operation == "/")
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("please dont add ");
        goto Number2;

    }

    var result = Calculator.Calculation(checkedNum1, checkedNum2, operation);

    Console.ForegroundColor= ConsoleColor.Blue;
    Console.WriteLine(result);
    Console.ResetColor();

}




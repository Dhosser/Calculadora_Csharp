internal class Program
{
    private static void Main(string[] args)
    {

        double first;
        double second;
        

        Console.WriteLine("Primer numero:");
        first = double.Parse(Console.ReadLine());

        Console.WriteLine("Segundo numero:");
        second = double.Parse(Console.ReadLine());

        Console.WriteLine("Elige la operacion (+, -, *, /):");
        string operation = (Console.ReadLine());

        double result;

        switch (operation)
        {
            case "+":
                result = first + second;
                Console.WriteLine("{0} + {1} = {2}", first, second, result);
            
                break;
                case "-":
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);

                    break;
                    case "*":
                        result = first * second;
                        Console.WriteLine("{0} * {1} = {2}", first, second, result);

                        break;
                        case "/":
                            result = first / second;
                            Console.WriteLine("{0} / {1} = {2}", first, second, result);

                            break;
            default:
                Console.WriteLine("operacion invalida.");
                break;
        }
    }
}
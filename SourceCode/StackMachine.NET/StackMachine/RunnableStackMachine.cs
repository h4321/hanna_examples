using System;

namespace StackMachine
{
    public class RunnableStackMachine
    {
        public static StackList _stackList;

        private static bool _isLifoStackChosen;
        public bool IsLifoStackChosen
        {
            get { return _isLifoStackChosen; }
        }

        static void Main(string[] args)
        {
            Initialize();
            Run();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void Run()
        {
            bool firstRun = true;
            while (true)
            {
                if (firstRun)
                {
                    Console.WriteLine("Welcome to Stack Machine. Type 'help' or '?' to access information about using this tool.");
                    firstRun = false;
                }
                Console.Write("> ");
                string input = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("> " + input);
                string command = input.Split(" ")[0];
                string argument;
                switch (command)
                {
                    case "?":
                    case "help":
                        Help();
                        break;
                    case "chmode":
                        if (CheckForSecondaryArgument(input, out argument))
                        {
                            ChangeStackModel(argument);
                        }
                        break;
                    case "push":
                        if (CheckForSecondaryArgument(input, out argument))
                        {
                            _stackList.push(argument);
                        }
                        break;
                    case "pop":
                        _stackList.pop();
                        break;
                    case "add":
                        _stackList.add();
                        break;
                    case "sub":
                        _stackList.subtract();
                        break;
                    case "mlt:":
                        _stackList.multiply();
                        break;
                    case "div":
                        _stackList.divide();
                        break;
                    case "q":
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid command provided. Please try again with correct command.");
                        break;
                }
                Console.WriteLine();
            }
        }

        private static bool CheckForSecondaryArgument(string input, out string argument)
        {
            var split = input.Split(" ");
            if (split.Length > 1) 
            {
                argument = split[1];
                return true;
            }
            argument = string.Empty;
            Console.WriteLine("No argument provided for this command. Please retry this command with valid argument.");
            return false;
        }

        private static void Initialize()
        {
            _stackList = new StackList();
            _isLifoStackChosen = true;
        }

        static void Help()
        {
            Console.WriteLine("Enter command (with an argument where required) after command prompt character. List of available commands:" + Environment.NewLine);
            Console.WriteLine("help (or ?) - Displays this help");
            Console.WriteLine("chmode - Change Stack Machine Model (required arguments: lifo or fifo)");
            Console.WriteLine("push - Puts value to stack (required argument: integer value)");
            Console.WriteLine("pop - Removes value from stack (depending on model)");
            Console.WriteLine("add - Add two values (depending on model) and put on top of stack");
            Console.WriteLine("sub - Substract two values (depending on model) and put on top of stack");
            Console.WriteLine("mlt - Multiply two values (depending on model) and put on top of stack");
            Console.WriteLine("div - Divide two values (depending on model) and put on top of stack ");
            Console.WriteLine("exit (or q) - Exits program");

        }

        static void ChangeStackModel(string input) 
        {
            if (input.Equals("lifo", StringComparison.InvariantCultureIgnoreCase))
            {
                _isLifoStackChosen = true;
                Console.WriteLine("LIFO Stack Model has been enabled.");
                //BUG: in fact there is no action upon changing model so it will not change.
            }
            else if (input.Equals("fifo", StringComparison.InvariantCultureIgnoreCase))
            {
                _isLifoStackChosen = false;
                Console.WriteLine("FIFO Stack Model has been enabled.");
                //BUG: in fact there is no action upon changing model so it will not change.
            }
            else
            {
                Console.WriteLine("Invalid Stack Model chosen.");
            }
        }
    }
}

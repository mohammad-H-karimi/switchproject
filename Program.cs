
// MOHAMMAD HOSSEIN KARIMI

string input;

//string answer;

Console.WriteLine("DO YOU HAVE MARIED ?");

locker();


switch (input)
{
    case "y" or "Y":

        Console.WriteLine("DO YOU HAVE A CHILD ?");
        locker();

        if (input == "y")
            Console.WriteLine("DO YOU HAVE A SON ?");

        if (input == "n")
            Console.WriteLine("DO YOU WANT TO HAVE SON ?");

        locker();

        if (input == "y")
            Console.WriteLine("DO YOU HAVE A DAUGHTER ?");

        if (input == "n")
            Console.WriteLine("DO YOU WANT TO HAVE A DAUGHTER ?");

        locker();

        if (input == "y" || input == "n")
            Console.WriteLine("ARE YOU SATISFIED WITH YOUR LIFE ?");

        locker();

        if (input == "y" || input == "n")
            Console.WriteLine("THANK YOU FOR PARTICIPATING IN THE SURVEY");


        break;

    case "n" or "N":
        Console.WriteLine("DO YOU WANT TO MARIED?");
        locker();

        if (input == "y")
            Console.WriteLine("DO YOU WANT TO HAVE CHILDREN ?");

        if (input == "n")
            Console.WriteLine("DO WANT TO ADOPT A CHILD ?");

        locker();

        if (input == "y")
            Console.WriteLine("DO YOU WANT A SON ?");

        locker();

        if (input == "y")
            Console.WriteLine(" DO YOU WANT A DAUGHTER ?");

        locker();

        if (input == "y" || input == "n")
            Console.WriteLine("THANK YOU FOR PARTICIPATING IN THE SURVEY");

        break;
  
}







//.............................................METHOD.......................................................

bool locker()
{  
        do
        {
        input = Console.ReadKey(true).KeyChar.ToString();


        } while (input.ToLower() != "y" & input.ToLower() != "n");
        return true;
}
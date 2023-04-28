using mis_221_pa_5_gmstevens02;

//Priming read
int userChoice = GetUserChoice();
while (userChoice!=5)
{
    RouteIt(userChoice);
    userChoice = GetUserChoice();
} 

//GetMenuChoice
static int GetUserChoice()
{
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if (IsValidChoice(userChoice))
    {
        return int.Parse(userChoice);
    }
    else return 0;
}

//DisplayMenu
static void DisplayMenu()
{
    Console.Clear();
    string menuArt = @"
 _______  ______    _______  ___   __    _    ___      ___   ___   _  _______    _______    _______  __   __  _______  __   __  _______  ___   _______  __    _ 
|       ||    _ |  |   _   ||   | |  |  | |  |   |    |   | |   | | ||       |  |   _   |  |       ||  | |  ||   _   ||  |_|  ||       ||   | |       ||  |  | |
|_     _||   | ||  |  |_|  ||   | |   |_| |  |   |    |   | |   |_| ||    ___|  |  |_|  |  |       ||  |_|  ||  |_|  ||       ||    _  ||   | |   _   ||   |_| |
  |   |  |   |_||_ |       ||   | |       |  |   |    |   | |      _||   |___   |       |  |       ||       ||       ||       ||   |_| ||   | |  | |  ||       |
  |   |  |    __  ||       ||   | |  _    |  |   |___ |   | |     |_ |    ___|  |       |  |      _||       ||       ||       ||    ___||   | |  |_|  ||  _    |
  |   |  |   |  | ||   _   ||   | | | |   |  |       ||   | |    _  ||   |___   |   _   |  |     |_ |   _   ||   _   || ||_|| ||   |    |   | |       || | |   |
  |___|  |___|  |_||__| |__||___| |_|  |__|  |_______||___| |___| |_||_______|  |__| |__|  |_______||__| |__||__| |__||_|   |_||___|    |___| |_______||_|  |__|
";
    System.Console.WriteLine(menuArt);
    System.Console.WriteLine("1) Manage Trainer Data\n2) Manage Listing Data\n3) Manage Customer Booking Data\n4) Run Reports\n5) Exit");
}

//IsValidChoice
static bool IsValidChoice(string userInput)
{
    if(userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4" || userInput == "5"){
        return true;
    }
    return false;

}

//RouteIt
static void RouteIt(int menuChoice)
{
    if(menuChoice==1){
        Console.Clear();//Same as the readkey
        System.Console.Write("boop"); //change later
    }
    else if (menuChoice==2){
        Console.Clear();
        System.Console.WriteLine("hello");
    }
    else if (menuChoice==3){
        Console.Clear();
        System.Console.WriteLine("whoop");
    }
    else if (menuChoice==4){
        Console.Clear();
        System.Console.WriteLine("sweep");
    }
    else if (menuChoice!=5){
        SayInvalid();
    }
    Console.ReadKey();//put in the menu area later, not here
}

//SayInvalid
static void SayInvalid()
 {
     System.Console.WriteLine("Invalid, try another input");
     PauseAction();
}

//PauseAction
static void PauseAction()
{
    System.Console.WriteLine(" Press any key to continue:");
    Console.ReadKey();
}
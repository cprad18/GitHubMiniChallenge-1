// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Christopher Prado
//09-07-2022 2pm
//Mini Challenge #1 "What is your name?"
//This is a console project that will ask our user their name
//And report it back to the console
//Peer Review by: (enter name)

//need a boolean & while loop 

Console.Clear ();

string playAgain = "yes";

while(playAgain == "yes"){

Console.WriteLine ("What is your name?");

string myName = Console.ReadLine();

Console.WriteLine ("Good Afternoon" + myName);

Console.WriteLine ("What time did you wake up?");

string myWakeTime = Console.ReadLine();

Console.WriteLine ("Awesome " +  myName + " you woke up at " + myWakeTime);

Console.WriteLine("Would you like to play again ? by telling me your name?")
}


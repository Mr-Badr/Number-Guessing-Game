
Random random = new Random();

bool playAgain = true;  
int guess;
int min = 0;
int max = 100;
int number;
int guesses;
string response;

while (playAgain)
{
    guess = 0;
    guesses = 0;
    number = random.Next(min,max +1);
    response = "";

    while ( guess != number)
    {
        Console.WriteLine("Give a Number Between " + min +" and  "+ max +" : ");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Guess :"+ guess);

        if (guess > number)
        {
            Console.WriteLine( guess +" is to high!");
        }
        else
        {
            Console.WriteLine(guess + " is to low!");
        }
        guesses++;
    }

    Console.WriteLine("Number : " + number);
    Console.WriteLine(" ☻☻☻☻☻ Win! ☻☻☻☻☻");
    Console.WriteLine("Guesses : " + guesses);

    Console.WriteLine("play again ? (Y/N) ");
    response =  Console.ReadLine();
    response = response.ToUpper();

    if ( response == "Y")
    {
        playAgain = true;
    } else
    {
        playAgain = false;
    }

}

Console.WriteLine("Thanks for Playing !");
Console.ReadKey();
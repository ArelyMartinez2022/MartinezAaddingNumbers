/* See https://aka.ms/new-console-template for more information
ARELY MARTINEZ
OCT 18 1:46 PM
THIS PROGRAM WILL ASK THE USER FOR 2 NUMBERS 
ONCE THE USER ENTERS A VAILD 1ST NUMBER IT 
WILL DO THE SAME FOR THE 2ND NUMBER. IF THE 
USER HAPPENS TO TYPE A INAVILD RESPONSE FOR 
EITHER THEY WILL HAVE TO REPLAY UNTIL ITS VAILD.
THE PROGRAM WILL THEN ADD THE TWO NUMBERS AND 
DISPLAY THE ANSWER ON THE TERMIAL 

PEER REVIEW: NAME -- REVIEW

*/
Console.Clear();
bool playAgain = true;
while(playAgain){

    Console.WriteLine("LETS ADD TWO NUMBERS ");
    Console.WriteLine(" ");

    string userInput;
    string userInput2;

    bool convetOne = true;
    bool isNumber; 
    long num1 = 0;
        
    while (convetOne){
        Console.WriteLine("Enter ur 1st whole number: ");
        userInput = Console.ReadLine();

        isNumber = Int64.TryParse(userInput, out num1);

        if(isNumber == true) {
            convetOne = false;
            Console.WriteLine("You Entered A Number ");
            Console.WriteLine( " " );
        } else {
            Console.WriteLine( " " );
            Console.WriteLine("Invaild entry, please try again ");
            Console.WriteLine( " " );
        }
    }

    bool convertTwo = true;
    bool isNumber2; 
    long num2 = 0;
        
    while (convertTwo){
        Console.WriteLine("Enter ur 2nd whole number: ");
        userInput2 = Console.ReadLine();

        isNumber2 = Int64.TryParse(userInput2, out num2);

        if(isNumber2 == true) {
            convertTwo = false;
            Console.WriteLine("You Entered A Number ");
            Console.WriteLine( " " );
        } else {
            Console.WriteLine( " " );
            Console.WriteLine("Invaild entry, please try again ");
            Console.WriteLine( " " );
        }
    }

    long ansswer  = num1 + num2;

    Console.WriteLine( num1 + " + " + num2 + " = " + ansswer );


    bool converted = true;
    while (converted){
        Console.WriteLine("Would you like to play again? Yes or No");
        string rePlay = Console.ReadLine();

        if(rePlay == "YES" || rePlay == "Yes" || rePlay == "yes"){
            playAgain = true;
            converted = false;
            Console.Clear();
            Console.WriteLine( "LETS PLAY AGAIN!!" );
            Console.WriteLine( " " );
            break;
        } 
        if(rePlay == "NO" || rePlay == "no"){
            playAgain = false;
            converted = false;
            Console.WriteLine(" ");
            Console.WriteLine( "THANK YOU FOR PLAYING!!! " );
            break;
        }
        else{
            converted = true;
            Console.WriteLine(" ");
            Console.WriteLine( "INVAILD RESPONSE TRY AGAIN!!" );
            Console.WriteLine(" ");
        }
    } 
}


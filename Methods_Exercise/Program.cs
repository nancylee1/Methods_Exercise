// Ask the user “What is your name?”
// Store the input

Console.WriteLine("What is your name?"); // output
var name = Console.ReadLine(); // input

// Record user input, for each of these. Combine all answers for a fun, short story.
//EXAMPLES:

//Name: Michael

//Favorite Color: Blue

//Favorite Animal: Walrus

//Favorite Band: The Beatles

//Extra points - turn the answers into a fun short story!
//Save, commit, and push to Github

Console.WriteLine("What is your favorite color?"); 
var color = Console.ReadLine();

Console.WriteLine("What is your favorite animal?");
var animal = Console.ReadLine();

Console.WriteLine("What is your favorite band?");
var band = Console.ReadLine();


Console.WriteLine($"Hello, my name is {name} and my favorite animal is a {animal}. I want to dye my {animal} {color} and play {band} on the Sonos all day."); 
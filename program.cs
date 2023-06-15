// C# Quiz Assignment
Console.Clear();
#nullable disable

// Declare score variable
float score = 0;

// Question 1
Console.WriteLine("How many players are there on each team in cricket?\n");
string answer1 = Console.ReadLine().ToLower();
if (answer1 == "eleven" || answer1 == "11") {
    score++;
    Console.WriteLine("\nCorrect!\n");
} else {
    Console.WriteLine("\nIncorrect. The correct answer was 11.\n");
}

// Question 2
Console.WriteLine("How many sets of wickets are there on a cricket pitch?\n");
string answer2 = Console.ReadLine().ToLower();
if (answer2 == "two" || answer2 == "2") {
    score++;
    Console.WriteLine("\nCorrect!\n");
} else {
    Console.WriteLine("\nIncorrect. The correct answer was 2\n");
}

// Question 3
Console.WriteLine("What is the highest amount of runs that can be scored off a single delivery?\n");
string answer3 = Console.ReadLine().ToLower();
if (answer3 == "6" || answer3 == "six") {
    score++;
    Console.WriteLine("\nCorrect!\n");
} else {
    Console.WriteLine("\nIncorrect. The correct answer was 6.\n");
}

// Question 4
Console.WriteLine("What is the longest time a Cricket game can last?\n");
string answer4 = Console.ReadLine().ToLower();
if (answer4 == "5 days" || answer4 == "5days" || answer4 == "five days") {
    score++;
    Console.WriteLine("\nCorrect!\n");
} else {
    Console.WriteLine("\nIncorrect. The correct answer was 5 days.\n");
}

// Question 5
Console.WriteLine("Which nation won the last Cricket World Cup?\n");
string answer5 = Console.ReadLine().ToLower();
if (answer5 == "england") {
    score++;
    Console.WriteLine("\nCorrect!\n");
} else {
    Console.WriteLine("\nIncorrect. The correct answer was England.\n");
}

// Score Output
float percentage = score / 5 * 100;

Console.WriteLine($"Your final score was {score} / 5. {percentage}%\n");

// Feedback based on score
if (score <= 2) {
    Console.WriteLine("You need to learn more about Cricket!");
} else if (score < 5) {
    Console.WriteLine("good Job!");
} else {
    Console.WriteLine("Excellent Job!");
}
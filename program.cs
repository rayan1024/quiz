// C# Quiz Assignment
Console.Clear();
#nullable disable

// Declare score variable
float score = 0;

// Question 1
Console.WriteLine("How many players on the basketaball team?\n");
string answer1 = Console.ReadLine().ToLower();
if (answer1 == "five" || answer1 == "5") {
    score++;
    Console.WriteLine("\nCorrect!\n");
} else {
    Console.WriteLine("\nIncorrect. The correct answer was 11.\n");
}

// Question 2
Console.WriteLine("How many teams are on the court?\n");
string answer2 = Console.ReadLine().ToLower();
if (answer2 == "two" || answer2 == "2") {
    score++;
    Console.WriteLine("\nCorrect!\n");
} else {
    Console.WriteLine("\nIncorrect. The correct answer was 2\n");
}

// Question 3
Console.WriteLine("how many rings does mj have?\n");
string answer3 = Console.ReadLine().ToLower();
if (answer3 == "6" || answer3 == "six") {
    score++;
    Console.WriteLine("\nCorrect!\n");
} else {
    Console.WriteLine("\nIncorrect. The correct answer was 6.\n");
}

// Question 4
Console.WriteLine("What is the longest time a basketball game can last?\n");
string answer4 = Console.ReadLine().ToLower();
if (answer4 == "2 hours" || answer4 == "2hours" || answer4 == "two hours") {
    score++;
    Console.WriteLine("\nCorrect!\n");
} else {
    Console.WriteLine("\nIncorrect. The correct answer was 5 days.\n");
}

// Question 5
Console.WriteLine("Which basketball team on this year?\n");
string answer5 = Console.ReadLine().ToLower();
if (answer5 == "nuggets") {
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
// See https://aka.ms/new-console-template for more information
string question1 = "what is the capital of germany";
string answer1 = "Germany";

string question2 = "what is 2+2";
string amswer2 = "4";

string question3 = "what is the color that mix blue and yellow";
string answer3 = "green";

int score = 0;
Console.WriteLine(question1);
string userAnswer=Console.ReadLine();
if(userAnswer ==answer1)
{
    Console.WriteLine("correct"+answer1);
    score = score+1;
}
else
{
    Console.WriteLine("wrong answer"+answer1);
}
Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2 == amswer2)
{
    Console.WriteLine("correct" + amswer2);
    score = score + 1;
}
else
{
    Console.WriteLine("wrong answer" + amswer2);
}
Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3 == answer3)
{
    Console.WriteLine("correct" + answer3);
    score = score + 1;
}
else
{
    Console.WriteLine("wrong answer" + answer3);
}

Console.WriteLine($"the final score is {score}/3");

if (score == 0)
{
    Console.WriteLine("better luck next time");
}
else if (score >0)
{
    Console.WriteLine("good job keep learning ");
}
else if (score==3)
{
    Console.WriteLine("all answer are good ");
}
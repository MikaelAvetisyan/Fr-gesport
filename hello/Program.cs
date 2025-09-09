using System.Runtime.CompilerServices;
using System.Security.AccessControl;

Console.WriteLine("Hello fellow challanger, are you ready to take this test, if you are so could you write your name");
String begin;
begin = Console.ReadLine();

{
    Console.WriteLine($"So {begin}, lets begin");
        Console.WriteLine("Question nr.1");
            Console.WriteLine("Which city is home to the Brandenburg Gate?");
            Console.WriteLine("A, Vienna");
            Console.WriteLine("B, Zurich");
            Console.WriteLine("C, Berlin");
            Console.WriteLine("Or none of them, if none, write none");
}
    String AnswerCity;
    AnswerCity = Console.ReadLine().Trim().ToUpper();
    int point = 0;

{
    if (AnswerCity == "C")
    {
        point += 1; //behövde lite hjälp här
        Console.WriteLine($"Correct, you get 1 point, total points: {point}/6, press enter to continue");
    }

    else if (AnswerCity == "A")
    {
        Console.WriteLine("Wrong answer, its C = Berlin, no points, press enter to continue");
    }

    else if (AnswerCity == "B")
    {
        Console.WriteLine("Wrong answer, its C = Berlin, no points, press enter to continue");
    }

    else if (AnswerCity == "NONE")
    {
        Console.WriteLine("Wrong answer, its C = Berlin, no points, press enter to continue");
    }

    else
    {
        Console.WriteLine("That is not an option so its wrong, press enter to continue");
    }
    Console.ReadLine();
}

        Console.WriteLine("Question nr.2");
            Console.WriteLine("Which of the following is NOT a fruit?");
                Console.WriteLine("A, Rhubarb");
                Console.WriteLine("B, Tomatoes");
                Console.WriteLine("C, Avocados");
                Console.WriteLine("None of them");

string answerfruit;
answerfruit = Console.ReadLine().Trim().ToUpper();

if (answerfruit == "A")
{
    point += 1;
    Console.WriteLine($"Correct, you get 1 point, total points: {point}/6, press enter to continue");
}

else if (answerfruit == "B")
{
    Console.WriteLine("Wrong answer, its A = Rhubarb, no points, press enter to continue");
}

else if (answerfruit == "C")
{
    Console.WriteLine("Wrong answer, its A = Rhubarb, no points, press enter to continue");
}

else if (answerfruit == "NONE")
{
    Console.WriteLine("Wrong answer, its A = Rhubarb, no points, press enter to continue");

}

else
{
    Console.WriteLine("That is not an option so its wrong, press enter to continue");
}
    Console.ReadLine();

    Console.WriteLine("Question nr.3");
        Console.WriteLine("What number was the Apollo mission that successfully put a man on the moon for the first time in human history? ");
            Console.WriteLine("A, Apollo 12");
            Console.WriteLine("B, Apollo 13");
            Console.WriteLine("C, Apollo 14");
            Console.WriteLine("None of them");

string answerApollo;
answerApollo = Console.ReadLine().Trim().ToUpper();

    if (answerApollo == "NONE")
    {
        point += 1; 
        Console.WriteLine($"Correct, you get 1 point, total points: {point}/6, press enter to continue");
    }

    else if (answerApollo == "B")
    {
        Console.WriteLine("Wrong answer, its none of them, no points, press enter to continue");
    }

    else if (answerApollo == "C")
    {
        Console.WriteLine("Wrong answer, its none of them, no points, press enter to continue");
    }

    else if (answerApollo == "A")
    {
        Console.WriteLine("Wrong answer, its none of them, no points, press enter to continue");
    }

    else
    {
        Console.WriteLine("That is not an option so its wrong, press enter to continue");
    }
    Console.ReadLine();

Console.WriteLine("Question nr.4, dubble points");
Console.WriteLine("Which of the following languages has the longest alphabet? Which of the following languages has the longest alphabet?");
Console.WriteLine("A, Greek");
Console.WriteLine("B, Arabic");
Console.WriteLine("C, Russian");
Console.WriteLine("None of them");

string answerLang;
answerLang = Console.ReadLine().Trim().ToUpper();

if (answerLang == "C")
{
    point += 2;
    Console.WriteLine($"Correct, you get 2 point, total points: {point}/6, press enter to continue");
}

else if (answerLang == "B")
{
    Console.WriteLine("Wrong answer, Its C = Russian, no points, press enter to continue");
}

else if (answerLang == "NONE")
{
    Console.WriteLine("Wrong answer, Its C = Russian, no points, press enter to continue");
}

else if (answerLang == "A")
{
    Console.WriteLine("Wrong answer, Its C = Russian, no points, press enter to continue");
}

else
    {
        Console.WriteLine("That is not an option so its wrong, press enter to continue");
    }
Console.ReadLine();

Console.WriteLine("Question nr.5");
    Console.WriteLine("Which app has the most total users?");
        Console.WriteLine("A, TikTok");
        Console.WriteLine("B, Snapchat");
        Console.WriteLine("C, Instagram");
        Console.WriteLine("None of them");

string answerUser;
answerUser = Console.ReadLine().Trim().ToUpper();

if (answerUser == "C")
{
    point += 1;
    Console.WriteLine($"Correct, you get 1 point, total points: {point}/5, press enter to continue");
}

else if (answerUser == "B")
{
    Console.WriteLine("Wrong answer, its C = Instagram, no points, press enter to continue");
}

else if (answerUser == "NONE")
{
    Console.WriteLine("Wrong answer, its C = Instagram, no points, press enter to continue");
}

else if (answerUser == "A")
{
    Console.WriteLine("Wrong answer, its C = Instagram, no points, press enter to continue");
}

else
    {
        Console.WriteLine("That is not an option so its wrong, press enter to continue");
    }
Console.ReadLine();

Console.WriteLine($"You did it, you did all the questions, so here are your scores: {point}/6");
Console.ReadLine();
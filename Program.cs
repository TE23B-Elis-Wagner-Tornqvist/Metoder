// Titel("Kapitel 1");
// Intro();
// int t = GivNum();
// Console.WriteLine(t);
// Console.ReadLine();

// static int GivNum()
// {
//     int result = Random.Shared.Next(10) + Random.Shared.Next(10);
//     return result;
// }

// static void Titel(string text)
// {
//     Console.WriteLine("================================================================================");
//     Console.WriteLine("--------------------------------------------------------------------------------");
//     Console.WriteLine(text);
//     Console.WriteLine("--------------------------------------------------------------------------------");
// }

// static void Intro()
// {
//     Console.WriteLine("Det var en gång för länge sedan...");
// 



//METOD#1

// Window();
// Console.ReadLine();


// static void Window()
// {
//     Console.WriteLine(@"

//       .----------------.
//    |          _       |
//    |      _.-'|'-._   |
//    | .__.|    |    |  |
//    |     |_.-'|'-._|  |
//    | '--'|    |    |  |
//    | '--'|_.-'`'-._|  |
//    | '--'          `  |
//     '----------------'




//     ");
// }


//METOD#2

// int startValue;
// Console.WriteLine("Hur lång countdown ska du ha?");
// string answer = Console.ReadLine() ?? string.Empty;
// int.TryParse(answer, out startValue);


// StartCountdown(startValue);
// Console.ReadLine();

// static void StartCountdown(int startValue)
// {



//     for (int i = startValue; i > 0; i--)
//     {
//         Console.WriteLine(i);
//         Thread.Sleep(1000);
//     }

// }



//METOD#3

// GetNumb();
// Console.ReadLine();

// int GetNumb()
// {
//   int result;
//   while (true)
//   {


//     Console.WriteLine("Skrive ett positivt heltal!");
//     string answer = Console.ReadLine() ?? string.Empty;
//     bool success = int.TryParse(answer, out result);
//     if (true && result >= 1)
//     {
//       Console.WriteLine($" Du valde att skriva: {result}");
//       break;
//     }

//     else
//     {
//       Console.WriteLine("Try again bozo");

//     }
//   }

//       return result;
// }



//Metod#4

// float Farenheit = 0;
// Console.WriteLine("Hur mycket Farenheit vill du konvertera till Celcius?");
// string answer = Console.ReadLine() ?? string.Empty;
// float.TryParse(answer, out Farenheit);

// float c = GetCelcius(Farenheit);

// Console.WriteLine($"{Farenheit} Farenheit är {c} celcius");


// float GetCelcius(float Farenheit)
// {
//   float celcius = (Farenheit - 32) * 5 / 9;
//   return celcius;
// }



// Console.ReadLine();




































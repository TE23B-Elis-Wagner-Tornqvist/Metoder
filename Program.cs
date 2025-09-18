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

// StartCountdown(10);
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

GetNumb();
Console.ReadLine();

int GetNumb()
{
    
        Console.WriteLine("Skriv in ett positivt heltal");
        string answer = Console.ReadLine() ?? string.Empty;
        int result;
       bool success = int.TryParse(answer, out result);
    while (success == false)
    {
             if (success == true)
            {
                Console.WriteLine(result);
                break;
            }
            else {
            Console.WriteLine("Try again bozo");
            Console.ReadLine();
                
            }
        
    }

    
      return result;
}






































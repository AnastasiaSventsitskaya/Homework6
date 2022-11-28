// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Write the numbers, when you're done write q: ");
string input = string.Empty;
int count = 0;
while(true)
{
    input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    int number = Convert.ToInt32(input);
    if (number > 0)
    {
        count +=1;
    }
} 


Console.WriteLine("Колличество чисел больше нуля: "+count);


string [] arrayfirst = new string [12] {"8654", "Ali", "BSE", "21212", "Tashkent", "Vibes", "433", "/", "-)*", "27","Rich","Beauty"};
string [] arraysecond = new string [arrayfirst.Length];
void SecondArrayWithIF (string [] arrayfirst, string [] arraysecond)
{
    int count = 0;
    for (int i = 0; i < arrayfirst.Length; i++)
    {
   if (arrayfirst [i].Length <= 3)
        {
        arraysecond [count] = arrayfirst [i];
        count++;
       }
   }
}
void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine ();
}
SecondArrayWithIF (arrayfirst, arraysecond);
Console.WriteLine ("Массив из строк, длина которых меньше, либо равна 3 символа: ");
PrintArray (arraysecond);
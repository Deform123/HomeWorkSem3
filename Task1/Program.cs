// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(userNumber);

if (number.Length < 5 )
    Console.WriteLine("Введенное Вами число имеет меньше пяти знаков. "); 
else if ( number[0] == number[4] && number[1] == number[3] ) 
    Console.WriteLine($"Введенное вами число {userNumber} является палиндромом.");
else if ( number[0] != number[4] || number[1] != number[3] )
    Console.WriteLine($"Введенное вами число {userNumber} не является палиндромом.");

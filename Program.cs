// Console.WriteLine("Границы целочисленных типов");
// Console.WriteLine($"byte:  {byte.MinValue} .. {byte.MaxValue}");
// Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
// Console.WriteLine($"int:   {int.MinValue} .. {int.MaxValue}");
// Console.WriteLine($"long:  {long.MinValue} .. {long.MaxValue}");

// Console.WriteLine();
// Console.WriteLine("Границы дробных типов");
// Console.WriteLine($"float:   {float.MinValue} .. {float.MaxValue}");
// Console.WriteLine($"double:  {double.MinValue} .. {double.MaxValue}");
// Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");


// Console.WriteLine();
// Console.WriteLine("Переполнение byte");

// byte maxByte = 255;
// byte overflowed = (byte)(maxByte + 1);
// Console.WriteLine($"255 + 1 для byte = {overflowed}");

// Console.WriteLine();
// Console.WriteLine("char");

// char firstLetter = 'A';
// char separator = '-';
// int charAsNumber = firstLetter; //char можно неявно превратить в int - это в таблице Unicode

// Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
// Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
// Console.WriteLine($"Табуляция:\tпосле таба");
// Console.WriteLine($"Перенос:\nпосле переноса");


// Console.WriteLine();
// Console.WriteLine("decimal против double");

// double priceDouble = 0.1 + 0.2;
// decimal priceDecimal = 0.1m + 0.2m;

// Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
// Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");


// Console.WriteLine();
// Console.WriteLine("var");

// var studentAge = 20;
// var gpa = 4.75;
// var fullName = "Смирнова А.С.";

// Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}"); 


// Console.WriteLine();
// Console.WriteLine("Ввод чисел: Convert и Parse");

// Console.WriteLine("Введите ваш год рождения: ");
// string birthYearInput = Console.ReadLine();

// int birthYearConvert = Convert.ToInt32(birthYearInput);
// int birthYaerParse = int.Parse(birthYearInput);

// Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
// Console.WriteLine($"int.Parse: {birthYaerParse}");
// Console.WriteLine($"В 2030 году вам будет {2030 - birthYearConvert} лет");


// Console.WriteLine();
// Console.WriteLine("Введите количество прочитанных книг за семестр: ");
// string booksInput = Console.ReadLine();

// bool wasSuccessfull = int.TryParse(booksInput, out int booksCount);

// Console.WriteLine($"Удалось преобразовать: {wasSuccessfull}");
// Console.WriteLine($"Значение переменной BooksCount: {booksCount}");


Console.WriteLine();
// 1. Имя и фамилия
Console.Write("Введите имя и фамилию: ");
string fullName = Console.ReadLine();

// 2. Название группы
Console.Write("Введите группу: ");
string group = Console.ReadLine();

// 3. Год рождения
Console.Write("Введите год рождения: ");
int birthYear = int.Parse(Console.ReadLine());

// 4. Средний балл
Console.Write("Введите средний балл: ");
double averageScore = double.Parse(Console.ReadLine());

// 5. Любимая буква (берем первый символ строки)
Console.Write("Введите любимую букву: ");
char favoriteLetter = Console.ReadLine()[0];

Console.WriteLine();
Console.WriteLine("====== Анкета ======");
// Вывод данных с помощью интерполяции строк
Console.WriteLine($"{fullName}, группа {group}");
Console.WriteLine($"Год рождения: {birthYear} (в 2030 будет {2030 - birthYear} лет)");
Console.WriteLine($"Средний балл: {averageScore}");
bool isGoodStudent = averageScore >= 4.0; // Сравнение
Console.WriteLine($"Балл >= 4.0: {isGoodStudent}");
Console.WriteLine($"Любимая буква: {favoriteLetter}");
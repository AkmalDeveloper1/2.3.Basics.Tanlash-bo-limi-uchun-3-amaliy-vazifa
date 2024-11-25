//1.Palindrome Check - Palindrome Tekshiruvi
Console.Write("Enter the word: ");
string palindrom1 = Console.ReadLine().ToLower(); // Kiyik 
bool result1 = false;
int rangeOfPalindrom1 = palindrom1.Length / 2;
for (int i = 0; i < rangeOfPalindrom1; i++)
{

    if ((palindrom1[0] != palindrom1[palindrom1.Length - 1]))
    {
        result1 = false;
        break;
    }
    else
    {
        result1 = true;
        palindrom1 = palindrom1.Substring(1, palindrom1.Length - 2);
    }
}
if (result1)
    Console.WriteLine("palindrom");
else
    Console.WriteLine("palindrom emas");

//2.Temperature conversion - Temperatura o'girish
Console.Write("Iltimos, Selsiyus bo‘yicha temperaturani kiriting: ");
decimal celsius = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("O'lchovni tanlang:");
Console.WriteLine("1 - Fahrenheit");
Console.WriteLine("2 - Kelvin");
Console.WriteLine("3 - Har ikkisi");
string choice = Console.ReadLine();
switch (choice)
{
    case "1":
        decimal fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine($"Selsiyus: {celsius}, Fahrenheit: {fahrenheit:F2}");
        break;

    case "2":
        decimal kelvin = celsius + 273.15m;
        Console.WriteLine($"Selsiyus: {celsius}, Kelvin: {kelvin:F2}");
        break;

    case "3":
        fahrenheit = celsius * 9 / 5 + 32;
        kelvin = celsius + 273.15m;
        Console.WriteLine($"Selsiyus: {celsius}, Fahrenheit: {fahrenheit:F2}, Kelvin: {kelvin:F2}");
        break;

    default:
        Console.WriteLine("Noto‘g‘ri tanlov kiritildi!");
        break;
}


//3.Sorting numbers - sonlarni tartiblash
Console.Write("Sonlarni kiriting ',' bilgisi bilan ajratgan holda\nmasalan(1,2,3,4,5) : ");
string numbers3 = Console.ReadLine(); //1,2,34,12,3,2,2,4,3,53,6,2,100,14
string[] numbersMassiv3 = numbers3.Split(',');
int[] intNumbers3 = new int[numbersMassiv3.Length];
for (int i = 0; i < numbersMassiv3.Length; i++)
    intNumbers3[i] = Convert.ToInt32(numbersMassiv3[i]);
Console.Write("1.Tartiblangan qator shaklida joylanishi un \"1\" ni bo'sing\n");
Console.Write("2.Teskari tartib joylanishi un \"2\" ni bo'sing\n");
Console.Write("3.Ikkalasini ham tanlash uchun \"3\" ni bo'sing\nTartibni tanlang: ");
int tartib3 = Convert.ToInt32(Console.ReadLine());
switch (tartib3)
{
    case 1:
        Array.Sort(intNumbers3);
        numbers3 = string.Join(",", intNumbers3);
        Console.WriteLine("Tartiblangan qator: " + numbers3);
        break;
    case 2:
        Array.Sort(intNumbers3);
        Array.Reverse(intNumbers3);
        numbers3 = string.Join(",", intNumbers3);
        Console.WriteLine("Teskari tartib: " + numbers3);
        break;
    case 3:
        Array.Sort(intNumbers3);
        numbers3 = string.Join(",", intNumbers3);
        Console.WriteLine("Tartiblangan qator: " + numbers3);
        Array.Reverse(intNumbers3);
        numbers3 = string.Join(",", intNumbers3);
        Console.WriteLine("Teskari tartib: " + numbers3);
        break;
    default: Console.WriteLine("hato kiritildi !!!"); break;
}

// 4.Calculating the number of symbols in a given text - Berilgan matnning simvol sanasini hisoblash: 
Console.Write("Enter the text: ");
string text4 = Console.ReadLine(); // Hello, world!
int count = 0;
char firstChar;
string result = "";
while (text4.Length > 0)
{
    firstChar = text4[0];
    count = text4.Count(c => c == firstChar);
    text4 = text4.Replace(Convert.ToString(firstChar), "");
    result += $"'{firstChar}': {count} martta, ";
}
Console.WriteLine(result.TrimEnd(' ', ','));
/* 13. Roman to Integer
Symbol/Value I - 1, V - 5, X - 10, L - 50, C - 100, D - 500, M - 1000

Input: s = "III"
Output: 3
Explanation: III = 3.

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4. */

Console.Write("Введите рисмское число: ");
string roman = Console.ReadLine();
int res = 0;

//Конвертация маленьких букв в большие
roman = roman.Replace("i", "I");
roman = roman.Replace("v", "V");
roman = roman.Replace("x", "X");
roman = roman.Replace("l", "L");
roman = roman.Replace("c", "C");
roman = roman.Replace("d", "D");
roman = roman.Replace("m", "M");

//Словарь для перевода римских букв в числа
Dictionary<char, int> romanNumbers = new()
{
{'I', 1},
{'V', 5},
{'X', 10},
{'L', 50},
{'C', 100},
{'D', 500},
{'M', 1000}
};

//Сравнение - если текщий символ не последний и следующая цифра больше текущей, делаем минус текущей цифры от общей суммы (сложная Римская логика (-__-))
//Если следующая меньше текущей - прибавляем к сумме
for (int i = 0; i < roman.Length; i++)
{
    char currentRomanChar = roman[i];
    romanNumbers.TryGetValue(currentRomanChar, out int num);
    if (i + 1 < roman.Length && romanNumbers[roman[i + 1]] > romanNumbers[currentRomanChar])
    {
        res -= num;
    }
    else
    {
        res += num;
    }
}

Console.WriteLine($"Введенно число - {res}");


//int RomanToInt(string roman)
// {

//     int res = 0;

//     roman = roman.Replace("i", "I");
//     roman = roman.Replace("v", "V");
//     roman = roman.Replace("x", "X");
//     roman = roman.Replace("l", "L");
//     roman = roman.Replace("c", "C");
//     roman = roman.Replace("d", "D");
//     roman = roman.Replace("m", "M");

//     Dictionary<char, int> romanNumbers = new()
// {
// {'I', 1},
// {'V', 5},
// {'X', 10},
// {'L', 50},
// {'C', 100},
// {'D', 500},
// {'M', 1000}
// };

//     for (int i = 0; i < roman.Length; i++)
//     {
//         char currentRomanChar = roman[i];
//         romanNumbers.TryGetValue(currentRomanChar, out int num);
//         if (i + 1 < roman.Length && romanNumbers[roman[i + 1]] > romanNumbers[currentRomanChar])
//         {
//             res -= num;
//         }
//         else
//         {
//             res += num;
//         }
//     }
//     return res;
// }


// Console.Write("Введите рисмское число: ");
// string roman = Console.ReadLine();
// Console.WriteLine($"Введенно число - {res}");
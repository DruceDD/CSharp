/* Перевести число, введенное в консоли, из римских цифр в арабские.
Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Example 1:
Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:
Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:
Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
*/

bool NumberExist(string[] letters, string inputNumber)
{
  bool flag = true;
  for (int j = 0; j < letters.Length; j++)
  {
    if (inputNumber.Contains(letters[j]) == true)
    {
      flag = false;
      break;
    }
    else flag = true;
  }
  return flag;
}

Dictionary<char, int> romanDigits = new Dictionary<char, int>
{
    { 'I', 1 },
    { 'V', 5 },
    { 'X', 10 },
    { 'L', 50 },
    { 'C', 100 },
    { 'D', 500 },
    { 'M', 1000 },
};

string[] exceptions = { "IL", "IC", "ID", "IM", "VX", "VL", "VC", "VD", "VM", "XD", "XM", "LC", "LD", "LM" };

Console.WriteLine("Введите римское число: ");
string input = Console.ReadLine();
string upper = input.ToUpper();
char[] roman = upper.ToCharArray();

int result = 0;

if (NumberExist(exceptions, upper) == true)
{
  for (int i = 0; i < roman.Length - 1; i++)
  {
    if (romanDigits[roman[i]] < romanDigits[roman[i + 1]]) result -= romanDigits[roman[i]];
    else if (romanDigits[roman[i]] >= romanDigits[roman[i + 1]]) result += romanDigits[roman[i]];
  }
  result += romanDigits[roman[^1]];
  Console.WriteLine($"Введенное число равно {result}");
}
else
{
  Console.WriteLine("Число введено неверно!");
}
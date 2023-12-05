// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string str = "aBcD1ef!-";
string newStr = string.Empty;
for (int i = 0; i<str.Length; i++) {
    switch (str[i]) {
        case 'A':
        newStr += "a";
        break;
        case 'B':
        newStr += "b";
        break;
        case 'C':
        newStr += "c";
        break;
        case 'D':
        newStr += "d";
        break;
        case 'E':
        newStr += "e";
        break;
        case 'F':
        newStr += "f";
        break;
        default:
        newStr += str[i];
        break;
    }
}
Console.WriteLine($"{str} = > {newStr}");
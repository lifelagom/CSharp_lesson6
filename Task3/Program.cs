// Задайте произвольную строку. Выясните, является ли она палиндромом.

// Проверка строки на палиндром
bool CheckPalindrom(string text) {
    bool palindrom = true;
    for(int i = 0; i < text.Length/2; i++){
        if (!(text[i]==text[text.Length-i-1])) {
            palindrom = false;
            break;
        }
    }
    return palindrom;
}
// Основной код
string text = "шалаш";
Console.WriteLine($"'{text}' => {CheckPalindrom(text)}");
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string ReversWordInString(string text) {
    string newString = string.Empty;
    for (int i = text.Length-1; i>=0; i--) {
        string tempWord = string.Empty;
        if (text[i]==' ' | i==0) {
            for (int j = i+1; j<text.Length && !(text[j]==' ') ; j++) {
                tempWord += text[j];
            }
            if (i==0) {
                newString += text[i] + tempWord;
            } else {
                newString += tempWord+" ";
            }
            
        }
    }    
    return newString;
}

string text = "Hello my world";
Console.WriteLine($"'{text}' => '{ReversWordInString(text)}'");
// Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

// вывод массива
void PrintMatrix(char[,] matrixForPrint) {
    for(int i = 0; i < matrixForPrint.GetLength(0); i++){
        for(int j = 0; j < matrixForPrint.GetLength(1); j++) {
            Console.Write(matrixForPrint[i,j]+"\t");
        }
        Console.WriteLine();
    }
}
// Вывод матрицы символов в виде строки
void PrintCharInString(char[,] matrix) {
    string str = string.Empty;
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++) {
            str += matrix[i, j];
        }
    }
    Console.WriteLine(" => ");
    Console.WriteLine($"'{str}'");
}
// Основной код
char[,] matrix = new char[,]{{'a','b','c'},{'d','e','f'}};
PrintMatrix(matrix);
PrintCharInString(matrix);
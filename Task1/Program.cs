// Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

int ReadInt(string text) {
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
// создаем массив
char[,] GenerateMatrix(int row, int col, int leftRange, int rightRange) {
    char[,] tempMatrix = new char[row,col];
    Random rand = new Random();
    for(int i = 0; i < tempMatrix.GetLength(0); i++){
        for(int j = 0; j < tempMatrix.GetLength(1); j++) {
            tempMatrix[i,j] = Convert.ToChar(rand.Next('a', 'a'+27));
        }
    }
    return tempMatrix;
}
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
    Console.WriteLine(str);
}
// Основной код
int rows = ReadInt("Введите количество строк в массиве: ");
int cols = ReadInt("Введите количество столбцов в массиве: ");
char[,] matrix = GenerateMatrix(rows, cols, 1, 9);
PrintMatrix(matrix);
PrintCharInString(matrix);
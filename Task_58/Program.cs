//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,] CreateRandomMatrix(int rows,int columns,int minValue, int maxValue)
{    
    int[,] matrix = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    
            for(int j = 0; j < columns; j++)

                matrix[i,j] = new Random().Next(minValue,maxValue + 1);
    
    return matrix;


}

void ShowMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1); j++)
       
            Console.Write(matrix[i,j] + " "); 
       
       Console.WriteLine();
    }   
}
void MultMatrix(int[,] matrix1, int[,] matrix2, int[,] resmatrix)
{
    if(matrix1.GetLength(1) == matrix2.GetLength(0))
    {     
        for(int i = 0; i < resmatrix.GetLength(0); i++)
        {
            for(int j = 0; j < resmatrix.GetLength(1); j++)
            {
                for(int k = 0; k < matrix1.GetLength(1); k++)
                {
                    
                    resmatrix[i,j] += matrix1[i,k] * matrix2[k,j]; 
                    Console.Write(resmatrix[i,j] + " ");
                    
                }
                Console.WriteLine();
            }
        
        }
    
    }    
    
    
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix1 = CreateRandomMatrix(m, n , min, max);
ShowMatrix(myMatrix1);
Console.WriteLine();

Console.Write("Input a number of rows: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minxy = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxxy = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix2 = CreateRandomMatrix(x, y , minxy, maxxy);
ShowMatrix(myMatrix2);
Console.WriteLine();


int[,] resmatrix = new int[m,y];
MultMatrix(myMatrix1,myMatrix2,resmatrix);
Console.WriteLine();
















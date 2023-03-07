// Zadacha1
/*double [,] FillArray(double [,] matr){
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            matr[i,j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
        }
    }
 return matr;   
}
void PrintArray(double [,] matr){
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n,m];
PrintArray(FillArray(matrix));*/
   
    //Zadacha2
double [,] FillArray(double [,] matr){
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            matr[i,j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
        }
    }
 return matr;   
}
void PrintArray(double [,] matr){
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}
double[,] matrix = new double[3,4];
PrintArray(FillArray(matrix));
void Position(double [,] matr){
    Console.WriteLine("Введите позицию элемента");
    int count1 = Convert.ToInt32(Console.ReadLine());
    int count2 = Convert.ToInt32(Console.ReadLine());
    if(count1 >= matr.GetLength(0) || count2 >= matr.GetLength(1)){
        Console.WriteLine("Такого элемента не существует!");
    }
    else if(count1 >= matr.GetLength(0) && count2 >= matr.GetLength(1)){
        Console.WriteLine("Такого элемента не существует!");
    }
    else{
        double Pos = matr[count1, count2];
        Console.WriteLine(Pos);
    }

}
Position(matrix);

   //Zadacha3
/*double [,] FillArray(double [,] matr){
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            matr[i,j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
        }
    }
 return matr;   
}
void PrintArray(double [,] matr){
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n,m];
PrintArray(FillArray(matrix));
void Sum(double [,] matr){
    double sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++){
        for(int i = 0; i < matr.GetLength(0); i++){
            sum = sum + matr[i, j];
        }
        Console.WriteLine("{0:0.00}",sum / matr.GetLength(0));
        sum = 0;
    }
}
Console.WriteLine();
Sum(matrix);*/
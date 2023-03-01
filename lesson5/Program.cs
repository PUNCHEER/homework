  //Zadacha1

/*int [] CreateArray(int size){
    int [] arr = new int [size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++){
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;

}
int Sum(int [] arr){
    int sum = 0;
    int i = 0;
    while(i < arr.Length){
    if(arr[i] % 2 == 0){
        sum = sum + 1;
        i++;
        }
    i++;
}
return sum;
}
Console.WriteLine(Sum(CreateArray(8)));*/

//Zadacah 2

/*int [] CreateArray(int size){
    int [] arr = new int [size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++){
        arr[i] = rnd.Next(-100, 100);
        Console.Write(arr[i]+" ");
    }
    Console.WriteLine();
    return arr;
}
int Sum(int [] arr){
    int sum = 0;
    for(int i = 0; i < arr.Length; i++){
        if(i % 2 != 0){
         sum = sum + arr[i];
        }
    }
    return sum;
}
Console.WriteLine(Sum(CreateArray(8)));*/

//Zadacha3

int [] arr = {3, 7, 22, 2, 78};
void PrintArray(int [] arr){
    int count = arr.Length;
    for(int i = 0; i < count; i++){
        Console.Write($"{arr[i]} ");
    }
}
int Difference(int [] array){
    return array.Max() - array.Min();
}
PrintArray(arr);
Console.WriteLine();
Console.WriteLine(Difference(arr));
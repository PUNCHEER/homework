   /* int [] arr(int count){
    int [] array = new int [count];
    for(int i = 0; i < count; i++){
        Console.WriteLine("Введите число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    } 
    return array;
}
void PrintArray(int [] array){
    foreach(int newarray in array){
        Console.Write(newarray +" ");
}
}
void PositiveNumber(int [] array){
    int PosNum = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] > 0){
            PosNum = PosNum + 1;
        }
    }
    Console.WriteLine("Количество положительных чисел ="+" "+ PosNum);
}
Console.WriteLine("Введите количество чисел");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = arr(N);
PrintArray(array);
PositiveNumber(array);*/
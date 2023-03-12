//Zadacha1
/*int Numbers(int Num)
{
    if (Num == 0)
    {
        return 0;
    }
    else if(Num > 0){
    int result = Num;
    Console.Write(result + " ");
}
return Numbers(Num - 1);
}
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(Numbers(N));*/
//Zadacha2
/*int Sum(int N, int M)
{
    if (N < M) return N + Sum(N + 1, M);
    else return 0;
}
int N = Convert.ToInt32(Console.ReadLine());
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(N, M));*/

//Zadacha3
/*int Ack(int n, int m)
{
    if(n == 0) return m + 1;
    else if (n > 0 && m == 0) return Ack(n - 1, 1);
    else return Ack(n - 1, Ack(n , m - 1));
}
Console.WriteLine(Ack(3, 2));*/
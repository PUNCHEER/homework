/*double num1 = Convert.ToInt32(Console.ReadLine());
double num2 = Convert.ToInt32(Console.ReadLine());
double POW(double a, double b){
    return  Math.Pow(a, b);
}
POW(num1, num2);
Console.WriteLine(POW(num1,num2));*/


/*int SumDigits(string str){
   
   int sum = 0;
   foreach(var dig in str){
    sum += dig - '0';
   }
   return sum;
}

 Console.WriteLine(SumDigits("567"));*/

  void PrintArray(int []arr){

   foreach(var i in arr){
    Console.Write("{0} ", i);
   }
 }


 int[] FillArray(int size){
  
  int[] arr = new int[size];
  Random rnd = new Random();
  for(uint i = 0; i < size; ++i){
    arr[i] = rnd.Next(size);
 }
    return arr;
 }

 PrintArray(FillArray(8));

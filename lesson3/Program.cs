     //Zadacha 1
/*void PrintThirdDigit(string? str)
{
    if (str?.Length == 5 && str[0] == str[4] && str[1] == str[3]){
      Console.WriteLine("Yes");
    }else
    Console.WriteLine("no");
}
string? result = Console.ReadLine();
PrintThirdDigit(result);*/

    //Zadacha 2
  double Distance(Point p1, Point p2){
       return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) +
                        Math.Pow(p2.y - p1.y, 2) +
                        Math.Pow(p2.z - p1.z, 2)); 
    }
    int x, y, z, x1, y1, z1;
    Console.WriteLine("Введите координаты");
    x = Convert.ToInt32(Console.ReadLine());
    y = Convert.ToInt32(Console.ReadLine());
    z = Convert.ToInt32(Console.ReadLine());
    x1 = Convert.ToInt32(Console.ReadLine());
    y1 = Convert.ToInt32(Console.ReadLine());
    z1 = Convert.ToInt32(Console.ReadLine());
     Point p1 = new Point(x, y, z);
     Point p2 = new Point(x1, y1, z1);
     Console.WriteLine("{0:0.00}",Distance(p1, p2));

     struct Point{
        public Point(int x1, int y1, int z1){
            x = x1;
            y = y1;
            z = z1;
        }
         public int x;
         public int y;
         public int z;
     }
     
    
    //Zadacha 3
/*int i = 1;
double sum = 0;
    void POW(double number){
     while(i <= number)
     {        
        if(i < number)
        {
        sum = Math.Pow(i, 3);
        Console.Write(sum +",");
        }
        else
        {
        sum = Math.Pow(i, 3);
        Console.Write(sum);
        }
        ++i;
    }}
double N = Convert.ToDouble(Console.ReadLine());
POW(N);*/
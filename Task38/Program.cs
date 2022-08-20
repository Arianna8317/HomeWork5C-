double[] GenDoubleArray(int N)
{

   double[] masRand = new double[N];
   Random rnd = new Random();
   
    for (int i = 0; i < N; i++)
    {
        masRand[i] = Math.Round((new Random().Next(-100, 100)) * rnd.NextDouble(),2) ;
    }
    return masRand;

}
 void PrintDoubleArray(double[] arr)
 {
   System.Console.Write("{"); 
   for (int i = 0; i < arr.Length; i++)
   {
    Console.Write(arr[i]);
    if (i < arr.Length-1) 
       System.Console.Write("; ");
   }
   System.Console.WriteLine("}");
  }

(double Min, double Max) MinMax(double[] Array)
  {
    
    double min = Array[0];
    double max = min;
    for (int i = 0; i < Array.Length; i++)
     {   if (Array[i]>max )
             max = Array[i];
        if (Array[i]<min )
             min = Array[i];
          
     }  
    return (Min: min, Max: max);

  }       
        
  System.Console.Write("Введите число элементов массива : ");
  int N = Convert.ToInt32(Console.ReadLine());
  System.Console.Write("Массив ");
  double[] Array=GenDoubleArray(N);
  PrintDoubleArray(Array);
  double res =  MinMax(Array).Max-MinMax(Array).Min;
  System.Console.WriteLine($"Максимум превышает минимум на   {res}");
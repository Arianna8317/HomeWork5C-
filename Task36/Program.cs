int[] GenMas(int N)
{

    int[] masRand = new int[N];

    for (int i = 0; i < N; i++)
    {
        masRand[i] = new Random().Next(1, 1000);
    }
    return masRand;

}
 void PrintArray(int[] arr)
 {
   System.Console.Write("{"); 
   for (int i = 0; i < arr.Length; i++)
   {
    Console.Write(arr[i]);
    if (i < arr.Length-1) 
       System.Console.Write(", ");
   }
   System.Console.WriteLine("}");
  }

  int OddSum(int[] Array)
  {
    int sum = 0;
    int len = Array.Length;
    if (len >1 )
    {
      for (int i = 0; i < Array.Length; i++)
        if ( i%2==1)
           sum+= Array[i];
    }       
       return sum;

  }       
        
  System.Console.Write("Введите число элементов массива : ");
  int N = Convert.ToInt32(Console.ReadLine());
  int[] Array=GenMas(N);
  PrintArray(Array);
  
  System.Console.WriteLine("Сумма элементов на нечетных позициях равна " + OddSum(Array));

//[345, 897, 568, 234] -> 2

int[] GenMas(int N)
{

    int[] masRand = new int[N];

    for (int i = 0; i < N; i++)
    {
        masRand[i] = new Random().Next(100, 1000);
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

  int EvenCounter(int[] Array)
  {
    int counter=0;
    for (int i = 0; i < Array.Length; i++)
      if ( Array[i]%2==0)
          counter ++;
     return counter;     
  }       
        
  System.Console.Write("Введите число элементов массива : ");
  int N = Convert.ToInt32(Console.ReadLine());
  int[] Array=GenMas(N);
  PrintArray(Array);
  
  System.Console.WriteLine("Число четных элементов равно " + EvenCounter(Array));

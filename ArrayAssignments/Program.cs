using System;

namespace ArrayAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            
        // Find Max and Min value
         /*   int[] arr1= new int[100];
            int i, mx, mn, n;
            Console.Write("Input the number of elements to be stored in the array :");
	   n= Convert.ToInt32(Console.ReadLine());  
   
       Console.Write("Input {0} elements in the array :\n",n);
       for(i=0;i<n;i++)
            {
	      Console.Write("element - {0} : ",i);
		  arr1[i] = Convert.ToInt32(Console.ReadLine());  
	    }


    mx = arr1[0];
    mn = arr1[0];

    for(i=1; i<n; i++)
    {
        if(arr1[i]>mx)
        {
            mx = arr1[i];
        }


        if(arr1[i]<mn)
        {
            mn = arr1[i];
        }
    }
    Console.Write("Maximum element is : {0}\n", mx);
    Console.Write("Minimum element is : {0}\n\n", mn);*/




        //Unique value print
          /*  int[] arr = new int[100];;
        int i, j, k, size, isUnique;
 
        Console.WriteLine("Enter size of the array: ");
        size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements in the array: ");              
        for(i=0; i<size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());            
        }
 
 
         for(i=0; i<size; i++)
        {
            isUnique = 1;
 
            for(j=i+1; j<size; j++)
            {
 
 
                if(arr[i]==arr[j])
                {
                    for(k=j; k<size-1; k++)
                    {
                        arr[k] = arr[k+1];
                    }
 
                    size--;
                    j--;
                    isUnique = 0;
                }
           }
 
            
        
            if (isUnique != 1)
            {
                for (j = i; j < size - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
 
                size--;
                i--;
            }
        }
 
         
         Console.WriteLine("All unique elements in the array are: ");
         for (i = 0; i < size; i++)
         {
             Console.WriteLine(arr[i] + "\t");
         }
        Console.ReadLine();*/
    //Duplicate values in array
    /*int[] arr = new int[100];
        int i, j, num, count = 0;
 
        
        Console.WriteLine("Enter size of the array: ");
        num = Convert.ToInt32(Console.ReadLine());
 
        
        Console.WriteLine("Enter elements in the array: ");
        for (i = 0; i < num; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());           
        }
 
        
        for (i = 0; i < num; i++)
        {
            for (j = i + 1; j < num; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    break;
                }
            }
        }
 
        Console.WriteLine("\n Total number of duplicate elements found in array:"+count);
        Console.ReadLine();*/



       // JaggArray
       
       
       

         int[][] jaggedArray ={
           new int []{1,2,3},
           new int []{10,20},
           new int []{11,22,33,44}
        };



        // int[][] jaggedArray ={
        // jaggedArray[0] = new int [3]
        // jaggedArray[1] = new int [2];
        // jaggedArray[2] = new int [4];
        
        // jaggedArray[0] = new int [] {1,2,3};
        // jaggedArray[0] = new int [] {10,20};
        // jaggedArray[0] = new int [] {1,2,3,4};
        

        for (int i= 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                System.Console.Write(jaggedArray[i][j]+" ");
            }
            System.Console.WriteLine();
        }
            //  int[,] list = new int[3, 2];

            // System.Console.WriteLine("Enter elements in array: ");
            // for (int i=0; i<3;i++)
            // {
            //     for (int j=0; j <2; j++)
            //     {
            //         list[i, j]= Convert.ToInt32(Console.ReadLine());
            //     }
            // }

            // for (int i=0; i< 3; i++)
            // {
            //     for (int j = 0; j < 2; j++)
            //     System.Console.Write($"{list[i,j]} ");
            //     Console.WriteLine();





           /* int[,] marks = new int[4, 5];

            System.Console.WriteLine("Enter 20 values");
            for (int i=0; i<4;i++)
            {
                for (int j=0; j <5; j++)
                {
                    marks[i, j]= Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i=0; i< 4; i++)
            {
                for (int j=0; j<5; j++)
                System.Console.Write($"{marks[i,j]} ");
                Console.WriteLine();
            }*/
            
        //     }
        // }


       /* int i, n, f = 0;
		int[] arr = new int[5];

		Console.Write("Enter five numbers:");
		for (i = 0; i < arr.Length; i++)
		{
			arr[i] = Convert.ToInt32(Console.ReadLine());
		}

		Console.Write("Enter a number for search:");
		n = Convert.ToInt32(Console.ReadLine());

		for (i = 0; i < 5; i++)
		{
			if (arr[i] == n)
			{
				f = 1;
			}
		}

		if (f == 1)
		{
			Console.WriteLine("Number found:" + n);
		}
		else
		{
			Console.WriteLine("Number not found:" + n);
		}*/
            
            

        //  Negative Number in array
            /*int i       = 0;
            int[] arr   = new int[5];

            Console.WriteLine("Enter array elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("List of negative numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();*/
        }
    }
}
    


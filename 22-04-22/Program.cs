using System;

namespace _22_04_22
{
    class Program
    {
        static void Main(string[] args)
        {
            




            
    //Decending order string

            /*String[] arr = new string[] {"a","c","e","b","d","g","f","k","j","l"}; 
        Console.WriteLine("Array Before Sorting:\n");
        foreach(string value in arr) 
        { 
            Console.Write(value + " "); 
        } 
        Console.WriteLine("\n");
        Array.Sort(arr); 
        Array.Reverse(arr); 
        Console.WriteLine("Array After Sorting:\n"); 
        foreach(string value in arr) 
        { 
            Console.Write(value + " "); 
        }*/ 



    //Upper to Lower case string
          /*  string str;
        Console.WriteLine("Enter the String in Uppercase :");
        str = Console.ReadLine();
        Console.WriteLine("String in LowerCase : {0}", str.ToLower());
        Console.ReadLine();*/



    //Count the words
             /*int a = 0 , myWord = 1;
      string str = "I came, I saw, I conquered";
      while (a <= str.Length - 1) {
         if(str[a]==' ' || str[a]=='\n' || str[a]=='\t') {
            myWord++;
         }
         a++;
      }
      Console.Write("Number of words in the string = {0}\n", myWord);*/



        //Duplicate values
             /*String string1 = "Welcome to the World The world is Beautiful";  
        int count;  
          
         
        string1 = string1.ToLower();  
          
          
        String[] words = string1.Split(' ');  
          
        Console.WriteLine("Duplicate words in a given string : ");  
        for(int i = 0; i < words.Length; i++) {  
            count = 1;  
            for(int j = i+1; j < words.Length; j++) {  
                if(words[i].Equals(words[j])) {  
                    count++;  
                    
                    words[j] = "0";  
                }  
            }  
              
            
            if(count > 1 && words[i] != "0")  
                Console.WriteLine(words[i]);  
        }*/  
            
        }
    }
}

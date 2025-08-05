using System;


namespace ConsoleApp3
{
    internal class program
    {
        static void Main(string[] args)
        {
            //Output:                                     //program1
            //*****
            //****
            //***
            //**
            //*
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        for (int j = i; j <= 5; j++)     
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }


            //Output:                                 //program2
            //*
            //**
            //***
            //****
            //*****
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            //Output:                                    //program3
            //*****
            //*****
            //*****
            //*****
            //*****
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            //Output:                                   //program4
            //1
            //12
            //123
            //1234
            //12345
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}



            //Output:                                  //program5
            //    *
            //    **
            //    ***
            //    ****
            //    *****
            //    ****
            //    ***
            //    **
            //    *

            //for (int i = 1; i <= 9; i++)
            //{
            //    int k = i <= 5 ? i : 10 - i;

            //    for (int j = 1; j <= k; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}





            //Output:                                 //program6
            //    *
            //   **
            //  ***
            // ****
            //*****
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if (j <= 5 - i)
            //            Console.Write(" ");
            //        else
            //            Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Output:                                 //program7
            //it will print 1 to 10 table
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        int k = i * j;
            //        Console.Write(i + "*" + j + "=" + k);
            //    }
            //    Console.WriteLine();
            //}


            //int a = 5;
            //int b = 5;
            //int res = a++ + b++ + a++;                 ////output16 in this 5+5+6
            //Console.WriteLine(res);

            //int a = 5;
            //int b = 5;
            //int res = a++ + b++;                      ////output10
            //Console.WriteLine(res);


            //int a = 5;
            //int b = 5;
            //int result = a++;                         ////output5
            //Console.WriteLine(result);


            //int a = 5;
            //int b = 5;
            //int res = a++ + b++ + a++ + b++;          ////output22 5+6+5+6
            //Console.WriteLine(res);


            //int a = 5;
            //int b = 5;
            //int res = ++a + b++ + b++ + a++ + ++a + ++b + a++;          ////output47 6+5+6+6+8+8+8
            //Console.WriteLine(res);




            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //string[] digitWords = { "Zero", "One", "Two", "Three", "Four",
            //                        "Five", "Six", "Seven", "Eight", "Nine" };
            //string output = "";
            //while (number > 0)
            //{
            //    int digit = number % 10;
            //    number /= 10;
            //    for (int i = 0; i < digitWords.Length; i++)
            //    {
            //        if (digit == i)
            //        {
            //            output = digitWords[i] + " " + output;
            //        }
            //    }

            //}
            //Console.Write(output);
            //Console.ReadLine();
        }
    }
}
















// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] arrCreate ()

    {
        int m;
        int n;

        Random rndInt = new Random();

        m = rndInt.Next(2, 9);
        n = rndInt.Next(2, 9);

        int[,] nums = new int[m,n];

        for (int i = 0; i < nums.GetLength(0) ; i++ )
        {
            for (int j = 0; j < nums.GetLength(1) ; j++ )
            {
            nums[i,j] = rndInt.Next(0, 9);
            }
        }
    
        return nums;
    }


void calcColumnsMean ()

    {

        int[,] nums = arrCreate ();

        double columnSum;

        Console.WriteLine();

        Console.WriteLine("для следующего массива :");

        Console.WriteLine();


        for (int i = 0; i < nums.GetLength(0) ; i++ )

        {
            for (int j = 0; j < nums.GetLength(1) ; j++ )
            {
                Console.Write(nums[i,j]+" ");
            }

        Console.WriteLine();

        }

        Console.WriteLine();

        Console.WriteLine("получаем, что:");

        Console.WriteLine();
        
        for (int i = 0; i < nums.GetLength(1) ; i++ )
        {

        columnSum = 0;

            for (int j = 0; j < nums.GetLength(0) ; j++ )
            {

                columnSum =  columnSum + nums[j,i];

            }

            Console.WriteLine($"среднее арифметическое значений столбца {i + 1} равно {columnSum / nums.GetLength(0)}");

        }
    
    }

 calcColumnsMean ();
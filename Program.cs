





// int [] CreateArray(int min, int max, int size){
//   int [] array = new int [size];

// for(int i = 0; i < size; i++){
//   array[i] = new Random().Next(min, max+1);
// }
// return array;
// }

// void ShowArray(int [] arr){
//   for(int i = 0; i< arr.Length; i++){
//     Console.Write($"{arr[i]} ");
//   }
//   Console.WriteLine();
// }


// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int PosNumb(int [] array){
//    int count = 0;
//    for(int i = 0; i< array.Length; i++){
//       if (array[i] % 2 ==0){ 
//         count++; 
//       }
//   }
   
//   return count;
// }

// Console.WriteLine("Input min value ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size array ");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateArray(min, max, size);
// ShowArray(newArray);
// int pos = PosNumb(newArray);
// Console.WriteLine($"{pos}");


// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// void SumNegativePositions(int []array){
//   int sum = 0;
//   for(int i = 1; i<array.Length; i+=2){
//     sum += array[i];
//     }
//     Console.Write($"{sum}");
//   }
// Console.WriteLine("Input min value ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size array ");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateArray(min, max, size);
// ShowArray(newArray);
// SumNegativePositions(newArray);

// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


// int SearchMaxMin(int [] array){
//   int maxi = 0;
//   int mini = 0;
//   for (int i = 0; i < array.Length; i++){
//     if(array[i] > maxi){
//       maxi = array[i];
//     }
//     if (array[i] < maxi){
//       mini = array[i];
//     }
//   }
//     int res = maxi - mini;
//     return res;
//   }


// Console.WriteLine("Input min value ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size array ");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateArray(min, max, size);
// ShowArray(newArray);

// int result = SearchMaxMin(newArray);
// Console.WriteLine($"{result}");
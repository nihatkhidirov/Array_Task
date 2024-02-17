#region Task_1
//Verilmiş Arrayın elementlərinin cəmini ekrana çap edin.

//int[] arr = { 10, 20, 30, 40, 50, 60, 70,90 };
//int sum = 0;

//foreach (var item in arr)
//{
//    sum = sum + item;
//}
//Console.WriteLine("Arrayin elementlerinin cemi: "+ (sum));
#endregion
#region Task_2
//Verilmiş int Arrayın ən böyük dəyərə sahib elementini tapın.
//int[] array = { 20,21,23,30,41,88,91,255,80};
//foreach (var item in array)
//{
//    int count = 0;

//    for (int i = 0; i < array.Length; i++)
//	{

//        if (item > array[i])
//		{
//            count++;
//            if (count >= (array.Length-1))
//            {
//                Console.WriteLine("En Boyuk deyer:"+item);
//            }

//        }
//    }

//}
#endregion
#region Task_3
//Verilmiş Arrayın ilk və son elementlərinin cəmini tapın.
int[] arr = { 100, 230, 31, 50, 32,90,190 };
int count = 0;
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    count++;
    if (count == arr.Length-1)
    {
        sum = arr[0] + arr[arr.Length-1];
        Console.WriteLine(sum);
    }
}
#endregion

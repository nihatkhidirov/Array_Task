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
//int[] arr = { 100, 230, 31, 50, 32,90,190 };
//int count = 0;
//int sum = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    count++;
//    if (count == arr.Length-1)
//    {
//        sum = arr[0] + arr[arr.Length-1];
//        Console.WriteLine(sum);
//    }
//}
#endregion
#region Task_4
//1. Array içində olan Mürkkəb ədədlərin ədədi ortasını tapın.

//int[] arr = { 10, 20, 30, 40, 50, 51, 23, 29, 31, 43, 41, 90 };
//double elementCount = 0;
//double sum = 0;

//foreach (double item in arr)
//{

//    double count = 0;
//	for (int i = 2; i <=item; i++)
//	{
//		if (item % i == 0)
//		{
//			count++;
//		}

//    }
//    if (count > 2)
//    {
//        elementCount++;
//        sum = sum + item;

//    }

//}
//double avarage = sum / elementCount;
//Console.WriteLine("Murekkeb Ededlerin Ededi Ortasi: "+avarage);
#endregion
#region Task_5
//2.Array içində ən çox təkrar edən ədədi tapıp ekrana yazdırın
//int[] arr = { 10, 20, 22, 71,10}; //10
//int maxCount = 0;
//int tekrarlananEded = 0;
//foreach (var item in arr)
//{
//	int count = 0;
//	for (int i = 0; i < arr.Length; i++)
//	{
//		if (item == arr[i])
//		{
//			count++;

//		}

//    }
//    if (count > maxCount) //maxCount birinci count'un aldigi en yuksek deyeri saxlayir, ondan yuksek gelene qeder. 
//    {
//        maxCount = count;
//        tekrarlananEded = item;
//    }

//}
//Console.WriteLine(tekrarlananEded);
#endregion
#region Task_6
//3. Array içində unique ədədləri ekrana yazdırın ( unique dedikdə array içində sadəcə 1 dənə olan elementi nəzərdə tuturam
int[] newarr = { 10,10, 11,5, 11, 12, 13, 14, 12, 14, 13 };
int unique = 0;
int tex = 0;
foreach (var item in newarr)
{
	int count = 0;
	for (int i = 0; i < newarr.Length; i++)
	{
		if (item == newarr[i])
		{
			count++;

		}
	}
	if (count ==1) //1>0   
	{
		tex = count;
        unique=item;
	}

}
Console.WriteLine(unique);
#endregion


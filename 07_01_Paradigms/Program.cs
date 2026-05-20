int[] oddnumbers = { 11, 3, 5, 7, 9 ,11 };
int[] evennumbers = { 10, 20, 50, 60, 30 ,22 };
int min = findMin(evennumbers);
int findMin(int[] arr) { 


int min = arr[0];
for (int i = 0; i < arr.Length; i++)
	{
	if(arr[i] < min)
		{
			min=arr[i];
			return min;
		}
	 

	}
	return min;
}
Console.WriteLine(min);
Console.ReadKey();

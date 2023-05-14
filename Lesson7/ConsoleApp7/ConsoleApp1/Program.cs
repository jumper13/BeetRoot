// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//// SelectionSort


void SelectionSort(int[] array)
{
    int n = array.Length;

    for (int i = 0; i < n - 1; i++)
    {
        int minIndex = i;

        // Find Min Item of Array
        for (int j = i + 1; j < n; j++)
        {
            if (array[j] < array[minIndex])
            {
                minIndex = j;
            }
        }

        // Replace items in unsorted part of array 
        int temp = array[i];
        array[i] = array[minIndex];
        array[minIndex] = temp;
    }
}


int[] numbers = { 2, 23, 24, 35, 16, 47, 58, 59, 29, 81 };
SelectionSort(numbers);

foreach (int number in numbers)
{
    Console.Write(number + " ");
}






//// Bubble Sort 



void BubbleSort(int[] array) {

    int amount = array.Length;  // amount of indexex arrays
    bool isSwapped;

    for (int k = 0; k < amount - 1; k++)
    {
        isSwapped = false;

        for (int m = 0; m < amount - 1; m++)
        {

            if (array[m] > array[m + 1])

            {
                int temp = array[m];
                array[m] = array[m + 1];
                array[m + 1] = temp;
                isSwapped = true;

            }

        }

        if (!isSwapped)
        {
            break;
        }

    }


}


int[] numbers1 = { 22, 12, 4, 31, 2, 6, 1, 8, 3 };

BubbleSort(numbers1);


foreach (int number in numbers1)
{
    Console.Write(number + " ");
}


/// Insertion Sort Type

void InsertionSort(int[] array)
{
    int n = array.Length;

    for (int i = 1; i < n; i++)
    {
        int key = array[i];
        int j = i - 1;

        while (j >= 0 && array[j] > key)
        {
            array[j + 1] = array[j];
            j--;
        }

        array[j + 1] = key;
    }
}



int[] numbers2 = { 42, 72, 62, 1, 28, 13, 12, 5, 8, 55 };
InsertionSort(numbers2);

foreach (int number in numbers2)
{
    Console.Write(number + " "); // Вывод отсортированного массива
}



// 1)  function recieves income array
// 2)  in function creating new array with amount the same like income array
// 
//
//



//void BubbleSort(int[] array) { 


//} 
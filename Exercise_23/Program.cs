int[] getFunction(int number)
{
    int [] array = new int[number];
    int i = 1;
    while(i <= number)
    {
        array[i - 1] = i * i * i;
        Console.WriteLine(array[i - 1]);   
        i++;
    }    
    return array;
}
int[] result = getFunction(5);

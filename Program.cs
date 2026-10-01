Console.WriteLine("Сколько за сегодня вы сделали продаж");

int quantity = Convert.ToInt32(Console.ReadLine());

int[] array = new int[quantity];

// цикл и положить внутрь массивы данные 
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine("На какие суммы вы продали эти товары");
    array[i]  = Convert.ToInt32(Console.ReadLine()); 
}

// Сумма всех продаж 
int summ = 0;

for(int i = 0; i < array.Length; i++)
{
    summ = summ + array[i];
}

Console.WriteLine("Сумма продаж за смену " + summ);

// cреднее значение 

double average = (double)summ / array.Length;

Console.WriteLine("Среднее значение вашего дохода " + average);

// максимальная продажа 
 int maxPrice = array[0];
 int maxIndex = 0;

for(int i = 0; i < array.Length; i++)
{
    if(maxPrice < array[i])
    {
        maxPrice = array[i];
        maxIndex = i;
    }
}

Console.WriteLine("Максимальный чек " + maxPrice + " номер чека " + maxIndex);

// минимальный прайс 

int minPrace = array[0];
int minIndex = 0;

for(int i = 0; i < array.Length; i++)
{
    if(minPrace > array[i])
    {
        minPrace = array[i];
        minIndex = i;
    }
}

Console.WriteLine("Минимальный чек за сегодня " + minPrace + " номер этого чека " + minIndex);

//Чек выше среднего 

int countAboveAverage = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > average)
    {
        countAboveAverage = countAboveAverage + 1;
    }
}


Console.WriteLine("Чек выше среднего " + countAboveAverage);
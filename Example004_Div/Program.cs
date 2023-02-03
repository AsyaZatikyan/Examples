/* Написать программу деление двух чисел.
*/

int numberA = new Random().Next (1,10);// 1,2,3,4,5,6,7,8,9,
Console.WriteLine($"Случайное первое целое число : {numberA}");
int numberB = new Random().Next(1, 10);
Console.WriteLine($"Случайное второе целое число :{numberB}");
int result = numberA / numberB;
Console.WriteLine(result);




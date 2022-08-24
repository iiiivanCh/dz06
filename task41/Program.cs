// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
int lengthArray = GetNumberFromUser("Сколько чисел желаете добавить: ", "Ошибка ввода");
int[] userNumberArray = GetNewArray(lengthArray);
Console.Write($"--> {GetPositiveNumber(userNumberArray)}");


int GetNumberFromUser(string message, string errorMessage)
{
  while (true)
  {
    Console.Write(message);
    bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
    if (isCorrect)
      return userNumber;
    Console.WriteLine(errorMessage);
  }
}

int[] GetNewArray(int lengthNewArray)
{
  int[] newArray = new int[lengthNewArray];
  for (int i = 0; lengthNewArray > i; i++)
    newArray[i] = GetNumberFromUser("Введите целoе числo: ", "Ошибка ввода!");
  return newArray;
}

int GetPositiveNumber(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (lengthArray - 1 == i)
      Console.Write($"{array[i]} ");
    else
      Console.Write($"{array[i]}, ");
    if (array[i] > 0)
      count++;
  }
  return count;
}
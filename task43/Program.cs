// Задача 43: Напишите программу, которая найдёт точку пересечения
//  двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// x = (b2 - b1) / (k1 - k2)

void SolutionSystemOfEquations()
{
  Console.Clear();
  double[] userArray = GetUserData();
  if (Validation(userArray) == false)
    return;
  double[] userIntersectionPoint = GetIntersectionPoint(userArray);
  Console.Clear();
  Console.Write($"b1 = {userArray[1]}, k1 = {userArray[0]}, b2 = {userArray[3]}, k1 = {userArray[2]}");
  Console.Write($" --> {userIntersectionPoint[0]}; {userIntersectionPoint[1]}");
}
SolutionSystemOfEquations();


double GetNumberFromUser(string message, string errorMessage)
{
  while (true)
  {
    Console.Write(message);
    bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
    if (isCorrect)
      return userNumber;
    Console.WriteLine(errorMessage);
  }
}

double[] GetUserData()
{
  double[] newArray = new double[4];
  newArray[0] = GetNumberFromUser("k1 = ", "Ошибка ввода!");
  newArray[1] = GetNumberFromUser("b1 = ", "Ошибка ввода!");
  newArray[2] = GetNumberFromUser("k2 = ", "Ошибка ввода!");
  newArray[3] = GetNumberFromUser("b2 = ", "Ошибка ввода!");
  return newArray;
}

double[] GetIntersectionPoint(double[] array)
{
  double[] result = new double[2];
  result[0] = (array[3] - array[1]) / (array[0] - array[2]);
  result[1] = (array[0] * result[0]) + array[1];
  return result;
}

bool Validation(double[] array)
{
  if (array[0] == array[2] && array[1] != array[2])
  {
    Console.Write("Нет решения, прямые параллельны");
    return false;
  };
  if (array[0] == array[2] && array[1] == array[2])
  {
    Console.Write("Прямые совпадают");
    return false;
  };
  return true;
}
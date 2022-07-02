int Second()
{
  int num = new Random().Next(100, 1000);
  Console.WriteLine("Current number is " + num);
  int des = (num%100)/10;
  int result = des;
  return result;
}

int number = Second();
Console.WriteLine("Result number is " + number);

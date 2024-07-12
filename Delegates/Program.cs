using Delegates.task1;
using Delegates.task2;
using Delegates.task3;

#region task1

Func<int, int> square = Class1.Square;
Console.WriteLine(square(5));

#endregion

#region task2

Func<double, double> convert = Class2.ConvertTemp;
Console.WriteLine(convert(50));

#endregion

#region task3

string sourcePath = "C:\\Users\\Lenovo\\source\\repos\\Delegates\\Delegates\\task3\\TextFile1.txt";
string destpath = "C:\\Users\\Lenovo\\source\\repos\\Delegates\\Delegates\\task3\\TextFile2.bin";

Action<string> readFIle = Class3.ReadFile;
readFIle(sourcePath);

Action<string, string> writeFile = Class3.WriteFile;
writeFile(sourcePath, "a, b, c");

Action<string, string> encrypt = Class3.Encrypt;
encrypt(sourcePath, destpath);	

#endregion
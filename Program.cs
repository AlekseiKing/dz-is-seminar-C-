//Задача №21.

int[] A = new int[3];
int[] B = new int[3];

Console.Write("Введите координату X1: ");
int.TryParse(Console.ReadLine()!, out A[0]);

Console.Write("Введите координату Y1: ");
int.TryParse(Console.ReadLine()!, out A[1]);

Console.Write("Введите координату z1: ");
int.TryParse(Console.ReadLine()!, out A[2]);

Console.Write("Введите координату X2: ");
int.TryParse(Console.ReadLine()!, out B[0]);

Console.Write("Введите координату Y2: ");
int.TryParse(Console.ReadLine()!, out B[1]);

Console.Write("Введите координату z2: ");
int.TryParse(Console.ReadLine()!, out B[2]);

int x = (A[0] - B[0]) * (A[0] - B[0]);
int y = (A[1] - B[1]) * (A[1] - B[1]);
int z = (A[2] - B[2]) * (A[2] - B[2]);
double c = Math.Sqrt(x + y + z);
c = Math.Round(c, 2);
Console.Write($"Расстояние между точками {c}\n");
//Console.Write("Расстояние между точками {0:N2}", c);
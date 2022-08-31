// exercicio 1
/* int N = int.Parse(Console.ReadLine());

if (N < 0) {
    Console.WriteLine("NEGATIVO");
}
else {
    Console.WriteLine("NAO NEGATIVO");
} */

//exercicio 3

string[] entries = Console.ReadLine().Split(' '); 
int A = int.Parse(entries[0]);
int B = int.Parse(entries[1]);

if (A % B == 0 || B % A == 0) {
   Console.WriteLine("Divisível");
} else {
   Console.WriteLine("Não divisível");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite três números!");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int resultado = Maior(a, b, c);
Console. WriteLine("O maior número é" + " " + resultado);

static int Maior(int n1, int n2, int n3) {
    int r;
    if (n1 > n2 && n1 > n3) {
        r = n1;
    } else if (n2 > n3) {
        r = n2;
    } else {
        r = n3;
    }
    return r;
}

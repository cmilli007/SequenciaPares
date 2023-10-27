int numero;
int numeroPar = 0;
do
{
Console.WriteLine("Digite um numero inteiro ou positivo?");

Int32.TryParse(Console.ReadLine(),out numero);
}

while (numero <= 0);
{

}
Console.WriteLine("Essa é a sequencia de numeros pares até esse número:");
while (numeroPar <= numero)
{
  
    Console.Write ($" {numeroPar}");
    numeroPar +=2;
}
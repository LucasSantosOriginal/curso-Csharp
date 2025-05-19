// See https://aka.ms/new-console-template for more information

int[] arInt = new int[] { 1, 2, 3, 4, 5 };

//int i = 0;
//while(i< arInt.Length) //indices em arrays começam em 0
//{
//    int numero = arInt[i];
//    Console.WriteLine(numero);
//    i++; //incremento de variavel ele como voce escrever i = i + 1;
//}

for (int j = 0; j < arInt.Length; j++)
{
    int numero = arInt[j];
    Console.WriteLine(j);
}

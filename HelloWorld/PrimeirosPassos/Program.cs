// See https://aka.ms/new-console-template for more information

//Operadores aritméticos
int adicao = 5 + 3;
int substracao = 5 - 3;
int multiplicacao = 5 * 3;
int divisao = 15 / 3;

int expr = (1 + 2) * 5 - 2 / 2; //caso queira priozar uma soma colocar elas entre ()

//Operadores relacionais

string cidade1 = "Sao Paulo";
string cidade2 = "Osasco";

bool ret1 = cidade1 == cidade2;  // "==" é igual
bool ret2 = cidade1 != cidade2;   // "!=" Diferente

int i = 2;
int j = 5;

bool ret3 = i == j; 
bool ret4 = i != j;
bool ret5 = i > j;
bool ret6 = i >= j; // >= maior ou igual
bool ret7 = i < j;
bool ret8 = i <= j;


//Operadores lógicos
bool ret9 = i < j && cidade1 != cidade2;
bool ret10 = i < j || cidade1 == cidade2;             // ou = ||
bool ret11 = !(i < j);

Console.WriteLine(ret10);

//Console.WriteLine("Teste");
//Console.WriteLine($"São Paulo é igual a Osasco? {ret1}");
//Console.WriteLine($"São Paulo é diferente de Osasco? {ret2}");

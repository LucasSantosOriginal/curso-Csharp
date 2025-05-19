// See https://aka.ms/new-console-template for more information


string frase = " O dia ta daora!!!!";


//Console.WriteLine(frase.Substring(0, 5));

//Console.WriteLine(frase.Replace("daora", "uma merda")); //replace muda a palaavra desejada

frase.Trim(); //trim remove espaço vazio no inicio e no final da string 
              // não precisa passar nenhuma variavel dentro dele para isso funcionar


frase.TrimEnd(); //remove o espaço vazio no final da string
frase.TrimStart(); //Remove os espaços vazio ao começo da string




//Console.WriteLine(frase.Trim('!'));  //é possivel remover caracteres especificos da string


string cpf = "345678900";

//Console.WriteLine(cpf.PadLeft(11, '0')); //adicionar caracteres na string na esquerda
                                         // por exemplo adicionar caracteres no cpf para chegarmos aos 11


string frase2 = frase + "Ensolarado";

//Console.WriteLine(frase2);

string frase3 = $"{frase} Ensolarado"; // interpolação traz uma maneira mais fluida de escrever strings
Console.WriteLine(frase3);


/*
 switch (variavel)
{
    case valor1:
        comando a ser executado;

    case valor2:
        comando a ser executado; 
        break;

    default:
        comando a ser executado;
        break;
}
 */


const string Dias_31 = "Este Mês tem 31 dias!";
const string Dias_30 = "Este mês tem 30 dias!";
const string Dias_28 = "Este mês tem 28 dias!";
const string MES_INVALIDO = "Este mês não existe!";

Console.WriteLine("Escreva um mês: ");
string mes = Console.ReadLine();


switch (mes.ToUpper())
{
    case "JANEIRO":
    case "MARÇO":
        Console.WriteLine(Dias_31);
        break;

    case "FEVEREIRO":
        Console.WriteLine(Dias_28);
        break;

    case "ABRIL":
        Console.WriteLine(Dias_30);
        break;

    default:
        Console.WriteLine(MES_INVALIDO);    
        break;
}
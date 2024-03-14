using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;


List<Pessoa> hospedes = new List<Pessoa>();

Console.WriteLine ("Quantas pessoas serão cadastradas no sistema?");
int pessoasCadastradas = int.Parse (Console.ReadLine());
Console.WriteLine ("Digite aqui o nome de pessoa por pessoa");
for (int i = 0; i < pessoasCadastradas; i++)
{
    Pessoa x = new Pessoa (nome: Console.ReadLine());
    hospedes.Add (x);
    Console.WriteLine ("Digite o nome do próximo");
}
Console.WriteLine ("");
Reserva reserva = new Reserva(diasReservados: 0);

Suite suite = new Suite(tipoSuite: "", capacidade: 0, valorDiaria: 0);
Console.WriteLine ("Escreva o tipo da suíte que o cliente pretende reservar:");
suite.TipoSuite = Console.ReadLine ();
Console.WriteLine ("Escreva a capacidade da suíte que o cliente pretende reservar:");
suite.Capacidade = int.Parse(Console.ReadLine ());
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);
Console.WriteLine ("Escreva o valor da diária da suíte que o cliente pretende reservar:");
suite.ValorDiaria = int.Parse(Console.ReadLine ());
reserva.CadastrarSuite(suite);




Console.WriteLine ("\nEscreva a quantidade de dias que o cliente pretende reservar:");
reserva.DiasReservados = int.Parse(Console.ReadLine ());


if (reserva.DiasReservados >= 10)
{
    Console.WriteLine($"Reserva concluída na suíte {suite.TipoSuite}, segue abaixo quantidade de hóspede na suite e o valor da reserva:");
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor da reserva + 10% de desconto por 10 ou mais dias de reserva: {reserva.CalcularValorReserva()}");
}
else
{
    Console.WriteLine($"Reserva concluída na suíte {suite.TipoSuite}, segue abaixo quantidade de hóspede na suite e o valor da reserva:");
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor da reserva: {reserva.CalcularValorReserva()}");
}
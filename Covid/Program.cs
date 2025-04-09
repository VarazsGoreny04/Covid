namespace Covid;

internal class Program
{
	static void Main()
	{
		Console.WriteLine("Járvány van. Maradj otthon!");

		Vakcina a = new Astrazeneca(new DateOnly(2025, 10, 1));
		Vakcina m = new Moderna(new DateOnly(2025, 9, 1));
		Vakcina p = new Moderna(new DateOnly(2025, 1, 1));

		Paciens peti = new("69420");

		Oltohely heimpal = new("Heimpál gyermekkórház");

		heimpal.Beszerez(a);
		heimpal.Beszerez(m);
		heimpal.Beszerez(p);

		heimpal.Regisztral(peti);

		heimpal.Beolt(peti, "pfizer");
		heimpal.Beolt(peti, "moderna");

		Console.WriteLine(heimpal.HanyanKettot());
		Console.WriteLine(peti.HanyOltas());
	}
}
using System;

class Program {
    static void Main(string[] args) {

        List<TaxPayer> list = new List<TaxPayer>();

        Console.Write("Quantos contribuintes você vai digitar? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            Console.WriteLine();
            Console.WriteLine($"Digite os dados do {i + 1}o contribuinte:");
            Console.Write("Renda anual com salário: ");
            double salaryIncome = double.Parse(Console.ReadLine());
            Console.Write("Renda anual com prestação de serviço: ");
            double servicesIncome = double.Parse(Console.ReadLine());
            Console.Write("Renda anual com ganho de capital: ");
            double capitalIncome = double.Parse(Console.ReadLine());
            Console.Write("Gastos médicos: ");
            double healthSpending = double.Parse(Console.ReadLine());
            Console.Write("Gastos educacionais: ");
            double educationSpending = double.Parse(Console.ReadLine());

            TaxPayer taxPayer = new TaxPayer(salaryIncome, servicesIncome, capitalIncome, healthSpending, educationSpending);
            list.Add(taxPayer);
        }

        Console.WriteLine();
        for (int i = 0; i < n; i++) {
            Console.WriteLine();
            Console.WriteLine($"Resumo do {i + 1}o contribuinte:");
            Console.WriteLine($"Imposto Bruto Total: {list[i].GrossTax():F2}");
            Console.WriteLine($"Abatimento.........: {list[i].TaxRebate():F2}");
            Console.WriteLine($"Imposto Devido.....: {list[i].NetTax():F2}");
        }
    }
}
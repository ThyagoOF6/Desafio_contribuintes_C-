using System;
using System.Collections.Generic;

namespace Course {
    public class TaxPayer
{
    private double SalaryIncome { get; set; }
    private double ServicesIncome { get; set; }
    private double CapitalIncome { get; set; }
    private double HealthSpending { get; set; }
    private double EducationSpending { get; set; }

    public TaxPayer(double salaryIncome, double servicesIncome, double capitalIncome, double healthSpending, double educationSpending)
    {
        SalaryIncome = salaryIncome;
        ServicesIncome = servicesIncome;
        CapitalIncome = capitalIncome;
        HealthSpending = healthSpending;
        EducationSpending = educationSpending;
    }

    public double GetSalaryIncome()
    {
        return SalaryIncome;
    }

    public void SetSalaryIncome(double salaryIncome)
    {
        SalaryIncome = salaryIncome;
    }

    public double GetServicesIncome()
    {
        return ServicesIncome;
    }

    public void SetServicesIncome(double servicesIncome)
    {
        ServicesIncome = servicesIncome;
    }

    public double GetCapitalIncome()
    {
        return CapitalIncome;
    }

    public void SetCapitalIncome(double capitalIncome)
    {
        CapitalIncome = capitalIncome;
    }

    public double GetHealthSpending()
    {
        return HealthSpending;
    }

    public void SetHealthSpending(double healthSpending)
    {
        HealthSpending = healthSpending;
    }

    public double GetEducationSpending()
    {
        return EducationSpending;
    }

    public void SetEducationSpending(double educationSpending)
    {
        EducationSpending = educationSpending;
    }

    public double SalaryTax()
    {
        double salary = SalaryIncome / 12.0;
        double percentage = 0;

        if (salary < 3000.00)
        {
            percentage = 0.00;
        }
        else if (salary <= 5000.00)
        {
            percentage = 0.1;
        }
        else
        {
            percentage = 0.2;
        }
        return 12 * (salary * percentage);
    }

    public double ServicesTax()
    {
        return ServicesIncome * 0.15;
    }

    public double CapitalTax()
    {
        return CapitalIncome * 0.2;
    }

    public double GrossTax()
    {
        return SalaryTax() + ServicesTax() + CapitalTax();
    }

    public double TaxRebate()
    {
        double deductibleExpense = HealthSpending + EducationSpending;
        double maximumDeductible = GrossTax() * 0.3;
        double rebates = 0;

        if (deductibleExpense > maximumDeductible)
        {
            rebates = maximumDeductible;
        }
        else
        {
            rebates = deductibleExpense;
        }
        return rebates;
    }

    public double NetTax()
    {
        return GrossTax() - TaxRebate();
    }
}
}
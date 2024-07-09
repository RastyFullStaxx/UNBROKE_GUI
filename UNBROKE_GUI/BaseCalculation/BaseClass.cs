using System;

namespace UNBROKE_GUI.BaseCalculation
{
    internal class BaseClass
    {
        // Attributes
        private decimal totalBudget;
        private decimal fixedExpenses;
        private decimal rent;
        private decimal food;
        private decimal nonFixedExpenses;
        private decimal needs;
        private decimal bills;
        private decimal transportation;
        private decimal supplies;
        private decimal others;
        private decimal wants;
        private decimal entertainment;
        private decimal clothing;
        private decimal savings;

        // Constructor to initialize with TotalBudget, Rent, and Food
        public BaseClass(decimal totalBudget, decimal rent, decimal food)
        {
            this.totalBudget = totalBudget; 
            this.rent = rent;
            this.food = food;

            /*
             * totalBudget is the KNAPSACK
             * Expenses are the items
             *      their amount is the value
             *      their percentages is the weight
             */

            // Calculate fixed expenses
            fixedExpenses = rent + food;

            // Calculate non-fixed expenses
            nonFixedExpenses = totalBudget - fixedExpenses;

            // Calculate needs, wants, and savings
            needs = nonFixedExpenses * 0.50m;
            wants = nonFixedExpenses * 0.30m;
            savings = nonFixedExpenses * 0.20m;

            // Calculate individual categories within needs and wants
            bills = nonFixedExpenses * 0.20m;
            transportation = nonFixedExpenses * 0.10m;
            supplies = nonFixedExpenses * 0.10m;
            others = nonFixedExpenses * 0.10m;
            entertainment = nonFixedExpenses * 0.15m;
            clothing = nonFixedExpenses * 0.15m;
        }

        // Properties to access calculated values
        public decimal TotalBudget => totalBudget;
        public decimal FixedExpenses => fixedExpenses;
        public decimal Rent => rent;
        public decimal Food => food;
        public decimal NonFixedExpenses => nonFixedExpenses;
        public decimal Needs => needs;
        public decimal Bills => bills;
        public decimal Transportation => transportation;
        public decimal Supplies => supplies;
        public decimal Others => others;
        public decimal Wants => wants;
        public decimal Entertainment => entertainment;
        public decimal Clothing => clothing;
        public decimal Savings => savings;

        // Method to display results
        public void DisplayResults()
        {
            Console.WriteLine($"Total Budget: {TotalBudget:C}");
            Console.WriteLine($"Fixed Expenses: {FixedExpenses:C} (Rent: {Rent:C}, Food: {Food:C})");
            Console.WriteLine($"Total for Non-Fixed Expenses: {NonFixedExpenses:C}");
            Console.WriteLine($"Needs (50%): {Needs:C}");
            Console.WriteLine($"  - Bills (20%): {Bills:C}");
            Console.WriteLine($"  - Transportation (10%): {Transportation:C}");
            Console.WriteLine($"  - Supplies (10%): {Supplies:C}");
            Console.WriteLine($"  - Others (10%): {Others:C}");
            Console.WriteLine($"Wants (30%): {Wants:C}");
            Console.WriteLine($"  - Entertainment (15%): {Entertainment:C}");
            Console.WriteLine($"  - Clothing (15%): {Clothing:C}");
            Console.WriteLine($"Savings (20%): {Savings:C}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNBROKE_GUI.BaseCalculation
{
    internal class BaseClass
    {
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

        // Constructor to initialize with TotalBudget and fixed expenses
        public BaseClass(decimal totalBudget, decimal rent, decimal food)
        {
            this.totalBudget = totalBudget;
            this.rent = rent;
            this.food = food;

            // Calculate fixed expenses
            fixedExpenses = rent + food;

            // Calculate non-fixed expenses
            nonFixedExpenses = totalBudget - fixedExpenses;

            // Calculate needs, wants, and savings
            needs = nonFixedExpenses * 0.50m;
            wants = nonFixedExpenses * 0.30m;
            savings = nonFixedExpenses * 0.20m;

            // Calculate individual categories within needs and wants
            bills = needs * 0.20m;
            transportation = needs * 0.10m;
            supplies = needs * 0.10m;
            others = needs * 0.10m;
            entertainment = wants * 0.15m;
            clothing = wants * 0.15m;
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
    }
}
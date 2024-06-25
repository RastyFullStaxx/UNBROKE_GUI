using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNBROKE_GUI.Enums
{
    public enum ExpenseCategory
    {
        Fix,
        Needs,
        Wants
    }

    public enum ExpenseSubCategory
    {
        Food,
        Rent,
        Bills,
        Transportation,
        Supplies,
        Others,
        Entertainment,
        Clothing
    }

    internal class Enums
    {
        public static List<ExpenseSubCategory> GetSubCategories(ExpenseCategory category)
        {
            switch (category)
            {
                case ExpenseCategory.Fix:
                    return new List<ExpenseSubCategory> { ExpenseSubCategory.Food, ExpenseSubCategory.Rent };
                case ExpenseCategory.Needs:
                    return new List<ExpenseSubCategory> { ExpenseSubCategory.Bills, ExpenseSubCategory.Transportation, ExpenseSubCategory.Supplies, ExpenseSubCategory.Others };
                case ExpenseCategory.Wants:
                    return new List<ExpenseSubCategory> { ExpenseSubCategory.Entertainment, ExpenseSubCategory.Clothing };
                default:
                    throw new ArgumentOutOfRangeException(nameof(category), category, null);
            }
        }
    }
}

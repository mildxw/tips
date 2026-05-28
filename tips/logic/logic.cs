using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tips
{
    public static class logic
    {
        public static double CalculateTip(double bill, double tipPercent)
        {
            if (bill <= 0)
                throw new ArgumentException("Сумма счёта должна быть больше нуля");
            if (tipPercent != 0 && tipPercent != 5 && tipPercent != 10 && tipPercent != 15)
                throw new ArgumentException("Некорректный процент чаевых");

            return bill * tipPercent / 100;
        }

        public static double CalculateTotal(double bill, double tipPercent)
        { 
            double tip = CalculateTip(bill, tipPercent);

            return bill + tip;
        }

        public static double CalculatePerGuest(double bill, int guestsCount, int tipPercent)
        {
            if (bill <= 0)
                throw new ArgumentException("Сумма счёта должна быть больше нуля");
            if (guestsCount <= 0)
                throw new ArgumentException("Количество гостей должно быть больше нуля");

            double total = CalculateTotal(bill, tipPercent);
            return total / guestsCount;
        }

        public static bool IsGroupBill(int guestsCount)
        {
            if (guestsCount <= 0)
                throw new ArgumentException("Количество гостей должно быть больше нуля");

            return guestsCount > 1;
        }
    }
}

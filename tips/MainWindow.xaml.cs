using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace tips
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonCalculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!double.TryParse(textBoxbill.Text, out double bill))
                {
                    MessageBox.Show("Введите корректную сумму счёта", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);

                    return;
                }

                if (!int.TryParse(textBoxGuestsCount.Text, out int guestsCount))
                {
                    MessageBox.Show("Введите корректное количество гостей", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);

                    return;
                }

                int tipPercent = GetSelectedTipPercent();


                double tipAmount = logic.CalculateTip(bill, tipPercent);
                double totalAmount = logic.CalculateTotal(bill, tipPercent);
                double perGuestAmount = logic.CalculatePerGuest(bill, guestsCount, tipPercent);


                string result = $"Сумма счёта: {bill:F2} руб. \n" +
                                $"Чаевые: {tipAmount:F2} руб. ({tipPercent}%) \n" +
                                $"Итоговая сумма: {totalAmount:F2} руб.";

                if (logic.IsGroupBill(guestsCount))
                {
                    result += $"\nКоличество гостей: {guestsCount}\n" +
                              $"С каждого гостя: {perGuestAmount}\n";
                }
                else
                {
                    result += "\nСчёт не делится, так как указан один гость";
                }

                textBlockResult.Text = result;
            }

            catch (ArgumentException ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private int GetSelectedTipPercent()
        {
            if (radioButtonFive.IsChecked == true)
            {
                return 5;
            }

            if (radioButtonTen.IsChecked == true)
            {
                return 10;
            }

            if (radioButtonFifteen.IsChecked == true)
            {
                return 15;
            }

            return 0;
        }
    }
}

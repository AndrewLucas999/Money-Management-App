using System;
using System.Windows;
using InternalLibrary.View_Model;

namespace MoneyManagement;

public partial class DaySpendingUpdate : Window
{
    public WindowViewModel Model { get; set; }
    public DaySpendingUpdate()
    {
        InitializeComponent();
    }

    private void SaveAmountSpent_OnClick(object sender, RoutedEventArgs e)
    {
        // Model.MathsViewModel.DaySpending = Convert.ToDouble(DayAmountSpent.Text) ;
    }
}
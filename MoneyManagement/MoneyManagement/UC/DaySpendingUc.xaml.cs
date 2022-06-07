using System;
using System.Windows;
using System.Windows.Controls;
using InternalLibrary.View_Model;

namespace MoneyManagement.UC;

public partial class DaySpendingUc : UserControl
{
    public DaySpendingUc()
    {
        InitializeComponent();
        DataContextChanged += ChangedDataContext;
    }
    private void ChangedDataContext(object sender, DependencyPropertyChangedEventArgs e)
    {
        Model = (WindowViewModel)DataContext;
    }

    private WindowViewModel Model { get; set; }
    
    /// <summary>
    /// Updates Day spending 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UpdateDaySpentAmount_OnClick(object sender, RoutedEventArgs e)
    {
        Model.MathsViewModel.Maths.DaySpending.AddIndividualAmount(SinglePurchaseText.Text);
        DaySpendingLabel.Content = Model.MathsViewModel.Maths.DaySpending.TotalAmountSpentToday.ToString();
    }
}
using System;
using System.Reflection;
using System.Windows;
using InternalLibrary.View_Model;
using log4net;

namespace MoneyManagement;

public partial class DaySpendingUpdate : Window
{
    #region Debug / Log

    private static readonly ILog Log =
        LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);

    #endregion
    public WindowViewModel Model { get; set; } = new();
    public DaySpendingUpdate()
    {
        InitializeComponent();
    }

    private void SaveAmountSpent_OnClick(object sender, RoutedEventArgs e)
    {
        Model.MathsViewModel.DaySpending = Convert.ToDouble(DayAmountSpent.Text);
        Log.Debug("Assigned");
        
    }
}
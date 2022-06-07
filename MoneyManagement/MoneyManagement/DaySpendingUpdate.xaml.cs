using System;
using System.Reflection;
using System.Windows;
using InternalLibrary.View_Model;
using log4net;
using MoneyManagement.UC;

namespace MoneyManagement;

public partial class DaySpendingUpdate : Window
{
    #region Debug / Log

    private static readonly ILog Log =
        LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);

    #endregion
    
    
    public DaySpendingUpdate()
    {
        InitializeComponent();
        
    }
    
    
    private void SaveAmountSpent_OnClick(object sender, RoutedEventArgs e)
    {
        // DaySpendingUc daySpendingUc = new DaySpendingUc();
        // Model.MathsViewModel.DaySpending = Convert.ToDouble(DayAmountSpent.Text);
        // daySpendingUc.DaySpendingLabel.Content = Model.MathsViewModel.DaySpending;
        // Log.Debug("Assigned");
        //
    }

    
        
    private void DaySpendingUpdate_OnLoaded(object sender, RoutedEventArgs e)
    {
        DaySpendingUc daySpendingUc = new DaySpendingUc();
        daySpendingUc.DataContext = this;
    }
}
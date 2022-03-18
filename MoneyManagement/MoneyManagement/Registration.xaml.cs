using System.Text.RegularExpressions;
using System.Windows;
using System.Data.SqlClient;

namespace MoneyManagement;

public partial class Registration : Window
{
    public Registration()
    {
        InitializeComponent();
    }

    private void Submit_OnClick(object sender, RoutedEventArgs e)
    {
        if (TextBoxEmail.Text.Length == 0)
        {
            TextBoxEmail.Focus();
        }
        else if (!Regex.IsMatch(TextBoxEmail.Text,
                     @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
        {
            TextBoxEmail.Select(0, TextBoxEmail.Text.Length);
            TextBoxEmail.Focus();
        }
        else
        {
            string email = TextBoxEmail.Text;
            string password = PasswordBox1.Password;
            SqlConnection con = new SqlConnection();
            con.Open();

            SqlCommand cmd =
                new SqlCommand(
                    "SELECT * FROM Registration WHERE Email ='" + email + "' and Password='" + password + "'", con);
        }
    }
}
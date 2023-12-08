namespace Presentation.Views
{
    using System;
    using System.Configuration;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media.Animation;
    using MySqlConnector;

    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }


        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = txtUser.Text;
            string password = txtPass.Password;

            // Authenticate user against MySQL database
            if (AuthenticateUser(login, password))
            {
                // Show a success message
                MessageBox.Show("Login successful!");

                // Fade out animation
                var fadeOutAnimation = new DoubleAnimation
                {
                    From = 1.0,
                    To = 0.0,
                    Duration = TimeSpan.FromSeconds(0.5)
                };

                fadeOutAnimation.Completed += (s, _) =>
                {
                    // Animation completed, navigate to the next window
                    var mainView = new MainView();
                    mainView.Show();

                    // Close the current login window
                    this.Close();
                };

                this.BeginAnimation(UIElement.OpacityProperty, fadeOutAnimation);
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        public bool AuthenticateUser(string login, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["RostikConnection"].ConnectionString))
                {
                    connection.Open();

                    // Use a stored procedure or parameterized query to prevent SQL injection
                    string query = "SELECT COUNT(*) FROM employee WHERE Login = @login AND Password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password); // Use hashed password in a real scenario

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle database connection or query errors
                //txtError.Text = $"Error: {ex.Message}";
                return false;
            }
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Your event handling logic here
            TextBox textBox = (TextBox)sender;
            string newText = textBox.Text;
        }
    }
}

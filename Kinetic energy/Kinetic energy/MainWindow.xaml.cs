using System;
using System.Collections.Generic;
using System.Linq;
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

namespace KineticEnergy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            const double NUM = 0.5;
            int mass = int.Parse(textBox.Text);
            double velocity = double.Parse(textBox1.Text);
            velocity = Math.Pow(velocity, 2);
            double total = finalAnswer(velocity, mass, NUM);
            label.Content = total;
        }
         private double finalAnswer(double velocity, int mass, double NUM)
    {
           return velocity * NUM * mass;
            
    }
                
}
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace HaveFun
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double height = -350;

        public double cmbBoxHeight = 25;
        public double cmbBoxWidth = 100;
        public double cmbBoxDistance = 25 + 35;

        public List<ComboBox> comboBoxes = new List<ComboBox>();

        public MainWindow()
        {
            InitializeComponent();
            SetButtons();
        }

        private void SetButtons()
        {
            if (comboBoxes.Count == 0)
            {
                buttonMinus.IsEnabled = false;
            }
            else
            {
                buttonMinus.IsEnabled = true;
            }
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            var newComboBox = new ComboBox();
            newComboBox.Height = cmbBoxHeight;
            newComboBox.Width = cmbBoxWidth;

            var thickness = new Thickness(-200, height, 00, 00);
            newComboBox.Margin = thickness;

            height = height + cmbBoxDistance;

            comboBoxes.Add(newComboBox);
            grid.Children.Add(newComboBox);

            SetButtons();
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            var lastComboBox = comboBoxes.Last();
            comboBoxes.Remove(lastComboBox);
            grid.Children.Remove(lastComboBox);

            height = height - cmbBoxDistance;

            SetButtons();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //MessageBox.Show("You clicked on!");
        //    var random = new Random();
        //    var width = random.Next(100, 251);
        //    buttonClick.Width = width;
        //    //Countdown();
        //    var newButton = new Button();
        //    newButton.Height = 25;
        //    newButton.Width = width;
        //    newButton.Content = width.ToString();
        //    newButton.Margin = new Thickness(random.Next(10,300), random.Next(10, 100), random.Next(10, 300), random.Next(10, 600));
        //    grid.Children.Add(newButton);
        //}

        //private void Countdown()
        //{
        //    TimeSpan timeSpan = new TimeSpan(0, 0, 2);
        //    for (int i = 1; i < 4; i++)
        //    {
        //        labelCounter.Content = i.ToString();
        //        Thread.Sleep(timeSpan);

        //    }
        //}
    }
}

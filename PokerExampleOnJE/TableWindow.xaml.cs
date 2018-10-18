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
using System.Windows.Shapes;

namespace PokerExampleOnJE
{
    /// <summary>
    /// Interaction logic for TableWindow.xaml
    /// </summary>
    public partial class TableWindow : Window
    {
        public TableWindow()
        {
           
            InitializeComponent();
            Title = Title + RoomManager.Instance.Rooms.Last().Id.ToString();
            redPLlabel.Content = RoomManager.Instance.GetActiveTable().GetLast().Name;
            greenPLlabel.Content = RoomManager.Instance.GetActiveTable().GetElement(RoomManager.Instance.Rooms.Last().players.Count - 1).Name;
            //Ellipse el = new Ellipse();
            //el.Width = 50;
            //el.Height = 50;
            //el.VerticalAlignment = VerticalAlignment.Top;
            //el.Fill = Brushes.Green;
            //el.Stroke = Brushes.Red;
            //el.StrokeThickness = 3;
            //stack1.Children.Add(el);
        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--)
            //    App.Current.Windows[intCounter].Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

using PokerCORE;
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
    /// Interaction logic for DebugWindow.xaml
    /// </summary>
    public partial class DebugWindow : Window
    {
        public DebugWindow()
        {


            InitializeComponent();
            textBox.Clear();
            textBox.AppendText(GameManager.Instance.Ready.ToString() + "\r\n");
            textBox.AppendText(RoomManager.Instance.Rooms.Count.ToString() + "\r\n");
            textBox.AppendText(PlayerManager.Instance.Players.Count.ToString() + "\r\n");
        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
           
           
        }
    }
}

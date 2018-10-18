using PokerCORE;
using System.Linq;
using System.Windows;

namespace PokerExampleOnJE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
   
        GameManager.Instance.Setup();
    
            InitializeComponent();
            int g = 10;
          
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            DebugWindow dw = new DebugWindow();
            dw.Show();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            PlayerManager.Instance.CreatePlayer(RoomManager.Instance.GetActiveTable()._stk.highvalue * 500, RoomManager.Instance.GetActiveTable()._stk.highvalue * 500, playerNametextBox.Text, GetPlayerType());
            playerslist.ItemsSource = PlayerManager.Instance.ObservablePlayers;
        }
        private void playerslist_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
        private PokerPlayer.PT GetPlayerType()
        {
            switch (PTtypecheckBox.IsChecked)
            {
                case true: return PokerPlayer.PT.COMP;
                case false: return PokerPlayer.PT.HUMAN;
            }
            return PokerPlayer.PT.HUMAN;
        }
        private void Window_Initialized(object sender, System.EventArgs e)
        {
            playerslist.ItemsSource = PlayerManager.Instance.ObservablePlayers;
           // Hide();
        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
          
        }
    }
}

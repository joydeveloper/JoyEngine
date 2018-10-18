using JoyEngine;
using MahApps.Metro.Controls;
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

namespace CartoonLifeWFP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            try
            {
                AppManager.Instance.SetStateAutomat(new CartoonAppState());
                AppManager.Instance.StateControl.SetState(AppState.EnumState.Mainmenu);
               // this.GetChildObjects();
            }
            catch (Exception e)
            {
               MessageBox.Show(e.ToString());
            }
            //AppManager
            InitializeComponent();          
        }

        private void new_game_button_Click(object sender, RoutedEventArgs e)
        {
            ((WPFUIManager)AppManager.Instance.managers[CartoonLifeWPFCoreActions.UI_MANAGER].GetManager()).Setup(this);
        }

        private void option_button_Click(object sender, RoutedEventArgs e)
        {
            AppManager.Instance.StateControl.SetState(AppState.EnumState.Options);
        }

        private void exit_but_Click(object sender, RoutedEventArgs e)
        {
            AppManager.Instance.StateControl.SetState(AppState.EnumState.End);
        }

        private void continue_game_button_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gw = new GameWindow();
            gw.Show();
        }

        private void faststart_button_Click(object sender, RoutedEventArgs e)
        {
          //.BindingTest(this);
        }
        protected void BorderEnter(object sender, MouseEventArgs e)
        {
            Border bord = e.Source as Border;
            bord.BorderBrush = Brushes.GreenYellow;
        }
        protected void BorderLeave(object sender, MouseEventArgs e)
        {
            Border bord = e.Source as Border;
            bord.BorderBrush = Brushes.Yellow;
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                ((WPFUIManager)AppManager.Instance.managers[CartoonLifeWPFCoreActions.UI_MANAGER].GetManager()).Setup(this);
                //  GameTypeLabel lab_GameTypeL = new GameTypeLabel();
                //  Binding myBinding = new Binding("Content_Text");
                //  myBinding.Source = lab_GameTypeL;
                //  gametype_label.SetBinding(ContentProperty, myBinding);
                ////  ((WPFUIManager)AppManager.Instance.managers[CartoonLifeWPFCoreActions.UI_MANAGER].GetManager()).CreateNewGamePanel(this);
                //  l_gametype_but.Click += new RoutedEventHandler(lab_GameTypeL.SwitchL);
                //  r_gametype_but.Click += new RoutedEventHandler(lab_GameTypeL.SwitchR);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (player_control_toggle.IsChecked.Value)
            {
                player_control_toggle.Content = "C";
            }
            else
            {
                player_control_toggle.Content = "H";
            }

        }

    }
}

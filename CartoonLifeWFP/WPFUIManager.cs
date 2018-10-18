using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;
using static JoyEngine.ProcessManager;

namespace CartoonLifeWFP
{
    public class WPFUIManager : JoyEngine.UIManager<SubWindow>
    {
        public const int GAME_SETUP_PANEL = 0;
        public const int FGAME_PANEL = 1;
        public const int OPTIONS_PANEL = 2;
        public const int NEWS_PANEL = 3;
        internal Window _win;
        internal Director sbwDirector = new Director();
        public void Setup(MainWindow win)
        {
            //_win = win;
            //sbwDirector.SetBuilder(new NewGameSetupPanel());
            //NewGame_Window ng_w = new NewGame_Window(win.MainGrid);
            //win.MainGrid.Children.Add(ng_w);
            //sbwDirector.Construct();
            //Label l = (Label)UIElementFactory.CreateUIElement(UIElementFactory.LABEL, "H2_Col_Label_1");
            //l.Content = "dddddddddddddddddddddddddd";
            //Grid NewGameGrid = new Grid();
            //NewGameGrid.Children.Add(l);
            //win.MainGrid.Children.Add(NewGameGrid);
            //NewGameGrid.Name = "griddd";
          //  MessageBox.Show(NewGameGrid.Name);
          //  BindingSetup();
        }
        public void BindingSetup()
        {
            GameTypeLabel lab_GameTypeL = new GameTypeLabel();
            Binding myBinding = new Binding("Content_Text");
            myBinding.Source = lab_GameTypeL;
            ((Label)_win.FindName("gametype_label")).SetBinding(ContentControl.ContentProperty, myBinding);
            ((Button)_win.FindName("l_gametype_but")).Click += new RoutedEventHandler(lab_GameTypeL.SwitchL);
            ((Button)_win.FindName("r_gametype_but")).Click += new RoutedEventHandler(lab_GameTypeL.SwitchR);
        }
    }
    internal class NewGame_Window : SubWindow
    {
        DockPanel main_menu_dock = new DockPanel();
        string[] elementscaption = { "New Game", "PlayerName", "PlayersList", "Start" };
        public NewGame_Window()
        {

        }
        private void CloseNewGamePanel(object sender, EventArgs e)
        {
            main_menu_dock.Visibility = Visibility.Collapsed;
        }
        internal void ShowNewGamePanel()
        {
            main_menu_dock.Visibility = Visibility.Visible;
        }
        public override void SetupWindow()
        {
            throw new NotImplementedException();
        }
    }
    internal class OptionPanel
    {
        internal string B1()
        {
            return "Subsystem B, Method B1\n";
        }
    }
    public class SubWindowController {
        private Label header;
        private Button l_but;
        private Button r_but;   
        private List<SubWindow> _subwindows = new List<SubWindow>();
        public List<SubWindow> SubWindows
        {
            get
            {
                return _subwindows;
            }
        }
    }
    public abstract class SubWindow:Panel
    {   
        internal bool _isCreated;
        public bool isCreated
        {
            get
            {
                return _isCreated;
            }
        }
        string[] elementscaption;
        public abstract void SetupWindow();
        public virtual void OnDestroy() { }
        public virtual void ShowWindow() {

        }
        public virtual void HideWindow() { }
        public virtual void BindingElements() { }
        public virtual void CreateSubWindow()
        {
            if (!isCreated)
            {
                SetupWindow();
                ShowWindow();
            }
            else
            {
                ShowWindow();
            }
        }
    }
    public class Director
    {
        PanelBuilder builder;
        public Director(PanelBuilder builder)
        {
            this.builder = builder;
        }
        public Director()
        {

        }
        public void SetBuilder(PanelBuilder builder)
        {
            this.builder = builder;
        }
        public virtual Panel Construct()
        {
            Panel panel =builder.CreateParentPanel();

            builder.BuildHeader();
            builder.BuildBody();
            builder.BuildFooter();
            return panel;
        }
    }
    public abstract class PanelBuilder
    {
        public List<UIElement> parts = new List<UIElement>();
        public abstract Panel CreateParentPanel();
        public abstract void BuildHeader();
        public abstract void BuildBody();
        public abstract void BuildFooter();
        public static FrameworkElement FastFE(string style, string name)
        {
            FrameworkElement fe = new FrameworkElement();
            fe.Style = (Style)Application.Current.FindResource(style);
            fe.Name = name;
            return fe;
        }
    }
    public class Sprint_Game_Setup : PanelBuilder
    {
        public override void BuildBody()
        {
            throw new NotImplementedException();
        }

        public override void BuildFooter()
        {
            throw new NotImplementedException();
        }
     public override void BuildHeader()
        {
            throw new NotImplementedException();
        }
       public override Panel CreateParentPanel()
        {
            throw new NotImplementedException();
        }
    }
    public class NewGameSetupPanel : PanelBuilder
    {
        public override Panel CreateParentPanel()
        {
            StackPanel sp =(StackPanel)FastFE("", "NewGameHeader");
            sp.Orientation = Orientation.Horizontal;
            sp.Height = 55;
            sp.VerticalAlignment = VerticalAlignment.Top;
            sp.Background = Brushes.Yellow;
 
            return sp;
        }
        public override void BuildHeader()
        {

         //   Label l = (Label)UIElementFactory.CreateUIElement(UIElementFactory.LABEL, "H2_Col_Label_1");
       //     l.Content = l.Name;
      //      Grid NewGameGrid = new Grid();
       //     NewGameGrid.Children.Add(l);
        }
        public override void BuildBody()
        {

        }
        public override void BuildFooter()
        {

        }
    }
    public class GameTypeLabel : INotifyPropertyChanged
    {
        private string name;
        public event PropertyChangedEventHandler PropertyChanged;
        public JoyEngine.Switcher2way<string> _switcher = new JoyEngine.Switcher2way<string>();
        public GameTypeLabel()
        {
            _switcher.ObjectArray.Add("Sprint");
            _switcher.ObjectArray.Add("Treasure Hunt");
            _switcher.ObjectArray.Add("Circle");
            _switcher.ObjectArray.Add("LifeSimulation");
            name = _switcher.GetActiveObject();
        }
        public string Content_Text
        {
            get { return name; }
            set
            {
                name = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Content_Text");
            }
        }
        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        public void SwitchL(object sender, EventArgs e)
        {
            Content_Text = _switcher.SwitchLeft();
        }
        public void SwitchR(object sender, EventArgs e)
        {
            Content_Text = _switcher.SwitchRight();
        }
    }

    public class FastFE : Panel
    {
         public FastFE(string style, string name)
        {
            if (style!=string.Empty)
            Style = (Style)Application.Current.FindResource(style);
            Name = name;
        }

    }
}

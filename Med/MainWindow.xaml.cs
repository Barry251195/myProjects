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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
namespace Med
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

public partial class MainWindow : Window
    { DateTime dayWeek = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
        DateTime dayNow = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
        byte R, G, B;

        private void datePick_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            dayWeek = datePick.SelectedDate.Value;
            FillWeek();
        }
        private void testBtn_Click(object sender, RoutedEventArgs e)
        {
            NewPerson np = new NewPerson();
            np.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dayWeek = dayNow;
            FillWeek();
            fillFromJson();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //fillFromJson();
            Label lbl = new Label();
            lbl.Content = "111";
            stackFri.Children.Add(lbl);
        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            dayWeek = dayWeek.Add(TimeSpan.FromDays(7));
     
            FillWeek();
            fillFromJson();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            dayWeek = dayWeek.Add(TimeSpan.FromDays(-7));
          
            FillWeek();
            fillFromJson();
           
        }

        public MainWindow()
        {     
            InitializeComponent();
            FillWeek();
            fillFromJson();
           
        }

        public void FillWeek()
        {
            gridMain.Background = new SolidColorBrush(Color.FromRgb(210, 210, 255));
            Control[] days = new[] { mon, tue, wed, thurs, fri, sat, sun };
            foreach( var day in days)
            {
                day.Background = new LinearGradientBrush(Color.FromRgb(210, 210, 255), Color.FromRgb(255, 255, 255), new Point(0.5, 0), new Point(0.5, 1));
            }
            switch (dayWeek.DayOfWeek.ToString())
            {
                case "Monday":
                    lbSun.Content = dayWeek.Date.AddDays(6).ToShortDateString();
                    lbSat.Content = dayWeek.Date.AddDays(5).ToShortDateString();
                    lbFri.Content = dayWeek.Date.AddDays(4).ToShortDateString();
                    lbThu.Content = dayWeek.Date.AddDays(3).ToShortDateString();
                    lbWed.Content = dayWeek.Date.AddDays(2).ToShortDateString();
                    lbTue.Content = dayWeek.Date.AddDays(1).ToShortDateString();
                    lbMon.Content = dayWeek.Date.ToShortDateString();
                    mon.Background = new LinearGradientBrush(Color.FromRgb(128, 139, 255), Color.FromRgb(255, 255, 255), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                case "Tuesday":
                    lbSun.Content = dayWeek.Date.AddDays(5).ToShortDateString();
                    lbSat.Content = dayWeek.Date.AddDays(4).ToShortDateString();
                    lbFri.Content = dayWeek.Date.AddDays(3).ToShortDateString();
                    lbThu.Content = dayWeek.Date.AddDays(2).ToShortDateString();
                    lbWed.Content = dayWeek.Date.AddDays(1).ToShortDateString();
                    lbTue.Content = dayWeek.Date.ToShortDateString();
                    lbMon.Content = dayWeek.Date.AddDays(-1).ToShortDateString();
                    tue.Background = new LinearGradientBrush(Color.FromRgb(128, 139, 255), Color.FromRgb(255, 255, 255), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                case "Wednesday":
                    lbSun.Content = dayWeek.Date.AddDays(4).ToShortDateString();
                    lbSat.Content = dayWeek.Date.AddDays(3).ToShortDateString();
                    lbFri.Content = dayWeek.Date.AddDays(2).ToShortDateString();
                    lbThu.Content = dayWeek.Date.AddDays(1).ToShortDateString();
                    lbWed.Content = dayWeek.Date.ToShortDateString();
                    lbTue.Content = dayWeek.Date.AddDays(-1).ToShortDateString();
                    lbMon.Content = dayWeek.Date.AddDays(-2).ToShortDateString();
                    wed.Background = new LinearGradientBrush(Color.FromRgb(128, 139, 255), Color.FromRgb(255, 255, 255), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                case "Thursday":
                    lbSun.Content = dayWeek.Date.AddDays(3).ToShortDateString();
                    lbSat.Content = dayWeek.Date.AddDays(2).ToShortDateString();
                    lbFri.Content = dayWeek.Date.AddDays(1).ToShortDateString();
                    lbThu.Content = dayWeek.Date.ToShortDateString();
                    lbWed.Content = dayWeek.Date.AddDays(-1).ToShortDateString();
                    lbTue.Content = dayWeek.Date.AddDays(-2).ToShortDateString();
                    lbMon.Content = dayWeek.Date.AddDays(-3).ToShortDateString();
                    thurs.Background = new LinearGradientBrush(Color.FromRgb(128, 139, 255), Color.FromRgb(255, 255, 255), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                case "Friday":
                    lbSun.Content = dayWeek.Date.AddDays(2).ToShortDateString();
                    lbSat.Content = dayWeek.Date.AddDays(1).ToShortDateString();
                    lbFri.Content = dayWeek.Date.ToShortDateString();
                    lbThu.Content = dayWeek.Date.AddDays(-1).ToShortDateString();
                    lbWed.Content = dayWeek.Date.AddDays(-2).ToShortDateString();
                    lbTue.Content = dayWeek.Date.AddDays(-3).ToShortDateString();
                    lbMon.Content = dayWeek.Date.AddDays(-4).ToShortDateString();
                    fri.Background = new LinearGradientBrush(Color.FromRgb(128, 139, 255), Color.FromRgb(255, 255, 255), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                case "Saturday":
                    lbSun.Content = dayWeek.Date.AddDays(1).ToShortDateString();
                    lbSat.Content = dayWeek.Date.ToShortDateString();
                    lbFri.Content = dayWeek.Date.AddDays(-1).ToShortDateString();
                    lbThu.Content = dayWeek.Date.AddDays(-2).ToShortDateString();
                    lbWed.Content = dayWeek.Date.AddDays(-3).ToShortDateString();
                    lbTue.Content = dayWeek.Date.AddDays(-4).ToShortDateString();
                    lbMon.Content = dayWeek.Date.AddDays(-5).ToShortDateString();
                    sat.Background = new LinearGradientBrush(Color.FromRgb(128, 139, 255), Color.FromRgb(255, 255, 255), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                case "Sunday":
                    lbSun.Content = dayWeek.Date.ToShortDateString();
                    lbSat.Content = dayWeek.Date.AddDays(-1).ToShortDateString();
                    lbFri.Content = dayWeek.Date.AddDays(-2).ToShortDateString();
                    lbThu.Content = dayWeek.Date.AddDays(-3).ToShortDateString();
                    lbWed.Content = dayWeek.Date.AddDays(-4).ToShortDateString();
                    lbTue.Content = dayWeek.Date.AddDays(-5).ToShortDateString();
                    lbMon.Content = dayWeek.Date.AddDays(-6).ToShortDateString();
                    sun.Background = new LinearGradientBrush(Color.FromRgb(128, 139, 255), Color.FromRgb(255, 255, 255), new Point(0.5, 0), new Point(0.5, 1));
                    break;
            }
        }

        public void fillFromJson()
        {
            JObject readJson = new JObject();
            var jsonFile = File.ReadAllText("person.json");
            var json = JsonConvert.DeserializeObject(jsonFile);
            readJson.Merge(json);
            List<UIElement> rect = new List<UIElement>();
            foreach (UIElement a in grid.Children) rect.Add(a);
            stackMon.Children.Clear();
            stackTue.Children.Clear();
            stackWed.Children.Clear();
            stackThurs.Children.Clear();
            stackFri.Children.Clear();
            stackSat.Children.Clear();
            stackSun.Children.Clear();


            foreach (var key in readJson)
            {
                

                if (key.Key.Remove(key.Key.Length - 5, 5).ToString() == lbMon.Content.ToString())
                {
                    Label lbl = new Label();
                    lbl.MouseDown += lblClick;
                    lbl.Content = key.Key.Remove(0, 10) + " ";
                    lbl.FontSize = 16;
                    string val ="";
                    foreach (var value in key.Value)
                    {
                        val += value + " ";
                    }
                    lbl.Content += val;
                    stackMon.Children.Add(lbl);
                }
           
                if (key.Key.Remove(key.Key.Length - 5, 5).ToString() == lbTue.Content.ToString())
                {
                    Label lbl = new Label();
                    lbl.MouseDown += lblClick;
                    lbl.FontSize = 16;
                    lbl.Content = key.Key.Remove(0, 10) + " ";
                    string val = "";
                    foreach (var value in key.Value)
                    {
                        val += value + " ";
                    }
                    lbl.Content += val;
                    stackTue.Children.Add(lbl);
                }
               
                if (key.Key.Remove(key.Key.Length - 5, 5).ToString() == lbWed.Content.ToString())
                {
                    Label lbl = new Label();
                    lbl.MouseDown += lblClick;
                    lbl.FontSize = 16;
                    lbl.Content = key.Key.Remove(0, 10) + " ";
                    string val = "";
                    foreach (var value in key.Value)
                    {
                        val += value + " ";
                    }
                    lbl.Content += val;
                    stackWed.Children.Add(lbl);
                
                }
               
                if (key.Key.Remove(key.Key.Length - 5, 5).ToString() == lbThu.Content.ToString())
                {
                    Label lbl = new Label();
                    lbl.MouseDown += lblClick;
                    lbl.FontSize = 16;
                    lbl.Content = key.Key.Remove(0, 10) + " ";
                    string val = "";
                    foreach (var value in key.Value)
                    {
                        val += value + " ";
                    }
                    lbl.Content += val;
                    stackThurs.Children.Add(lbl);
                    
                }
               
                if (key.Key.Remove(key.Key.Length - 5, 5).ToString() == lbFri.Content.ToString())
                {
                    Label lbl = new Label();
                    lbl.MouseDown += lblClick;
                    lbl.FontSize = 16;
                    lbl.Content = key.Key.Remove(0, 10) + " ";
                    string val = "";
                    foreach (var value in key.Value)
                    {
                        val += value + " ";
                    }
                    lbl.Content += val;
                    stackFri.Children.Add(lbl);
                }
                
                if (key.Key.Remove(key.Key.Length - 5, 5).ToString() == lbSat.Content.ToString())
                {
                    Label lbl = new Label();
                    lbl.MouseDown += lblClick;
                    lbl.FontSize = 16;
                    lbl.Content = key.Key.Remove(0, 10) + " ";
                    string val = "";
                    foreach (var value in key.Value)
                    {
                        val += value + " ";
                    }
                    lbl.Content += val;
                    stackSat.Children.Add(lbl);
                }
               
                if (key.Key.Remove(key.Key.Length - 5, 5).ToString() == lbSun.Content.ToString())
                {
                    Label lbl = new Label();
                    lbl.MouseDown += lblClick;
                    lbl.FontSize = 16;
                    lbl.Content = key.Key.Remove(0, 10) + " ";
                    string val = "";
                    foreach (var value in key.Value)
                    {
                        val += value + " ";
                    }
                    lbl.Content += val;
                    stackSun.Children.Add(lbl);
                }
               
            }
            
        }
       

        private void lblClick(object sender, MouseButtonEventArgs e)
        {
            var jsonFile = File.ReadAllText("person.json");      
            ShowPers sh = JsonConvert.DeserializeObject<ShowPers>(jsonFile);
         
               
            if (sender is Label lbl)
            {
                ShowPers shPers = new ShowPers();
                string[] lab = lbl.Content.ToString().Split();
                Dictionary<string, string[]> arrFromJson = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(jsonFile);
                foreach (var v in arrFromJson)
                {
                    if ((v.Value[0] == lab[1]) && (v.Value[1] == lab[2]))
                    {
                        //shPers.DateFirst = (v.Key.Remove(v.Key.Length - 5, 5));
                        shPers.DateFirst = v.Key;
                        shPers.arr = v.Value;
                    }
                };
                shPers.Show();
                shPers.Focus();
            }
        }

        private void TabControl_MouseEnter(object sender, MouseEventArgs e)
        {
            fillFromJson();
            FillWeek();
        }

        private void mw_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void contextLabel(object sender, MouseButtonEventArgs e)
        {
            var jsonFile = File.ReadAllText("person.json");
            ShowPers sh = JsonConvert.DeserializeObject<ShowPers>(jsonFile);


            if (sender is Label lbl)
            {
                ShowPers shPers = new ShowPers();
                string[] lab = lbl.Content.ToString().Split();
                Dictionary<string, string[]> arrFromJson = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(jsonFile);
                foreach (var v in arrFromJson)
                {
                    if ((v.Value[0] == lab[1]) && (v.Value[1] == lab[2]))
                    {
                        //shPers.DateFirst = (v.Key.Remove(v.Key.Length - 5, 5));
                        shPers.DateFirst = v.Key;
                        shPers.arr = v.Value;
                    }
                };
                shPers.Show();

            }
        }


    }
    
     /*как вариант значение даты (ключа) тоже записывать в формате словаря с ключом по полю класса для десериализации*/
}

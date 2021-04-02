using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using System.IO;

namespace Med
{
  
    /// <summary>
    /// Логика взаимодействия для ShowPers.xaml
    /// </summary>
    public partial class ShowPers : Window
    {
        public string DateFirst { get; set; }
        public string[] arr { get; set; }

        MainWindow mw = new MainWindow();

        public ShowPers()
        {
            InitializeComponent();
            fillUI();
        }
       
        public void fillUI()
        {
            
            Dispatcher.BeginInvoke(new Action(() =>
          {
               if (arr != null)
              {

                  dateFirst.SelectedDate = Convert.ToDateTime(DateFirst.Remove(DateFirst.Length - 5, 5));
                  timeFirst.Text = DateFirst.Remove(0, 10);
                  tbFirstName.Text = arr[0];
                  tbSecondName.Text = arr[1];
                  dateOfBirth.SelectedDate = Convert.ToDateTime(arr[2]);
                  tbDiagnos.Text = arr[3];
                  dateSecond.SelectedDate = Convert.ToDateTime(arr[4]);
                  this.Focus();
              }
            
             
          }));
           
        }


        JObject fullJson = new JObject();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var jsonFile = File.ReadAllText("person.json");
            Dictionary<string, string[]> arrFromJson = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(jsonFile);
            string date = dateFirst.SelectedDate.ToString();
           // MessageBox.Show(dateOfBirth.SelectedDate.ToString().Remove(dateOfBirth.SelectedDate.ToString().Length - 8, 8)); 
            foreach (var kv in arrFromJson)
            {
                if (kv.Key == date.Remove(date.Length - 8, 8) + timeFirst.Text)
                {
                    kv.Value[0] = tbFirstName.Text;
                    kv.Value[1] = tbSecondName.Text;
                    kv.Value[2] = dateOfBirth.SelectedDate.Value.ToShortDateString();
                    kv.Value[3] = tbDiagnos.Text;
                    kv.Value[4] = dateSecond.SelectedDate.Value.ToShortDateString();
                }
            }
            string jsonF = JsonConvert.SerializeObject(arrFromJson, Formatting.Indented);
           
            File.WriteAllText("person.json", jsonF);
            this.Close();
        }

        private void mwShowPers_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mw.fillFromJson();
            mw.FillWeek();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var jsonFile = File.ReadAllText("person.json");
            Dictionary<string, string[]> arrFromJson = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(jsonFile);
            string date = dateFirst.SelectedDate.ToString();
            string curKey = "";
            foreach (var kv in arrFromJson)
            {
                if (kv.Key == date.Remove(date.Length - 8, 8) + timeFirst.Text)
                {
                    curKey = kv.Key;
                }
            }
            arrFromJson.Remove(curKey);
            string jsonF = JsonConvert.SerializeObject(arrFromJson, Formatting.Indented);
            File.WriteAllText("person.json", jsonF);
            this.Close();
        }
    }
}

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xceed.Wpf.Toolkit;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using MessageBox = System.Windows.MessageBox;

namespace Med
{
    /// <summary>
    /// Логика взаимодействия для NewPerson.xaml
    /// </summary>
    public partial class NewPerson : Window
    {
        JArray array = new JArray();
        JObject date = new JObject();
        MainWindow mw = new MainWindow();
       public JObject fullJson = new JObject();
        public NewPerson()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            array.Clear();
            try
            {
                array.Add(tbFirstName.Text);
                array.Add(tbSecondName.Text);
                array.Add(dateOfBirth.SelectedDate.Value.ToShortDateString());
                array.Add(tbDiagnos.Text);
                array.Add(dateSecond.SelectedDate.Value.ToShortDateString());
                array.Add(timeSecond.Text);
                date[$"{dateFirst.SelectedDate.Value.ToShortDateString() + timeFirst.Text}"] = array;
               
                var jsonFile = File.ReadAllText("person.json");
                var json = JsonConvert.DeserializeObject(jsonFile);
                fullJson.Merge(json);
                try
                {
                    fullJson.Add(dateFirst.SelectedDate.Value.ToShortDateString() + timeFirst.Text, date[$"{dateFirst.SelectedDate.Value.ToShortDateString() + timeFirst.Text}"]);
                    File.WriteAllText("person.json", fullJson.ToString());
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Данное время занято другим пациентом", "Ошибка", MessageBoxButton.OK);
                }
               
            }
            catch
            { 
                    
                MessageBox.Show("Не все поля заполнены!","Ошибка",MessageBoxButton.OK);
            }

            mw.FillWeek();
            mw.fillFromJson();
        

        }


    }
}

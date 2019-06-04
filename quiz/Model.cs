using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace quiz
{
    class Model
    {
       
        List<Pytania> test = new List<Pytania>();
        string JsonPath;
        public void Object(string Id, string pytanie, string odp1, string odp2, string odp3, string odp4, string poprawna)
        {
            //List<Pytania> test = new List<Pytania>();
            Pytania nr1 = new Pytania();
           nr1.id = Id;
            nr1.pytanie = pytanie;
            nr1.odp1 = odp1;
            nr1.odp2 = odp2;
            nr1.odp3 = odp3;
            nr1.odp4 = odp4;
            nr1.poprawna = poprawna;
            test.Add(nr1);
            string output = JsonConvert.SerializeObject(test);
            File.WriteAllText(JsonPath, output);

        }

         public string GetId(int Que)
         {
            
            return test[Que].id;
         }
         public string GetPytanie(int Que)
         {
            
            return test[Que].pytanie;
         }

         public string GetOdp1(int Que)
         {
            
            return test[Que].odp1;
         }
         public string GetOdp2(int Que)
         {
           
            return test[Que].odp2;
         }
         public string GetOdp3(int Que)
         {
            
            return test[Que].odp3;
         }
         public string GetOdp4(int Que)
         {
            
            return test[Que].odp4;
         }
        public string GetCorrect(int Que)
        {

            return test[Que].poprawna;
        }

        public void Edit(int Que)
        
        {
            MessageBox.Show("Edycja pytania");

            test.RemoveAt(Que);     

        }
        public void Load()
        {
            
            test = JsonConvert.DeserializeObject<List<Pytania>>(File.ReadAllText(JsonPath));
        }
        public void CreateFile(string QuizName)
        {
            
            string path = @"C:\Users\marci\Desktop\Test.json";
            string modified = path.Replace("Test", QuizName);
            File.Create(modified);
    }
            public void ChoseFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                 JsonPath = ofd.FileName;
            }
        }
    }
}

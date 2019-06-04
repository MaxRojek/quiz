using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace quiz
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region implementacja IView
       public string Id
        {
            get
            {

                return textBox1.Text.ToString(); 
            }
            set
            {

            }
        }
        public string Pytanie
        {
            get
            {

                return textBox1.Text.ToString();
            }
            set
            {
                textBox1.Clear();
                textBox1.Text = value;
            }
        }
        public string Odp1
        {
            get
            {

                return textBox2.Text.ToString();
            }
            set
            {
                textBox2.Clear();
                textBox2.Text = value;
            }
        }
        public string Odp2
        {
            get
            {

                return textBox3.Text.ToString();
            }
            set
            {
                textBox3.Clear();
                textBox3.Text = value;
            }
        }
        public string Odp3
        {
            get
            {

                return textBox4.Text.ToString();
            }
            set
            {
                textBox4.Clear();
                textBox4.Text = value;
            }
        }
        public string Odp4
        {
            get
            {

                return textBox5.Text.ToString();
            }
            set
            {
                textBox5.Clear();
                textBox5.Text = value;
            }
        }
            public string Correct
        {
            get
            {
                return comboBox1.Text.ToString();
            }
            set
            {
                
                comboBox1.Text = value;
            }
        }

    
        public event Action Addq;
        public event Action LoadQuiz;

        public event Action Edit; // potrzebne do edycji
        public int Editque
        {
            get
            {
                int x = Convert.ToInt32(numericUpDown1.Value);

                return x;
            }
        }

        public event Action CreateFile;
       public string QuizName
        {
            get
            {
                return textBox6.Text.ToString();
            }

                set
            {

            }   
        }
        public event Action ChoseFile;
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Addq();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            catch
            {

                MessageBox.Show("Nie wybrałeś pliku");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Close();
           
        }

        private void button3_Click(object sender, EventArgs e) // przycisk edit
        {
            try
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                Edit();

            }
         catch
            {
                MessageBox.Show("Nie wybrałeś pliku");
            }
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            // LoadQuiz();
            string[] installs = new string[] { "odp1", "odp2", "odp3","odp4" };
            comboBox1.Items.AddRange(installs);
        }

        private void button4_Click(object sender, EventArgs e) //tworzenie nowego quizu
        {
            CreateFile(); 
            textBox6.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChoseFile();
            LoadQuiz();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

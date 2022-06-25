using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpClient
{
    public partial class ShowResult : MetroFramework.Forms.MetroForm
    {
        public static Hashtable PassHash { get; set; }

        private Dictionary<string, int> diseaseNum = new Dictionary<string, int>();
        string[] disease = { "Early blight", "Septoria leaf",  "Bacterial spot", 
            "Late blight", "Mosaic virus", "Yellow virus", "Tomato mold leaf", "Tomato two spotted spider mites leaf" };
        public ShowResult()
        {
            //'Early blight', 'Septoria leaf', 'Healthy leaf', 'Bacterial spot', 'Late blight', 'Mosaic virus', 'Yellow virus', 'Tomato mold leaf', 'Tomato two spotted spider mites leaf'
            InitializeComponent();
            for(int i = 0; i < disease.Length; i++)
                diseaseNum.Add(disease[i], i);
            TextBox[] textBoxes = new TextBox[8] {textBox1,textBox2,textBox3,textBox4,textBox5,textBox6,textBox7,textBox8};

            foreach (DictionaryEntry de in PassHash)
            {
                textBoxes[diseaseNum[(string)de.Key]].ForeColor = Color.Black;
            }


        }

        private void ShowResult_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            Form resultForm = new EarlyBlight();
            resultForm.StartPosition = FormStartPosition.Manual;
            resultForm.Location = new Point(700, 190);
            resultForm.BringToFront();
            resultForm.ShowDialog();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            Form resultForm = new Info2();
            resultForm.StartPosition = FormStartPosition.Manual;
            resultForm.Location = new Point(700, 180);
            resultForm.BringToFront();
            resultForm.ShowDialog();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Form resultForm = new Septoria();
            resultForm.StartPosition = FormStartPosition.Manual;
            resultForm.Location = new Point(700, 180);
            resultForm.BringToFront();
            resultForm.ShowDialog();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            Form resultForm = new Bacterialspot();
            resultForm.StartPosition = FormStartPosition.Manual;
            resultForm.Location = new Point(700, 180);
            resultForm.BringToFront();
            resultForm.ShowDialog();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            Form resultForm = new Mosaic();
            resultForm.StartPosition = FormStartPosition.Manual;
            resultForm.Location = new Point(700, 180);
            resultForm.BringToFront();
            resultForm.ShowDialog();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            Form resultForm = new Yellow();
            resultForm.StartPosition = FormStartPosition.Manual;
            resultForm.Location = new Point(700, 180);
            resultForm.BringToFront();
            resultForm.ShowDialog();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            Form resultForm = new Mold();
            resultForm.StartPosition = FormStartPosition.Manual;
            resultForm.Location = new Point(700, 180);
            resultForm.BringToFront();
            resultForm.ShowDialog();
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            Form resultForm = new Twospotted();
            resultForm.StartPosition = FormStartPosition.Manual;
            resultForm.Location = new Point(700, 180);
            resultForm.BringToFront();
            resultForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

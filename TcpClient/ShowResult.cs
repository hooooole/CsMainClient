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
    public partial class ShowResult : Form
    {
        public static Hashtable PassHash { get; set; }

        private Dictionary<string, int> diseaseNum = new Dictionary<string, int>();
        string[] disease = { "Early blight", "Septoria leaf", "Healthy leaf", "Bacterial spot", 
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Form resultForm = new EarlyBlight();
            resultForm.StartPosition = FormStartPosition.Manual;
            resultForm.Location = new Point(700, 180);
            resultForm.BringToFront();
            resultForm.ShowDialog();
        }
    }
}

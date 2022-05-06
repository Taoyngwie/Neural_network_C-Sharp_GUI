using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network_tao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Browse

            //ใช้งานการเปิดไฟล์
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // ให้มีการจำ path
                openFileDialog.RestoreDirectory = true;
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // อ่านไฟล์เข้ามา
                    textBox_pathfile.Text = openFileDialog.FileName;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Train

            // อ่านไฟล์พร้อมนำไปใส่ใน Trainingset
            List<TrainingSet> training_set_example = JsonConvert.DeserializeObject<List<TrainingSet>>(File.ReadAllText(textBox_pathfile.Text));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_input2_TextChanged(object sender, EventArgs e)
        {
            //Input2
        }

        private void textBox_input1_TextChanged(object sender, EventArgs e)
        {
            //Input1
        }

        private void textBox_input3_TextChanged(object sender, EventArgs e)
        {
            //Input3
        }

        private void textBox_Output_TextChanged(object sender, EventArgs e)
        {
            //Output
        }

        private void button_predict_Click(object sender, EventArgs e)
        {
            //Predict
        }

        private void textBox_pathfile_TextChanged(object sender, EventArgs e)
        {
            //textBox_pathfile
        }

        private void textBox_NumberOfIteration_TextChanged(object sender, EventArgs e)
        {
            //NumberOfIteration
        }

        private void label_weight1_Click(object sender, EventArgs e)
        {

        }

        private void label_weight2_Click(object sender, EventArgs e)
        {

        }

        private void label_weight3_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(CalcRactaArea(double.Parse(txtWidth.Text), double.Parse(txtHeight.Text)).ToString());

            double width = double.Parse(txtWidth.Text);
            double height = double.Parse(txtHeight.Text);
            MessageBox.Show(width.ToString());
            double area = CalcRactaArea(width);
            area = CalcRactaArea(width, height);

            MessageBox.Show(width.ToString());
            MessageBox.Show(area.ToString());
            MessageBox.Show("Test");

            Image userPic = Image.FromFile(@"C:\Users\Academy\Desktop.aaa.jpg");
            ResizeImage(userPic);


            ResizeImage(Image.FromFile(""), 1000, 1000);

        }
        void PrintStudentInfo(string fName, double score, string lName = "")
        {

        }
        void MyNewMethod()
        {

        }
        Image ResizeImage(Image i, int width = 300, int height = 400)
        {
            //resize image
            //resize image
            //resize image
            //resize image

            return i;
        }
        double CalcRactaArea(double width, double height = 1)
        {
            width++;
            double area = height * width;
            return area;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ali \r\n reza \r\n ahmad \r\n mehdi");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        Calculate hesapla = new Calculate();

        private string firstNum;
        private string secondNum;
        private bool Clear = true;
        private string islem = "";
        private double result;
        private int processCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            KeyPress0();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            KeyPress1();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            KeyPress2();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            KeyPress3();
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            KeyPress4();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            KeyPress5();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            KeyPress6();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            KeyPress7();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            KeyPress8();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            KeyPress9();
        }

        private void ButtonComma_Click(object sender, EventArgs e)
        {
            KeyPressComma();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            firstNum = "";
            secondNum = "";
            islem = "";
            Clear = true;
            ResultText.Text = "";
            processCount = 0;
        }



        private void DivButton_Click(object sender, EventArgs e)
        {
            if (islem == "" && firstNum != "")
            {
                Clear = false;
                islem = "/";
                ResultText.Text += "/";
            }
            else if (firstNum != "" && islem != "")
            {
                ResultText.Text =  ResultText.Text.Replace(islem, "/");
                islem = "/";

                if (processCount > 0)
                {
                    firstNum = Convert.ToString(result);
                    secondNum = "";
                    ResultText.Text = firstNum + " " + islem;
                }
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (islem == "" && firstNum != "")
            {
                Clear = false;
                islem = "*";
                ResultText.Text += "*";
            }
            else if (firstNum != "" && islem != "")
            {
                ResultText.Text = ResultText.Text.Replace(islem, "*");
                islem = "*";

                if (processCount > 0)
                {
                    firstNum = Convert.ToString(result);
                    secondNum = "";
                    ResultText.Text = firstNum + " " + islem;
                }
            }

        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            if (islem == "" && firstNum != "")
            {
                Clear = false;
                islem = "-";
                ResultText.Text += "-";
            }
            else if (firstNum != "" && islem != "")
            {
                ResultText.Text = ResultText.Text.Replace(islem, "-");
                islem = "-";

                if (processCount > 0)
                {
                    firstNum = Convert.ToString(result);
                    secondNum = "";
                    ResultText.Text = firstNum + " " + islem;
                }
            }
           
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            if (islem == "" && firstNum != "")
            {
                Clear = false;
                islem = "+";
                ResultText.Text += "+";
            }
            else if (firstNum != "" && islem != "")
            {
                ResultText.Text = ResultText.Text.Replace(islem, "+");
                islem = "+";

                if (processCount > 0)
                {
                    firstNum = Convert.ToString(result);
                    secondNum = "";
                    ResultText.Text = firstNum + " " + islem;
                }
            }
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if(islem != "" && firstNum != "" && secondNum != "") {
                Clear = false;
                processCount++;
                if (islem == "+")
                {
                    result = hesapla.Topla(Convert.ToDouble(firstNum), Convert.ToDouble(secondNum));
                    ResultText.Text = firstNum + " " + islem + " " + secondNum + "\n" + Convert.ToString(result);
                }

                if (islem == "-")
                {
                    result = hesapla.Cikar(Convert.ToDouble(firstNum), Convert.ToDouble(secondNum));
                    ResultText.Text = firstNum + " " + islem + " " + secondNum + "\n" + Convert.ToString(result);
                }

                if (islem == "*")
                {
                    result = hesapla.Carpma(Convert.ToDouble(firstNum), Convert.ToDouble(secondNum));
                    ResultText.Text = firstNum + " " + islem + " " + secondNum + "\n" + Convert.ToString(result);
                }

                if (islem == "/")
                {
                    result = hesapla.Bolme(Convert.ToDouble(firstNum), Convert.ToDouble(secondNum));
                    ResultText.Text = firstNum + " " + islem + " " + secondNum + "\n" + Convert.ToString(result);
                }
            }

        }




        public void KeyPress0()
        {
            if (Clear)
            {
                firstNum += "0";
                ResultText.Text = firstNum + " ";
            }
            else
            {
                secondNum += "0";
                ResultText.Text = firstNum + " " + islem + " " + secondNum;

            }
        }

        public void KeyPress1()
        {
            if (Clear)
            {
                firstNum += "1";
                ResultText.Text = firstNum + " ";
            }
            else
            {
                secondNum += "1";
                ResultText.Text = firstNum + " " + islem + " " + secondNum;
            }
        }

        public void KeyPress2()
        {
            if (Clear)
            {
                firstNum += "2";
                ResultText.Text = firstNum + " ";
            }
            else
            {
                secondNum += "2";
                ResultText.Text = firstNum + " " + islem + " " + secondNum;
            }
        }

        public void KeyPress3()
        {
            if (Clear)
            {
                firstNum += "3";
                ResultText.Text = firstNum + " ";
            }
            else
            {
                secondNum += "3";
                ResultText.Text = firstNum + " " + islem + " " + secondNum;
            }
        }

        public void KeyPress4()
        {
            if (Clear)
            {
                firstNum += "4";
                ResultText.Text = firstNum + " ";
            }
            else
            {
                secondNum += "4";
                ResultText.Text = firstNum + " " + islem + " " + secondNum;
            }
        }

        public void KeyPress5()
        {
            if (Clear)
            {
                firstNum += "5";
                ResultText.Text = firstNum + " ";
            }
            else
            {
                secondNum += "5";
                ResultText.Text = firstNum + " " + islem + " " + secondNum;
            }
        }

        public void KeyPress6()
        {
            if (Clear)
            {
                firstNum += "6";
                ResultText.Text = firstNum + " ";
            }
            else
            {
                secondNum += "6";
                ResultText.Text = firstNum + " " + islem + " " + secondNum;
            }
        }

        public void KeyPress7()
        {
            if (Clear)
            {
                firstNum += "7";
                ResultText.Text = firstNum + " ";
            }
            else
            {
                secondNum += "7";
                ResultText.Text = firstNum + " " + islem + " " + secondNum;
            }
        }

        public void KeyPress8()
        {
            if (Clear)
            {
                firstNum += "8";
                ResultText.Text = firstNum + " ";
            }
            else
            {
                secondNum += "8";
                ResultText.Text = firstNum + " " + islem + " " + secondNum;
            }
        }

        public void KeyPress9()
        {
            if (Clear)
            {
                firstNum += "9";
                ResultText.Text = firstNum + " ";
            }
            else
            {
                secondNum += "9";
                ResultText.Text = firstNum + " " + islem + " " + secondNum;
            }
        }

        public void KeyPressComma()
        {
            if (Clear)
            {
                firstNum += ".";
                ResultText.Text = firstNum + " ";
            }
            else
            {
                secondNum += ".";
                ResultText.Text = firstNum + " " + islem + " " + secondNum;
            }
        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

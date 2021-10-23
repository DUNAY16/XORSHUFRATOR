using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XORSHUFRATOR
{
    public partial class Form1 : Form
    {
        bool HEX, Binary, Decimal;
        public Form1()
        {
            InitializeComponent();
            HEX = true;
            radioButtonHEX.Checked = true;
            textBox_P.Text = "Введіть значення";
            textBox_P.ForeColor = Color.Gray; 
            textBox_Key.Text = "Введіть ключ";
            textBox_Key.ForeColor = Color.Gray; 
            textBox_P1.Text = "Введіть значення";
            textBox_P1.ForeColor = Color.Gray; 
            textBox_Key1.Text = "Введіть ключ";
            textBox_Key1.ForeColor = Color.Gray; 
            
            labelDecimalP.Visible = false; labelHEXP.Visible = false; labelBinaryP.Visible = false; labelDecimalKey.Visible = false; labelHEXKey.Visible = false; labelBinaryKey.Visible = false; labelDecimalC.Visible = false; labelHEXC.Visible = false; labelBinaryC.Visible = false;
            labelDecimalP1.Visible = false; labelHEXP1.Visible = false; labelBinaryP1.Visible = false; labelDecimalKey1.Visible = false; labelHEXKey1.Visible = false; labelBinaryKey1.Visible = false; labelDecimalC1.Visible = false; labelHEXC1.Visible = false; labelBinaryC1.Visible = false;
        }

        private void buttonXOR_Click(object sender, EventArgs e)
        {
            try
            {
                if(HEX == true)
                {
                    if (textBox_P.Text != "" && textBox_Key.Text != "")
                    {
                        string strP = textBox_P.Text;
                        int intP = Convert.ToInt32(strP, 16);
                        string strKey = textBox_Key.Text;
                        int intKey = Convert.ToInt32(strKey, 16);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 16);
                        textBox_C.Text = strC;

                        labelDecimalP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_P.Text, 16), 10);
                        labelHEXP.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_P.Text, 16), 16);
                        labelBinaryP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_P.Text, 16), 2);

                        labelDecimalKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 10);
                        labelHEXKey.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 16);
                        labelBinaryKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 16), 2);

                        labelDecimalC.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_C.Text, 16), 10);
                        labelHEXC.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_C.Text, 16), 16);
                        labelBinaryC.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_C.Text, 16), 2);

                        labelDecimalP.Visible = true; labelHEXP.Visible = true; labelBinaryP.Visible = true; labelDecimalKey.Visible = true; labelHEXKey.Visible = true; labelBinaryKey.Visible = true; labelDecimalC.Visible = true; labelHEXC.Visible = true; labelBinaryC.Visible = true;
                    }
                    else if (textBox_P.Text == "" || textBox_P.Text == "Введіть значення")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key.Text == "" || textBox_Key.Text == "Введіть ключ")
                    {
                        MessageBox.Show("Введіть ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_P.Text = "";
                        textBox_Key.Text = "";
                    }
                }
                
                if (Binary == true)
                {
                    if (textBox_P.Text != "" && textBox_Key.Text != "")
                    {
                        string strP = textBox_P.Text;
                        int intP = Convert.ToInt32(strP, 2);
                        string strKey = textBox_Key.Text;
                        int intKey = Convert.ToInt32(strKey, 2);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 2);
                        textBox_C.Text = strC;

                        labelDecimalP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_P.Text, 2), 10);
                        labelHEXP.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_P.Text, 2), 16);
                        labelBinaryP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_P.Text, 2), 2);

                        labelDecimalKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 10);
                        labelHEXKey.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 16);
                        labelBinaryKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 2), 2);

                        labelDecimalC.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_C.Text, 2), 10);
                        labelHEXC.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_C.Text, 2), 16);
                        labelBinaryC.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_C.Text, 2), 2);

                        labelDecimalP.Visible = true; labelHEXP.Visible = true; labelBinaryP.Visible = true; labelDecimalKey.Visible = true; labelHEXKey.Visible = true; labelBinaryKey.Visible = true; labelDecimalC.Visible = true; labelHEXC.Visible = true; labelBinaryC.Visible = true;
                    }
                    else if (textBox_P.Text == "" || textBox_P.Text == "Введіть значення")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key.Text == "" || textBox_Key.Text == "Введіть Ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_P.Text = "";
                        textBox_Key.Text = "";
                    }
                }
                
                if (Decimal == true)
                {
                    if (textBox_P.Text != "" && textBox_Key.Text != "")
                    {
                        string strP = textBox_P.Text;
                        int intP = Convert.ToInt32(strP, 10);
                        string strKey = textBox_Key.Text;
                        int intKey = Convert.ToInt32(strKey, 10);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 10);
                        textBox_C.Text = strC;

                        labelDecimalP.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_P.Text, 10), 10);
                        labelHEXP.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_P.Text, 10), 16);
                        labelBinaryP.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_P.Text, 10), 2);

                        labelDecimalKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 10);
                        labelHEXKey.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 16);
                        labelBinaryKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key.Text, 10), 2);

                        labelDecimalC.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_C.Text, 10), 10);
                        labelHEXC.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_C.Text, 10), 16);
                        labelBinaryC.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_C.Text, 10), 2);

                        labelDecimalP.Visible = true; labelHEXP.Visible = true; labelBinaryP.Visible = true; labelDecimalKey.Visible = true; labelHEXKey.Visible = true; labelBinaryKey.Visible = true; labelDecimalC.Visible = true; labelHEXC.Visible = true; labelBinaryC.Visible = true;
                    }
                    else if (textBox_P.Text == "" || textBox_P.Text == "Введіть значення")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key.Text == "" || textBox_Key.Text == "Введіть Ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_P.Text = "";
                        textBox_Key.Text = "";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "" ;
            textBox_Key.Text = "" ;
            textBox_C.Text = "" ;
            labelDecimalP.Visible = false; labelHEXP.Visible = false; labelBinaryP.Visible = false; labelDecimalKey.Visible = false; labelHEXKey.Visible = false; labelBinaryKey.Visible = false; labelDecimalC.Visible = false; labelHEXC.Visible = false; labelBinaryC.Visible = false;
        }

        private void radioButtonHEX_CheckedChanged(object sender, EventArgs e)
        {
            HEX = true;  Binary = false;  Decimal = false;
        }

        private void textBox_P_Enter(object sender, EventArgs e)
        {
            if (textBox_P.Text == "Введіть значення")
            {
                textBox_P.Text = "";
                textBox_P.ForeColor = Color.Black;
            }
        }

        private void textBox_P_Leave(object sender, EventArgs e)
        {
            if (textBox_P.Text == "")
            {
                textBox_P.Text = "Введіть значення";
                textBox_P.ForeColor = Color.Gray;
            }
        }

        private void textBox_Key_Leave(object sender, EventArgs e)
        {
            if (textBox_Key.Text == "")
            {
                textBox_Key.Text = "Введіть ключ";
                textBox_Key.ForeColor = Color.Gray;
            }
        }

        private void textBox_Key_Enter(object sender, EventArgs e)
        {
            if (textBox_Key.Text == "Введіть ключ")
            {
                textBox_Key.Text = "";
                textBox_Key.ForeColor = Color.Black;
            }
        }

        private void textBox_P1_Leave(object sender, EventArgs e)
        {
            if (textBox_P1.Text == "")
            {
                textBox_P1.Text = "Введіть значення";
                textBox_P1.ForeColor = Color.Gray;
            }
        }

        private void textBox_P1_Enter(object sender, EventArgs e)
        {
            if (textBox_P1.Text == "Введіть значення")
            {
                textBox_P1.Text = "";
                textBox_P1.ForeColor = Color.Black;
            }
        }

        private void textBox_Key1_Leave(object sender, EventArgs e)
        {
            if (textBox_Key1.Text == "")
            {
                textBox_Key1.Text = "Введіть ключ";
                textBox_Key1.ForeColor = Color.Gray;
            }
        }

        private void textBox_Key1_Enter(object sender, EventArgs e)
        {
            if (textBox_Key1.Text == "Введіть ключ")
            {
                textBox_Key1.Text = "";
                textBox_Key1.ForeColor = Color.Black;
            }
        }


        private void buttonClear1_Click(object sender, EventArgs e)
        {
            textBox_P1.Text = "";
            textBox_Key1.Text = "";
            textBox_C1.Text = "";
            labelDecimalP1.Visible = false; labelHEXP1.Visible = false; labelBinaryP1.Visible = false; labelDecimalKey1.Visible = false; labelHEXKey1.Visible = false; labelBinaryKey1.Visible = false; labelDecimalC1.Visible = false; labelHEXC1.Visible = false; labelBinaryC1.Visible = false;
        }

        private void buttonXOR1_Click(object sender, EventArgs e)
        {
            try
            {
                if (HEX == true)
                {
                    if (textBox_P1.Text != "" && textBox_Key1.Text != "")
                    {
                        string strP = textBox_P1.Text;
                        int intP = Convert.ToInt32(strP, 16);
                        string strKey = textBox_Key1.Text;
                        int intKey = Convert.ToInt32(strKey, 16);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 16);
                        textBox_C1.Text = strC;

                        labelDecimalP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_P1.Text, 16), 10);
                        labelHEXP1.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_P1.Text, 16), 16);
                        labelBinaryP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_P1.Text, 16), 2);

                        labelDecimalKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 10);
                        labelHEXKey1.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 16);
                        labelBinaryKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 16), 2);

                        labelDecimalC1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_C1.Text, 16), 10);
                        labelHEXC1.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_C1.Text, 16), 16);
                        labelBinaryC1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_C1.Text, 16), 2);

                        labelDecimalP1.Visible = true; labelHEXP1.Visible = true; labelBinaryP1.Visible = true; labelDecimalKey1.Visible = true; labelHEXKey1.Visible = true; labelBinaryKey1.Visible = true; labelDecimalC1.Visible = true; labelHEXC1.Visible = true; labelBinaryC1.Visible = true;
                    }
                    else if (textBox_P1.Text == "" || textBox_P1.Text == "Введіть значення")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key1.Text == "" || textBox_Key1.Text == "Введіть ключ")
                    {
                        MessageBox.Show("Введіть ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_P1.Text = "";
                        textBox_Key1.Text = "";
                    }
                }

                if (Binary == true)
                {
                    if (textBox_P1.Text != "" && textBox_Key1.Text != "")
                    {
                        string strP = textBox_P1.Text;
                        int intP = Convert.ToInt32(strP, 2);
                        string strKey = textBox_Key1.Text;
                        int intKey = Convert.ToInt32(strKey, 2);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 2);
                        textBox_C1.Text = strC;

                        labelDecimalP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_P1.Text, 2), 10);
                        labelHEXP1.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_P1.Text, 2), 16);
                        labelBinaryP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_P1.Text, 2), 2);

                        labelDecimalKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 10);
                        labelHEXKey1.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 16);
                        labelBinaryKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 2);

                        labelDecimalC1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_C1.Text, 2), 10);
                        labelHEXC1.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_C1.Text, 2), 16);
                        labelBinaryC1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_C1.Text, 2), 2);

                        labelDecimalP1.Visible = true; labelHEXP1.Visible = true; labelBinaryP1.Visible = true; labelDecimalKey1.Visible = true; labelHEXKey1.Visible = true; labelBinaryKey1.Visible = true; labelDecimalC1.Visible = true; labelHEXC1.Visible = true; labelBinaryC1.Visible = true;
                    }
                    else if (textBox_P1.Text == "" || textBox_P1.Text == "Введіть значення")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key1.Text == "" || textBox_Key1.Text == "Введіть Ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_P1.Text = "";
                        textBox_Key1.Text = "";
                    }
                }

                if (Decimal == true)
                {
                    if (textBox_P1.Text != "" && textBox_Key1.Text != "")
                    {
                        string strP = textBox_P1.Text;
                        int intP = Convert.ToInt32(strP, 10);
                        string strKey = textBox_Key1.Text;
                        int intKey = Convert.ToInt32(strKey, 10);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 10);
                        textBox_C1.Text = strC;

                        labelDecimalP1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_P1.Text, 10), 10);
                        labelHEXP1.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_P1.Text, 10), 16);
                        labelBinaryP1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_P1.Text, 10), 2);

                        labelDecimalKey1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 10);
                        labelHEXKey1.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 10), 16);
                        labelBinaryKey1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_Key1.Text, 2), 2);

                        labelDecimalC1.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(textBox_C1.Text, 10), 10);
                        labelHEXC1.Text = "HEX = " + Convert.ToString(Convert.ToInt32(textBox_C1.Text, 10), 16);
                        labelBinaryC1.Text = "Binary = " + Convert.ToString(Convert.ToInt32(textBox_C1.Text, 10), 2);

                        labelDecimalP1.Visible = true; labelHEXP1.Visible = true; labelBinaryP1.Visible = true; labelDecimalKey1.Visible = true; labelHEXKey1.Visible = true; labelBinaryKey1.Visible = true; labelDecimalC1.Visible = true; labelHEXC1.Visible = true; labelBinaryC1.Visible = true;
                    }
                    else if (textBox_P1.Text == "" || textBox_P1.Text == "Введіть значення")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (textBox_Key1.Text == "" || textBox_Key1.Text == "Введіть Ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        textBox_P1.Text = "";
                        textBox_Key1.Text = "";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

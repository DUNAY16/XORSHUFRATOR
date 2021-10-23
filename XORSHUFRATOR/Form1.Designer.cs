namespace XORSHUFRATOR
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonXOR = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_P1 = new System.Windows.Forms.TextBox();
            this.textBox_Key1 = new System.Windows.Forms.TextBox();
            this.textBox_C1 = new System.Windows.Forms.TextBox();
            this.buttonClear1 = new System.Windows.Forms.Button();
            this.buttonXOR1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDecimal = new System.Windows.Forms.RadioButton();
            this.radioButton2Binary = new System.Windows.Forms.RadioButton();
            this.radioButtonHEX = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDecimalKey = new System.Windows.Forms.Label();
            this.labelBinaryKey = new System.Windows.Forms.Label();
            this.labelHEXKey = new System.Windows.Forms.Label();
            this.labelDecimalC = new System.Windows.Forms.Label();
            this.labelBinaryC = new System.Windows.Forms.Label();
            this.labelHEXC = new System.Windows.Forms.Label();
            this.labelDecimalP = new System.Windows.Forms.Label();
            this.labelBinaryP = new System.Windows.Forms.Label();
            this.labelHEXP = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelDecimalP1 = new System.Windows.Forms.Label();
            this.labelBinaryP1 = new System.Windows.Forms.Label();
            this.labelHEXP1 = new System.Windows.Forms.Label();
            this.labelDecimalKey1 = new System.Windows.Forms.Label();
            this.labelBinaryKey1 = new System.Windows.Forms.Label();
            this.labelHEXKey1 = new System.Windows.Forms.Label();
            this.labelDecimalC1 = new System.Windows.Forms.Label();
            this.labelBinaryC1 = new System.Windows.Forms.Label();
            this.labelHEXC1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "P =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "C =";
            // 
            // buttonXOR
            // 
            this.buttonXOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonXOR.Location = new System.Drawing.Point(209, 231);
            this.buttonXOR.Name = "buttonXOR";
            this.buttonXOR.Size = new System.Drawing.Size(100, 28);
            this.buttonXOR.TabIndex = 3;
            this.buttonXOR.Text = "XOR";
            this.buttonXOR.UseVisualStyleBackColor = true;
            this.buttonXOR.Click += new System.EventHandler(this.buttonXOR_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(29, 229);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(111, 30);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(96, 51);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(185, 27);
            this.textBox_P.TabIndex = 5;
            this.textBox_P.Enter += new System.EventHandler(this.textBox_P_Enter);
            this.textBox_P.Leave += new System.EventHandler(this.textBox_P_Leave);
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(96, 108);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(185, 27);
            this.textBox_Key.TabIndex = 6;
            this.textBox_Key.Enter += new System.EventHandler(this.textBox_Key_Enter);
            this.textBox_Key.Leave += new System.EventHandler(this.textBox_Key_Leave);
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(96, 168);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.ReadOnly = true;
            this.textBox_C.Size = new System.Drawing.Size(185, 27);
            this.textBox_C.TabIndex = 7;
            // 
            // textBox_P1
            // 
            this.textBox_P1.Location = new System.Drawing.Point(20, 51);
            this.textBox_P1.Name = "textBox_P1";
            this.textBox_P1.Size = new System.Drawing.Size(185, 27);
            this.textBox_P1.TabIndex = 10;
            this.textBox_P1.Enter += new System.EventHandler(this.textBox_P1_Enter);
            this.textBox_P1.Leave += new System.EventHandler(this.textBox_P1_Leave);
            // 
            // textBox_Key1
            // 
            this.textBox_Key1.Location = new System.Drawing.Point(20, 108);
            this.textBox_Key1.Name = "textBox_Key1";
            this.textBox_Key1.Size = new System.Drawing.Size(185, 27);
            this.textBox_Key1.TabIndex = 9;
            this.textBox_Key1.Enter += new System.EventHandler(this.textBox_Key1_Enter);
            this.textBox_Key1.Leave += new System.EventHandler(this.textBox_Key1_Leave);
            // 
            // textBox_C1
            // 
            this.textBox_C1.Location = new System.Drawing.Point(20, 164);
            this.textBox_C1.Name = "textBox_C1";
            this.textBox_C1.ReadOnly = true;
            this.textBox_C1.Size = new System.Drawing.Size(185, 27);
            this.textBox_C1.TabIndex = 8;
            // 
            // buttonClear1
            // 
            this.buttonClear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear1.Location = new System.Drawing.Point(20, 229);
            this.buttonClear1.Name = "buttonClear1";
            this.buttonClear1.Size = new System.Drawing.Size(111, 30);
            this.buttonClear1.TabIndex = 12;
            this.buttonClear1.Text = "Очистити";
            this.buttonClear1.UseVisualStyleBackColor = true;
            this.buttonClear1.Click += new System.EventHandler(this.buttonClear1_Click);
            // 
            // buttonXOR1
            // 
            this.buttonXOR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonXOR1.Location = new System.Drawing.Point(198, 229);
            this.buttonXOR1.Name = "buttonXOR1";
            this.buttonXOR1.Size = new System.Drawing.Size(100, 28);
            this.buttonXOR1.TabIndex = 11;
            this.buttonXOR1.Text = "XOR";
            this.buttonXOR1.UseVisualStyleBackColor = true;
            this.buttonXOR1.Click += new System.EventHandler(this.buttonXOR1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDecimal);
            this.groupBox1.Controls.Add(this.radioButton2Binary);
            this.groupBox1.Controls.Add(this.radioButtonHEX);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(242, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 65);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Симстеми числення";
            // 
            // radioButtonDecimal
            // 
            this.radioButtonDecimal.AutoSize = true;
            this.radioButtonDecimal.Location = new System.Drawing.Point(174, 22);
            this.radioButtonDecimal.Name = "radioButtonDecimal";
            this.radioButtonDecimal.Size = new System.Drawing.Size(99, 28);
            this.radioButtonDecimal.TabIndex = 2;
            this.radioButtonDecimal.TabStop = true;
            this.radioButtonDecimal.Text = "Decimal";
            this.radioButtonDecimal.UseVisualStyleBackColor = true;
            // 
            // radioButton2Binary
            // 
            this.radioButton2Binary.AutoSize = true;
            this.radioButton2Binary.Location = new System.Drawing.Point(85, 22);
            this.radioButton2Binary.Name = "radioButton2Binary";
            this.radioButton2Binary.Size = new System.Drawing.Size(83, 28);
            this.radioButton2Binary.TabIndex = 1;
            this.radioButton2Binary.TabStop = true;
            this.radioButton2Binary.Text = "Binary";
            this.radioButton2Binary.UseVisualStyleBackColor = true;
            // 
            // radioButtonHEX
            // 
            this.radioButtonHEX.AutoSize = true;
            this.radioButtonHEX.Location = new System.Drawing.Point(7, 22);
            this.radioButtonHEX.Name = "radioButtonHEX";
            this.radioButtonHEX.Size = new System.Drawing.Size(72, 28);
            this.radioButtonHEX.TabIndex = 0;
            this.radioButtonHEX.TabStop = true;
            this.radioButtonHEX.Text = "HEX";
            this.radioButtonHEX.UseVisualStyleBackColor = true;
            this.radioButtonHEX.CheckedChanged += new System.EventHandler(this.radioButtonHEX_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aqua;
            this.groupBox2.Controls.Add(this.labelDecimalKey);
            this.groupBox2.Controls.Add(this.labelBinaryKey);
            this.groupBox2.Controls.Add(this.labelHEXKey);
            this.groupBox2.Controls.Add(this.labelDecimalC);
            this.groupBox2.Controls.Add(this.labelBinaryC);
            this.groupBox2.Controls.Add(this.labelHEXC);
            this.groupBox2.Controls.Add(this.labelDecimalP);
            this.groupBox2.Controls.Add(this.labelBinaryP);
            this.groupBox2.Controls.Add(this.labelHEXP);
            this.groupBox2.Controls.Add(this.textBox_C);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonXOR);
            this.groupBox2.Controls.Add(this.buttonClear);
            this.groupBox2.Controls.Add(this.textBox_P);
            this.groupBox2.Controls.Add(this.textBox_Key);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 266);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шифрувати";
            // 
            // labelDecimalKey
            // 
            this.labelDecimalKey.AutoSize = true;
            this.labelDecimalKey.Location = new System.Drawing.Point(251, 141);
            this.labelDecimalKey.Name = "labelDecimalKey";
            this.labelDecimalKey.Size = new System.Drawing.Size(71, 20);
            this.labelDecimalKey.TabIndex = 16;
            this.labelDecimalKey.Text = "Decimal";
            // 
            // labelBinaryKey
            // 
            this.labelBinaryKey.AutoSize = true;
            this.labelBinaryKey.Location = new System.Drawing.Point(124, 142);
            this.labelBinaryKey.Name = "labelBinaryKey";
            this.labelBinaryKey.Size = new System.Drawing.Size(57, 20);
            this.labelBinaryKey.TabIndex = 15;
            this.labelBinaryKey.Text = "Binary";
            // 
            // labelHEXKey
            // 
            this.labelHEXKey.AutoSize = true;
            this.labelHEXKey.Location = new System.Drawing.Point(29, 141);
            this.labelHEXKey.Name = "labelHEXKey";
            this.labelHEXKey.Size = new System.Drawing.Size(44, 20);
            this.labelHEXKey.TabIndex = 14;
            this.labelHEXKey.Text = "HEX";
            // 
            // labelDecimalC
            // 
            this.labelDecimalC.AutoSize = true;
            this.labelDecimalC.Location = new System.Drawing.Point(251, 200);
            this.labelDecimalC.Name = "labelDecimalC";
            this.labelDecimalC.Size = new System.Drawing.Size(71, 20);
            this.labelDecimalC.TabIndex = 13;
            this.labelDecimalC.Text = "Decimal";
            // 
            // labelBinaryC
            // 
            this.labelBinaryC.AutoSize = true;
            this.labelBinaryC.Location = new System.Drawing.Point(124, 200);
            this.labelBinaryC.Name = "labelBinaryC";
            this.labelBinaryC.Size = new System.Drawing.Size(57, 20);
            this.labelBinaryC.TabIndex = 12;
            this.labelBinaryC.Text = "Binary";
            // 
            // labelHEXC
            // 
            this.labelHEXC.AutoSize = true;
            this.labelHEXC.Location = new System.Drawing.Point(29, 198);
            this.labelHEXC.Name = "labelHEXC";
            this.labelHEXC.Size = new System.Drawing.Size(44, 20);
            this.labelHEXC.TabIndex = 11;
            this.labelHEXC.Text = "HEX";
            // 
            // labelDecimalP
            // 
            this.labelDecimalP.AutoSize = true;
            this.labelDecimalP.Location = new System.Drawing.Point(251, 85);
            this.labelDecimalP.Name = "labelDecimalP";
            this.labelDecimalP.Size = new System.Drawing.Size(71, 20);
            this.labelDecimalP.TabIndex = 10;
            this.labelDecimalP.Text = "Decimal";
            // 
            // labelBinaryP
            // 
            this.labelBinaryP.AutoSize = true;
            this.labelBinaryP.Location = new System.Drawing.Point(124, 85);
            this.labelBinaryP.Name = "labelBinaryP";
            this.labelBinaryP.Size = new System.Drawing.Size(57, 20);
            this.labelBinaryP.TabIndex = 9;
            this.labelBinaryP.Text = "Binary";
            // 
            // labelHEXP
            // 
            this.labelHEXP.AutoSize = true;
            this.labelHEXP.Location = new System.Drawing.Point(29, 85);
            this.labelHEXP.Name = "labelHEXP";
            this.labelHEXP.Size = new System.Drawing.Size(44, 20);
            this.labelHEXP.TabIndex = 8;
            this.labelHEXP.Text = "HEX";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.labelDecimalP1);
            this.groupBox3.Controls.Add(this.labelBinaryP1);
            this.groupBox3.Controls.Add(this.labelHEXP1);
            this.groupBox3.Controls.Add(this.labelDecimalKey1);
            this.groupBox3.Controls.Add(this.labelBinaryKey1);
            this.groupBox3.Controls.Add(this.labelHEXKey1);
            this.groupBox3.Controls.Add(this.labelDecimalC1);
            this.groupBox3.Controls.Add(this.labelBinaryC1);
            this.groupBox3.Controls.Add(this.labelHEXC1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox_C1);
            this.groupBox3.Controls.Add(this.textBox_Key1);
            this.groupBox3.Controls.Add(this.textBox_P1);
            this.groupBox3.Controls.Add(this.buttonClear1);
            this.groupBox3.Controls.Add(this.buttonXOR1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(402, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 266);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дешифрувати";
            // 
            // labelDecimalP1
            // 
            this.labelDecimalP1.AutoSize = true;
            this.labelDecimalP1.Location = new System.Drawing.Point(242, 85);
            this.labelDecimalP1.Name = "labelDecimalP1";
            this.labelDecimalP1.Size = new System.Drawing.Size(71, 20);
            this.labelDecimalP1.TabIndex = 21;
            this.labelDecimalP1.Text = "Decimal";
            // 
            // labelBinaryP1
            // 
            this.labelBinaryP1.AutoSize = true;
            this.labelBinaryP1.Location = new System.Drawing.Point(118, 85);
            this.labelBinaryP1.Name = "labelBinaryP1";
            this.labelBinaryP1.Size = new System.Drawing.Size(57, 20);
            this.labelBinaryP1.TabIndex = 20;
            this.labelBinaryP1.Text = "Binary";
            // 
            // labelHEXP1
            // 
            this.labelHEXP1.AutoSize = true;
            this.labelHEXP1.Location = new System.Drawing.Point(20, 85);
            this.labelHEXP1.Name = "labelHEXP1";
            this.labelHEXP1.Size = new System.Drawing.Size(44, 20);
            this.labelHEXP1.TabIndex = 19;
            this.labelHEXP1.Text = "HEX";
            // 
            // labelDecimalKey1
            // 
            this.labelDecimalKey1.AutoSize = true;
            this.labelDecimalKey1.Location = new System.Drawing.Point(242, 144);
            this.labelDecimalKey1.Name = "labelDecimalKey1";
            this.labelDecimalKey1.Size = new System.Drawing.Size(71, 20);
            this.labelDecimalKey1.TabIndex = 18;
            this.labelDecimalKey1.Text = "Decimal";
            // 
            // labelBinaryKey1
            // 
            this.labelBinaryKey1.AutoSize = true;
            this.labelBinaryKey1.Location = new System.Drawing.Point(118, 142);
            this.labelBinaryKey1.Name = "labelBinaryKey1";
            this.labelBinaryKey1.Size = new System.Drawing.Size(57, 20);
            this.labelBinaryKey1.TabIndex = 17;
            this.labelBinaryKey1.Text = "Binary";
            // 
            // labelHEXKey1
            // 
            this.labelHEXKey1.AutoSize = true;
            this.labelHEXKey1.Location = new System.Drawing.Point(20, 141);
            this.labelHEXKey1.Name = "labelHEXKey1";
            this.labelHEXKey1.Size = new System.Drawing.Size(44, 20);
            this.labelHEXKey1.TabIndex = 16;
            this.labelHEXKey1.Text = "HEX";
            // 
            // labelDecimalC1
            // 
            this.labelDecimalC1.AutoSize = true;
            this.labelDecimalC1.Location = new System.Drawing.Point(242, 200);
            this.labelDecimalC1.Name = "labelDecimalC1";
            this.labelDecimalC1.Size = new System.Drawing.Size(71, 20);
            this.labelDecimalC1.TabIndex = 15;
            this.labelDecimalC1.Text = "Decimal";
            // 
            // labelBinaryC1
            // 
            this.labelBinaryC1.AutoSize = true;
            this.labelBinaryC1.Location = new System.Drawing.Point(118, 200);
            this.labelBinaryC1.Name = "labelBinaryC1";
            this.labelBinaryC1.Size = new System.Drawing.Size(57, 20);
            this.labelBinaryC1.TabIndex = 14;
            this.labelBinaryC1.Text = "Binary";
            // 
            // labelHEXC1
            // 
            this.labelHEXC1.AutoSize = true;
            this.labelHEXC1.Location = new System.Drawing.Point(20, 200);
            this.labelHEXC1.Name = "labelHEXC1";
            this.labelHEXC1.Size = new System.Drawing.Size(44, 20);
            this.labelHEXC1.TabIndex = 13;
            this.labelHEXC1.Text = "HEX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(211, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "= C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(211, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "= Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(211, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "= P";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(786, 393);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(804, 440);
            this.MinimumSize = new System.Drawing.Size(804, 440);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrambler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonXOR;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.TextBox textBox_P1;
        private System.Windows.Forms.TextBox textBox_Key1;
        private System.Windows.Forms.TextBox textBox_C1;
        private System.Windows.Forms.Button buttonClear1;
        private System.Windows.Forms.Button buttonXOR1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDecimal;
        private System.Windows.Forms.RadioButton radioButton2Binary;
        private System.Windows.Forms.RadioButton radioButtonHEX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDecimalKey;
        private System.Windows.Forms.Label labelBinaryKey;
        private System.Windows.Forms.Label labelHEXKey;
        private System.Windows.Forms.Label labelDecimalC;
        private System.Windows.Forms.Label labelBinaryC;
        private System.Windows.Forms.Label labelHEXC;
        private System.Windows.Forms.Label labelDecimalP;
        private System.Windows.Forms.Label labelBinaryP;
        private System.Windows.Forms.Label labelHEXP;
        private System.Windows.Forms.Label labelDecimalP1;
        private System.Windows.Forms.Label labelBinaryP1;
        private System.Windows.Forms.Label labelHEXP1;
        private System.Windows.Forms.Label labelDecimalKey1;
        private System.Windows.Forms.Label labelBinaryKey1;
        private System.Windows.Forms.Label labelHEXKey1;
        private System.Windows.Forms.Label labelDecimalC1;
        private System.Windows.Forms.Label labelBinaryC1;
        private System.Windows.Forms.Label labelHEXC1;
    }
}


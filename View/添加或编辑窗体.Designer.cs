namespace 直流电机工作特性
{
    partial class 添加或编辑窗体
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new System.Windows.Forms.GroupBox();
            label7 = new System.Windows.Forms.Label();
            textBox6 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            groupBox3 = new System.Windows.Forms.GroupBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            转矩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            转速 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            电流 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new System.Drawing.Point(15, 18);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox1.Size = new System.Drawing.Size(456, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "基本信息";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(147, 86);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(37, 17);
            label7.TabIndex = 4;
            label7.Text = "V DC";
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(78, 82);
            textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(61, 23);
            textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(78, 35);
            textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(370, 23);
            textBox5.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(24, 86);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(32, 17);
            label6.TabIndex = 1;
            label6.Text = "电压";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(24, 38);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(32, 17);
            label5.TabIndex = 0;
            label5.Text = "型号";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new System.Drawing.Point(15, 177);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox2.Size = new System.Drawing.Size(456, 361);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "数据列表";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { 序号, 转矩, 转速, 电流 });
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(4, 20);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.Size = new System.Drawing.Size(448, 337);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new System.Drawing.Point(478, 177);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox3.Size = new System.Drawing.Size(237, 361);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "数据输入";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "g.cm", "kg.cm", "mNm", "Nm" });
            comboBox2.Location = new System.Drawing.Point(155, 81);
            comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(74, 25);
            comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A", "mA" });
            comboBox1.Location = new System.Drawing.Point(155, 164);
            comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(74, 25);
            comboBox1.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(127, 256);
            button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(88, 33);
            button3.TabIndex = 9;
            button3.Text = "删除";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(22, 256);
            button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(88, 33);
            button2.TabIndex = 8;
            button2.Text = "更新";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(61, 164);
            textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(83, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(61, 126);
            textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(83, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(61, 81);
            textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(83, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(61, 42);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(83, 23);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(20, 171);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(32, 17);
            label4.TabIndex = 3;
            label4.Text = "电流";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(20, 130);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 17);
            label3.TabIndex = 2;
            label3.Text = "转速";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 85);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 17);
            label2.TabIndex = 1;
            label2.Text = "转矩";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 47);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "序号";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(498, 45);
            button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(139, 95);
            button1.TabIndex = 3;
            button1.Text = "保存";
            button1.UseVisualStyleBackColor = true;
            // 
            // 序号
            // 
            序号.HeaderText = "序号";
            序号.Name = "序号";
            // 
            // 转矩
            // 
            转矩.HeaderText = "转矩";
            转矩.Name = "转矩";
            // 
            // 转速
            // 
            转速.HeaderText = "转速";
            转速.Name = "转速";
            // 
            // 电流
            // 
            电流.HeaderText = "电流";
            电流.Name = "电流";
            // 
            // 添加或编辑窗体
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(729, 555);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "添加或编辑窗体";
            Text = "添加/编辑";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 转矩;
        private System.Windows.Forms.DataGridViewTextBoxColumn 转速;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电流;
    }
}
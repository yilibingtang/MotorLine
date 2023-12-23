namespace 直流电机工作特性
{
    partial class 项目选择窗口
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
            MotorDataGridView = new System.Windows.Forms.DataGridView();
            AddEditorButton = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            exitButton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MotorDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MotorDataGridView);
            groupBox1.Location = new System.Drawing.Point(15, 150);
            groupBox1.Margin = new System.Windows.Forms.Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4);
            groupBox1.Size = new System.Drawing.Size(329, 305);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "电机型号列表";
            // 
            // MotorDataGridView
            // 
            MotorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MotorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            MotorDataGridView.Location = new System.Drawing.Point(4, 20);
            MotorDataGridView.Margin = new System.Windows.Forms.Padding(4);
            MotorDataGridView.Name = "MotorDataGridView";
            MotorDataGridView.RowTemplate.Height = 23;
            MotorDataGridView.Size = new System.Drawing.Size(321, 281);
            MotorDataGridView.TabIndex = 0;
            // 
            // AddEditorButton
            // 
            AddEditorButton.Location = new System.Drawing.Point(352, 164);
            AddEditorButton.Margin = new System.Windows.Forms.Padding(4);
            AddEditorButton.Name = "AddEditorButton";
            AddEditorButton.Size = new System.Drawing.Size(169, 58);
            AddEditorButton.TabIndex = 2;
            AddEditorButton.Text = "添加/编辑";
            AddEditorButton.UseVisualStyleBackColor = true;
            AddEditorButton.Click += AddEditorButton_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(351, 246);
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(169, 58);
            button2.TabIndex = 3;
            button2.Text = "删除";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(352, 313);
            button3.Margin = new System.Windows.Forms.Padding(4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(169, 58);
            button3.TabIndex = 4;
            button3.Text = "制图/打印";
            button3.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new System.Drawing.Point(352, 397);
            exitButton.Margin = new System.Windows.Forms.Padding(4);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(169, 58);
            exitButton.TabIndex = 5;
            exitButton.Text = "退出";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(492, 131);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // 项目选择窗口
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(536, 645);
            Controls.Add(pictureBox1);
            Controls.Add(exitButton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(AddEditorButton);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "项目选择窗口";
            Text = "直流电动机工作特性应用软件";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MotorDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddEditorButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView MotorDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
using System.Windows.Forms;

namespace OOP_lab_8_7_2
{
    partial class MainWindow : Form
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SortByWindSpeed = new System.Windows.Forms.Button();
            this.SortByPressure = new System.Windows.Forms.Button();
            this.SortByTemperature = new System.Windows.Forms.Button();
            this.SortByDate = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SortByWindSpeed);
            this.splitContainer1.Panel1.Controls.Add(this.SortByPressure);
            this.splitContainer1.Panel1.Controls.Add(this.SortByTemperature);
            this.splitContainer1.Panel1.Controls.Add(this.SortByDate);
            this.splitContainer1.Panel1.Controls.Add(this.Show);
            this.splitContainer1.Panel1.Controls.Add(this.Remove);
            this.splitContainer1.Panel1.Controls.Add(this.Edit);
            this.splitContainer1.Panel1.Controls.Add(this.Add);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 0;
            // 
            // SortByWindSpeed
            // 
            this.SortByWindSpeed.Location = new System.Drawing.Point(4, 264);
            this.SortByWindSpeed.Name = "SortByWindSpeed";
            this.SortByWindSpeed.Size = new System.Drawing.Size(277, 30);
            this.SortByWindSpeed.TabIndex = 7;
            this.SortByWindSpeed.Text = "Сортування за швидкiстю вiтру";
            this.SortByWindSpeed.UseVisualStyleBackColor = true;
            this.SortByWindSpeed.Click += new System.EventHandler(this.SortByWindSpeed_Click);
            // 
            // SortByPressure
            // 
            this.SortByPressure.Location = new System.Drawing.Point(3, 228);
            this.SortByPressure.Name = "SortByPressure";
            this.SortByPressure.Size = new System.Drawing.Size(279, 30);
            this.SortByPressure.TabIndex = 6;
            this.SortByPressure.Text = "Сортування за атмосферним тиском";
            this.SortByPressure.UseVisualStyleBackColor = true;
            this.SortByPressure.Click += new System.EventHandler(this.SortByPressure_Click);
            // 
            // SortByTemperature
            // 
            this.SortByTemperature.Location = new System.Drawing.Point(3, 192);
            this.SortByTemperature.Name = "SortByTemperature";
            this.SortByTemperature.Size = new System.Drawing.Size(279, 30);
            this.SortByTemperature.TabIndex = 5;
            this.SortByTemperature.Text = "Сортування за температурою повiтря";
            this.SortByTemperature.UseVisualStyleBackColor = true;
            this.SortByTemperature.Click += new System.EventHandler(this.SortByTemperature_Click);
            // 
            // SortByDate
            // 
            this.SortByDate.Location = new System.Drawing.Point(3, 156);
            this.SortByDate.Name = "SortByDate";
            this.SortByDate.Size = new System.Drawing.Size(278, 30);
            this.SortByDate.TabIndex = 4;
            this.SortByDate.Text = "Сортування за датою";
            this.SortByDate.UseVisualStyleBackColor = true;
            this.SortByDate.Click += new System.EventHandler(this.SortByDate_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(3, 120);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(279, 30);
            this.Show.TabIndex = 3;
            this.Show.Text = "Виведення записів на екран";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(3, 84);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(279, 30);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "Знищення записів";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(3, 48);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(279, 30);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Редагування записів";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(3, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(278, 30);
            this.Add.TabIndex = 0;
            this.Add.Text = "Додавання записiв";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1223, 861);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Main";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button SortByWindSpeed;
        private System.Windows.Forms.Button SortByPressure;
        private System.Windows.Forms.Button SortByTemperature;
        private System.Windows.Forms.Button SortByDate;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


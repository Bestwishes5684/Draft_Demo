namespace Draft_Demo.Forms
{
    partial class MainForm
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
            SearchTextBox = new TextBox();
            FiltrcomboBox = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            openFileDialog1 = new OpenFileDialog();
            label2 = new Label();
            SortcomboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTextBox.Location = new Point(2, 19);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(291, 29);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.Text = " Введите для поиска";
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // FiltrcomboBox
            // 
            FiltrcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FiltrcomboBox.FormattingEnabled = true;
            FiltrcomboBox.Location = new Point(759, 30);
            FiltrcomboBox.Name = "FiltrcomboBox";
            FiltrcomboBox.Size = new Size(134, 23);
            FiltrcomboBox.TabIndex = 2;
            FiltrcomboBox.SelectedIndexChanged += FiltrcomboBox_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(2, 82);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1201, 370);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(616, 33);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 5;
            label2.Text = "Фильровать данные по ";
            // 
            // SortcomboBox1
            // 
            SortcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            SortcomboBox1.FormattingEnabled = true;
            SortcomboBox1.Items.AddRange(new object[] { "Все типы", "Наименование ", "Остаток на складе", "Стоимость" });
            SortcomboBox1.Location = new Point(459, 23);
            SortcomboBox1.Name = "SortcomboBox1";
            SortcomboBox1.Size = new Size(121, 23);
            SortcomboBox1.TabIndex = 6;
            SortcomboBox1.SelectedIndexChanged += SortcomboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 28);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 7;
            label1.Text = "Сортировать по ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 450);
            Controls.Add(label1);
            Controls.Add(SortcomboBox1);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(FiltrcomboBox);
            Controls.Add(SearchTextBox);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchTextBox;
        private ComboBox FiltrcomboBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private OpenFileDialog openFileDialog1;
        private Label label2;
        private ComboBox SortcomboBox1;
        private Label label1;
    }
}
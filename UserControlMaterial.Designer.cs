namespace Draft_Demo
{
    partial class UserControlMaterial
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMaterial));
            pictureBox1 = new PictureBox();
            TypeMaterial = new Label();
            MinCount = new Label();
            Suppler = new Label();
            label4 = new Label();
            NameOFMatrial = new Label();
            CountInStock = new Label();
            Price = new Label();
            AddPhotoBTN = new Button();
            DeleteBTN = new Button();
            EditBTN = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TypeMaterial
            // 
            TypeMaterial.AutoSize = true;
            TypeMaterial.Location = new Point(305, 29);
            TypeMaterial.Name = "TypeMaterial";
            TypeMaterial.Size = new Size(89, 15);
            TypeMaterial.TabIndex = 1;
            TypeMaterial.Text = "Тип материала";
            // 
            // MinCount
            // 
            MinCount.Location = new Point(305, 88);
            MinCount.Name = "MinCount";
            MinCount.Size = new Size(203, 22);
            MinCount.TabIndex = 2;
            MinCount.Text = "Минимальное количество";
            // 
            // Suppler
            // 
            Suppler.Location = new Point(305, 134);
            Suppler.Name = "Suppler";
            Suppler.Size = new Size(310, 74);
            Suppler.TabIndex = 3;
            Suppler.Text = "Поставщики";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(474, 14);
            label4.Name = "label4";
            label4.Size = new Size(17, 28);
            label4.TabIndex = 4;
            label4.Text = "|";
            // 
            // NameOFMatrial
            // 
            NameOFMatrial.AutoSize = true;
            NameOFMatrial.Location = new Point(539, 29);
            NameOFMatrial.Name = "NameOFMatrial";
            NameOFMatrial.Size = new Size(154, 15);
            NameOFMatrial.TabIndex = 5;
            NameOFMatrial.Text = "Наименование Материала";
            // 
            // CountInStock
            // 
            CountInStock.AutoSize = true;
            CountInStock.Location = new Point(881, 29);
            CountInStock.Name = "CountInStock";
            CountInStock.Size = new Size(54, 15);
            CountInStock.TabIndex = 6;
            CountInStock.Text = "Остаток:";
            // 
            // Price
            // 
            Price.Location = new Point(870, 124);
            Price.Name = "Price";
            Price.Size = new Size(134, 25);
            Price.TabIndex = 7;
            Price.Text = "Цена";
            // 
            // AddPhotoBTN
            // 
            AddPhotoBTN.Location = new Point(21, 185);
            AddPhotoBTN.Name = "AddPhotoBTN";
            AddPhotoBTN.Size = new Size(108, 53);
            AddPhotoBTN.TabIndex = 8;
            AddPhotoBTN.Text = "Добавить фотографию";
            AddPhotoBTN.UseVisualStyleBackColor = true;
            AddPhotoBTN.Click += AddPhotoBTN_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(249, 185);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(108, 53);
            DeleteBTN.TabIndex = 9;
            DeleteBTN.Text = "Удалить ";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // EditBTN
            // 
            EditBTN.Location = new Point(135, 185);
            EditBTN.Name = "EditBTN";
            EditBTN.Size = new Size(108, 53);
            EditBTN.TabIndex = 10;
            EditBTN.Text = "Редактировать";
            EditBTN.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // UserControlMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EditBTN);
            Controls.Add(DeleteBTN);
            Controls.Add(AddPhotoBTN);
            Controls.Add(Price);
            Controls.Add(CountInStock);
            Controls.Add(NameOFMatrial);
            Controls.Add(label4);
            Controls.Add(Suppler);
            Controls.Add(MinCount);
            Controls.Add(TypeMaterial);
            Controls.Add(pictureBox1);
            Name = "UserControlMaterial";
            Size = new Size(1021, 303);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label TypeMaterial;
        private Label MinCount;
        private Label Suppler;
        private Label label4;
        private Label NameOFMatrial;
        private Label CountInStock;
        private Label Price;
        private Button AddPhotoBTN;
        private Button DeleteBTN;
        private Button EditBTN;
        private OpenFileDialog openFileDialog1;
    }
}

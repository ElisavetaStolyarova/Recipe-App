////namespace MYPROGECT
////{
////    partial class Form1
////    {
////        /// <summary>
////        /// Обязательная переменная конструктора.
////        /// </summary>
////        private System.ComponentModel.IContainer components = null;

////        /// <summary>
////        /// Освободить все используемые ресурсы.
////        /// </summary>
////        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
////        protected override void Dispose(bool disposing)
////        {
////            if (disposing && (components != null))
////            {
////                components.Dispose();
////            }
////            base.Dispose(disposing);
////        }

////        #region Код, автоматически созданный конструктором форм Windows

////        /// <summary>
////        /// Требуемый метод для поддержки конструктора — не изменяйте 
////        /// содержимое этого метода с помощью редактора кода.
////        /// </summary>
////        private void InitializeComponent()
////        {
////            this.SuspendLayout();
////            // 
////            // Form1
////            // 
////            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
////            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
////            this.ClientSize = new System.Drawing.Size(800, 450);
////            this.Name = "Form1";
////            this.Text = "Form1";
////            this.Load += new System.EventHandler(this.Form1_Load);
////            this.ResumeLayout(false);

////        }

////        #endregion
////    }
////}
//namespace RecipeApp
//{
//    partial class MainForm
//    {
//        private System.ComponentModel.IContainer components = null;

//        private System.Windows.Forms.TextBox searchTextBox;
//        private System.Windows.Forms.Button searchButton;
//        private System.Windows.Forms.ListBox recipesListBox;
//        private System.Windows.Forms.Label nameLabel;
//        private System.Windows.Forms.TextBox ingredientsTextBox;
//        private System.Windows.Forms.TextBox instructionsTextBox;
//        private System.Windows.Forms.Button addButton;
//        private System.Windows.Forms.Label categoryLabel;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            this.searchTextBox = new System.Windows.Forms.TextBox();
//            this.searchButton = new System.Windows.Forms.Button();
//            this.recipesListBox = new System.Windows.Forms.ListBox();
//            this.nameLabel = new System.Windows.Forms.Label();
//            this.ingredientsTextBox = new System.Windows.Forms.TextBox();
//            this.instructionsTextBox = new System.Windows.Forms.TextBox();
//            this.addButton = new System.Windows.Forms.Button();
//            this.categoryLabel = new System.Windows.Forms.Label();
//            this.SuspendLayout();
//            // 
//            // searchTextBox
//            // 
//            this.searchTextBox.Location = new System.Drawing.Point(20, 20);
//            this.searchTextBox.Name = "searchTextBox";
//            this.searchTextBox.Size = new System.Drawing.Size(300, 20);
//            this.searchTextBox.TabIndex = 0;
//            // 
//            // searchButton
//            // 
//            this.searchButton.Location = new System.Drawing.Point(330, 18);
//            this.searchButton.Name = "searchButton";
//            this.searchButton.Size = new System.Drawing.Size(75, 25);
//            this.searchButton.TabIndex = 1;
//            this.searchButton.Text = "Найти";
//            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
//            // 
//            // recipesListBox
//            // 
//            this.recipesListBox.Location = new System.Drawing.Point(20, 60);
//            this.recipesListBox.Name = "recipesListBox";
//            this.recipesListBox.Size = new System.Drawing.Size(250, 498);
//            this.recipesListBox.TabIndex = 2;
//            this.recipesListBox.SelectedIndexChanged += new System.EventHandler(this.recipesListBox_SelectedIndexChanged);
//            // 
//            // nameLabel
//            // 
//            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
//            this.nameLabel.Location = new System.Drawing.Point(300, 60);
//            this.nameLabel.Name = "nameLabel";
//            this.nameLabel.Size = new System.Drawing.Size(450, 30);
//            this.nameLabel.TabIndex = 3;
//            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
//            // 
//            // ingredientsTextBox
//            // 
//            this.ingredientsTextBox.BackColor = System.Drawing.Color.White;
//            this.ingredientsTextBox.Location = new System.Drawing.Point(300, 130);
//            this.ingredientsTextBox.Multiline = true;
//            this.ingredientsTextBox.Name = "ingredientsTextBox";
//            this.ingredientsTextBox.ReadOnly = true;
//            this.ingredientsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
//            this.ingredientsTextBox.Size = new System.Drawing.Size(450, 150);
//            this.ingredientsTextBox.TabIndex = 4;
//            // 
//            // instructionsTextBox
//            // 
//            this.instructionsTextBox.BackColor = System.Drawing.Color.White;
//            this.instructionsTextBox.Location = new System.Drawing.Point(300, 300);
//            this.instructionsTextBox.Multiline = true;
//            this.instructionsTextBox.Name = "instructionsTextBox";
//            this.instructionsTextBox.ReadOnly = true;
//            this.instructionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
//            this.instructionsTextBox.Size = new System.Drawing.Size(450, 260);
//            this.instructionsTextBox.TabIndex = 5;
//            // 
//            // addButton
//            // 
//            this.addButton.Location = new System.Drawing.Point(420, 18);
//            this.addButton.Name = "addButton";
//            this.addButton.Size = new System.Drawing.Size(100, 25);
//            this.addButton.TabIndex = 6;
//            this.addButton.Text = "Добавить рецепт";
//            this.addButton.Click += new System.EventHandler(this.addButton_Click);
//            // 
//            // categoryLabel
//            // 
//            this.categoryLabel.Location = new System.Drawing.Point(300, 100);
//            this.categoryLabel.Name = "categoryLabel";
//            this.categoryLabel.Size = new System.Drawing.Size(450, 20);
//            this.categoryLabel.TabIndex = 7;
//            // 
//            // MainForm
//            // 
//            this.ClientSize = new System.Drawing.Size(800, 600);
//            this.Controls.Add(this.searchTextBox);
//            this.Controls.Add(this.searchButton);
//            this.Controls.Add(this.recipesListBox);
//            this.Controls.Add(this.nameLabel);
//            this.Controls.Add(this.ingredientsTextBox);
//            this.Controls.Add(this.instructionsTextBox);
//            this.Controls.Add(this.addButton);
//            this.Controls.Add(this.categoryLabel);
//            this.Name = "MainForm";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Кулинарная книга";
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }
//    }
//}

namespace MYPROGECT
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox recipesListBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox ingredientsTextBox;
        private System.Windows.Forms.TextBox instructionsTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label imageLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.recipesListBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ingredientsTextBox = new System.Windows.Forms.TextBox();
            this.instructionsTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();

           
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(800, 650); // Увеличили высоту
            this.Text = "Кулинарная книга";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

          
            this.searchTextBox.Location = new System.Drawing.Point(20, 20);
            this.searchTextBox.Size = new System.Drawing.Size(300, 20);
            

           
            this.searchButton.Location = new System.Drawing.Point(330, 18);
            this.searchButton.Size = new System.Drawing.Size(75, 25);
            this.searchButton.Text = "Найти";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);

            
            this.addButton.Location = new System.Drawing.Point(420, 18);
            this.addButton.Size = new System.Drawing.Size(100, 25);
            this.addButton.Text = "Добавить рецепт";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);

           
            this.recipesListBox.Location = new System.Drawing.Point(20, 60);
            this.recipesListBox.Size = new System.Drawing.Size(250, 550);
            this.recipesListBox.SelectedIndexChanged += new System.EventHandler(this.recipesListBox_SelectedIndexChanged);

            this.nameLabel.Location = new System.Drawing.Point(300, 60);
            this.nameLabel.Size = new System.Drawing.Size(450, 30);
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);

            
            this.categoryLabel.Location = new System.Drawing.Point(300, 100);
            this.categoryLabel.Size = new System.Drawing.Size(450, 20);

            
            this.imageLabel.Location = new System.Drawing.Point(300, 320);
            this.imageLabel.Size = new System.Drawing.Size(100, 20);
            this.imageLabel.Text = "Изображение:";

            
            this.ingredientsTextBox.Location = new System.Drawing.Point(300, 130);
            this.ingredientsTextBox.Multiline = true;
            this.ingredientsTextBox.Size = new System.Drawing.Size(450, 80);
            this.ingredientsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ingredientsTextBox.ReadOnly = true;
            this.ingredientsTextBox.BackColor = System.Drawing.Color.White;

            
            this.instructionsTextBox.Location = new System.Drawing.Point(300, 220);
            this.instructionsTextBox.Multiline = true;
            this.instructionsTextBox.Size = new System.Drawing.Size(450, 90);
            this.instructionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.instructionsTextBox.ReadOnly = true;
            this.instructionsTextBox.BackColor = System.Drawing.Color.White;

            
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.recipesListBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.ingredientsTextBox);
            this.Controls.Add(this.instructionsTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.imageLabel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
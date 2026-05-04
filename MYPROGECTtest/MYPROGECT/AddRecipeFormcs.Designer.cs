//namespace RecipeApp
//{
//    partial class AddRecipeForm
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.SuspendLayout();
//            // 
//            // AddRecipeFormcs
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Name = "AddRecipeFormcs";
//            this.Text = "AddRecipeFormcs";
//            this.Load += new System.EventHandler(this.AddRecipeFormcs_Load);
//            this.ResumeLayout(false);

//        }

//        #endregion
//    }
//}
namespace MYPROGECT
{
    partial class AddRecipeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ingredientsTextBox;
        private System.Windows.Forms.TextBox instructionsTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ingredientsTextBox = new System.Windows.Forms.TextBox();
            this.instructionsTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
             
            this.nameTextBox.Location = new System.Drawing.Point(130, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(330, 20);
            this.nameTextBox.TabIndex = 1;
             
            this.ingredientsTextBox.Location = new System.Drawing.Point(130, 100);
            this.ingredientsTextBox.Multiline = true;
            this.ingredientsTextBox.Name = "ingredientsTextBox";
            this.ingredientsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ingredientsTextBox.Size = new System.Drawing.Size(330, 100);
            this.ingredientsTextBox.TabIndex = 3;
          
            this.instructionsTextBox.Location = new System.Drawing.Point(130, 220);
            this.instructionsTextBox.Multiline = true;
            this.instructionsTextBox.Name = "instructionsTextBox";
            this.instructionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.instructionsTextBox.Size = new System.Drawing.Size(330, 150);
            this.instructionsTextBox.TabIndex = 5;
        
            this.categoryTextBox.Location = new System.Drawing.Point(130, 60);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(330, 20);
            this.categoryTextBox.TabIndex = 7;
           
            this.saveButton.Location = new System.Drawing.Point(300, 380);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
          
            this.cancelButton.Location = new System.Drawing.Point(385, 380);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 30);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
           
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
           
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ингредиенты:";
          
            this.label3.Location = new System.Drawing.Point(20, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Инструкция:";
           
            this.label4.Location = new System.Drawing.Point(20, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Категория:";
            
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingredientsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.instructionsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "AddRecipeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить новый рецепт";
            this.Load += new System.EventHandler(this.AddRecipeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
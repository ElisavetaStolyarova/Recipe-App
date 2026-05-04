
////using System;
////using System.Windows.Forms;

////namespace RecipeApp
////{
////    public partial class AddRecipeForm : Form
////    {
////        public Recipe NewRecipe { get; private set; }

////        public AddRecipeForm()
////        {
////            InitializeComponent();
////        }

////        private void saveButton_Click(object sender, EventArgs e)
////        {
////            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
////                string.IsNullOrWhiteSpace(ingredientsTextBox.Text) ||
////                string.IsNullOrWhiteSpace(instructionsTextBox.Text) ||
////                string.IsNullOrWhiteSpace(categoryTextBox.Text))
////            {
////                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка",
////                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                return;
////            }

////            NewRecipe = new Recipe(
////                nameTextBox.Text,
////                instructionsTextBox.Text,
////                ingredientsTextBox.Text,
////                categoryTextBox.Text
////            );

////            DialogResult = DialogResult.OK;
////            Close();
////        }

////        private void cancelButton_Click(object sender, EventArgs e)
////        {
////            DialogResult = DialogResult.Cancel;
////            Close();
////        }
////    }
////}
//using System;
//using System.Drawing;
//using System.Windows.Forms;

//namespace MYPROGECT
//{
//    public partial class AddRecipeForm : Form
//    {
//        public Recipe NewRecipe { get; private set; }
//        private PictureBox imagePreview;
//        private Button browseButton;
//        private string selectedImagePath;

//        public AddRecipeForm()
//        {
//            InitializeComponent();
//            InitializeImageControls();
//        }

//        private void InitializeImageControls()
//        {
//            // Label для изображения
//            Label imageLabel = new Label();
//            imageLabel.Text = "Изображение:";
//            imageLabel.Location = new Point(20, 380);
//            imageLabel.Size = new Size(100, 20);
//            this.Controls.Add(imageLabel);

//            // PictureBox для предпросмотра
//            imagePreview = new PictureBox();
//            imagePreview.Location = new Point(130, 380);
//            imagePreview.Size = new Size(100, 100);
//            imagePreview.SizeMode = PictureBoxSizeMode.Zoom;
//            imagePreview.BorderStyle = BorderStyle.FixedSingle;
//            imagePreview.BackColor = Color.LightGray;
//            this.Controls.Add(imagePreview);

//            // Кнопка выбора изображения
//            browseButton = new Button();
//            browseButton.Text = "Выбрать...";
//            browseButton.Location = new Point(240, 380);
//            browseButton.Size = new Size(75, 25);
//            browseButton.Click += BrowseButton_Click;
//            this.Controls.Add(browseButton);

//            // Увеличиваем размер формы
//            this.ClientSize = new Size(500, 550);

//            // Перемещаем кнопки ниже
//            saveButton.Location = new Point(300, 490);
//            cancelButton.Location = new Point(385, 490);
//        }

//        private void BrowseButton_Click(object sender, EventArgs e)
//        {
//            using (OpenFileDialog openFileDialog = new OpenFileDialog())
//            {
//                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
//                openFileDialog.Title = "Выберите изображение рецепта";

//                if (openFileDialog.ShowDialog() == DialogResult.OK)
//                {
//                    selectedImagePath = openFileDialog.FileName;
//                    try
//                    {
//                        imagePreview.Image = Image.FromFile(selectedImagePath);
//                    }
//                    catch (Exception ex)
//                    {
//                        MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка",
//                            MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    }
//                }
//            }
//        }

//        private void saveButton_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
//                string.IsNullOrWhiteSpace(ingredientsTextBox.Text) ||
//                string.IsNullOrWhiteSpace(instructionsTextBox.Text) ||
//                string.IsNullOrWhiteSpace(categoryTextBox.Text))
//            {
//                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            NewRecipe = new Recipe(
//                nameTextBox.Text,
//                instructionsTextBox.Text,
//                ingredientsTextBox.Text,
//                categoryTextBox.Text,
//                selectedImagePath
//            );

//            DialogResult = DialogResult.OK;
//            Close();
//        }

//        private void cancelButton_Click(object sender, EventArgs e)
//        {
//            DialogResult = DialogResult.Cancel;
//            Close();
//        }
//    }
//}
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MYPROGECT
{
    public partial class AddRecipeForm : Form
    {
        public Recipe NewRecipe { get; private set; }
        private PictureBox imagePreview;
        private Button browseButton;
        private Label imagePathLabel;
        private string selectedImagePath;

        public AddRecipeForm()
        {
            InitializeComponent();
            InitializeImageControls();
        }

        private void InitializeImageControls()
        {
            
            Label imageLabel = new Label();
            imageLabel.Text = "Изображение:";
            imageLabel.Location = new Point(20, 380);
            imageLabel.Size = new Size(100, 20);
            this.Controls.Add(imageLabel);

            
            imagePreview = new PictureBox();
            imagePreview.Location = new Point(130, 380);
            imagePreview.Size = new Size(100, 100);
            imagePreview.SizeMode = PictureBoxSizeMode.Zoom;
            imagePreview.BorderStyle = BorderStyle.FixedSingle;
            imagePreview.BackColor = Color.LightGray;
            this.Controls.Add(imagePreview);

          
            browseButton = new Button();
            browseButton.Text = "Выбрать...";
            browseButton.Location = new Point(240, 380);
            browseButton.Size = new Size(75, 25);
            browseButton.Click += BrowseButton_Click;
            this.Controls.Add(browseButton);

            
            imagePathLabel = new Label();
            imagePathLabel.Location = new Point(130, 485);
            imagePathLabel.Size = new Size(330, 40);
            imagePathLabel.Text = "Файл не выбран";
            imagePathLabel.ForeColor = Color.Gray;
            this.Controls.Add(imagePathLabel);

           
            this.ClientSize = new Size(500, 550);

            
            saveButton.Location = new Point(300, 490);
            cancelButton.Location = new Point(385, 490);
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All files|*.*";
                openFileDialog.Title = "Выберите изображение рецепта";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    imagePathLabel.Text = Path.GetFileName(selectedImagePath);
                    imagePathLabel.ForeColor = Color.Black;

                    try
                    {
                        
                        using (var originalImage = Image.FromFile(selectedImagePath))
                        {
                            
                            int maxWidth = 200;
                            int maxHeight = 150;

                            double ratioX = (double)maxWidth / originalImage.Width;
                            double ratioY = (double)maxHeight / originalImage.Height;
                            double ratio = Math.Min(ratioX, ratioY);

                            int newWidth = (int)(originalImage.Width * ratio);
                            int newHeight = (int)(originalImage.Height * ratio);

                            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
                            using (Graphics g = Graphics.FromImage(resizedImage))
                            {
                                g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                            }

                            imagePreview.Image = resizedImage;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        imagePreview.Image = null;
                        selectedImagePath = null;
                        imagePathLabel.Text = "Файл не выбран";
                        imagePathLabel.ForeColor = Color.Gray;
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ingredientsTextBox.Text) ||
                string.IsNullOrWhiteSpace(instructionsTextBox.Text) ||
                string.IsNullOrWhiteSpace(categoryTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsRecipeNameExists(nameTextBox.Text))
            {
                MessageBox.Show("Рецепт с таким названием уже существует!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NewRecipe = new Recipe(
                nameTextBox.Text.Trim(),
                instructionsTextBox.Text.Trim(),
                ingredientsTextBox.Text.Trim(),
                categoryTextBox.Text.Trim(),
                selectedImagePath
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool IsRecipeNameExists(string recipeName)
        {
            return false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddRecipeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
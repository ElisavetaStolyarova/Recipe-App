
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Windows.Forms;
//using System.Xml;

//namespace RecipeApp
//{
//    public partial class MainForm : Form
//    {
//        private List<Recipe> recipes;
//        private List<Recipe> filteredRecipes;

//        public MainForm()
//        {
//            InitializeComponent();
//            InitializeRecipes();
//            DisplayRecipes();
//        }

//        private void InitializeRecipes()
//        {
//            // 30 рецептов
//            recipes = new List<Recipe>
//            {
//                new Recipe("Борщ", "Сварить бульон, добавить овощи, варить 40 минут", "Мясо, свекла, капуста, картофель, морковь", "Первые блюда"),
//                new Recipe("Оливье", "Отварить овощи и мясо, нарезать кубиками, смешать с майонезом", "Картофель, морковь, колбаса, яйца, горошек, майонез", "Салаты"),
//                new Recipe("Блины", "Смешать ингредиенты, жарить на сковороде с двух сторон", "Мука, яйца, молоко, сахар, соль", "Выпечка"),
//                new Recipe("Плов", "Обжарить мясо и овощи, добавить рис и тушить", "Рис, мясо, морковь, лук, специи", "Основные блюда"),
//                new Recipe("Шарлотка", "Взбить яйца с сахаром, добавить муку, запекать 30 минут", "Яйца, мука, сахар, яблоки", "Десерты"),
//                new Recipe("Греческий салат", "Нарезать овощи кубиками, добавить сыр и оливки", "Помидоры, огурцы, перец, сыр фета, оливки, лук", "Салаты"),
//                new Recipe("Курица по-французски", "Выложить слоями картофель, курицу, лук, залить майонезом и запекать", "Курица, картофель, лук, майонез, сыр", "Основные блюда"),
//                new Recipe("Томатный суп", "Обжарить овощи, добавить томаты и бульон, варить 20 минут", "Помидоры, лук, чеснок, бульон, сливки", "Первые блюда"),
//                new Recipe("Сырники", "Смешать творог с яйцами и мукой, обжарить на сковороде", "Творог, яйца, мука, сахар", "Завтраки"),
//                new Recipe("Паста Карбонара", "Обжарить бекон, смешать с яйцами и сыром, добавить к пасте", "Спагетти, бекон, яйца, сыр пармезан", "Основные блюда"),
//                new Recipe("Цезарь", "Обжарить курицу, приготовить соус, смешать с листьями салата", "Курица, салат, сухарики, сыр, соус цезарь", "Салаты"),
//                new Recipe("Омлет", "Взбить яйца с молоком, жарить на сковороде", "Яйца, молоко, соль, масло", "Завтраки"),
//                new Recipe("Гуляш", "Обжарить мясо, добавить овощи и тушить с соусом", "Говядина, лук, томатная паста, мука, специи", "Основные блюда"),
//                new Recipe("Винегрет", "Отварить овощи, нарезать кубиками, заправить маслом", "Свекла, картофель, морковь, огурцы, горошек", "Салаты"),
//                new Recipe("Печенье", "Смешать ингредиенты, вырезать фигурки, запекать 15 минут", "Мука, масло, сахар, яйца, разрыхлитель", "Десерты"),
//                new Recipe("Солянка", "Сварить бульон, добавить соленые огурцы, колбасу, оливки", "Мясо, колбаса, огурцы, оливки, томатная паста", "Первые блюда"),
//                new Recipe("Жаркое", "Обжарить мясо, добавить овощи и тушить в горшочках", "Свинина, картофель, морковь, лук", "Основные блюда"),
//                new Recipe("Мимоза", "Слоями выложить рыбу, овощи, яйца, промазать майонезом", "Консервированная рыба, картофель, морковь, яйца, майонез", "Салаты"),
//                new Recipe("Чизкейк", "Приготовить основу из печенья, залить сырной массой, запекать", "Печенье, творожный сыр, сахар, яйца, сливки", "Десерты"),
//                new Recipe("Рассольник", "Сварить бульон с перловкой, добавить огурцы и картофель", "Мясо, перловка, соленые огурцы, картофель", "Первые блюда"),
//                new Recipe("Котлеты", "Смешать фарш с луком и хлебом, обжарить с двух сторон", "Фарш, лук, хлеб, яйцо, специи", "Основные блюда"),
//                new Recipe("Капуста по-корейски", "Нашинковать капусту, добавить специи, дать настояться", "Капуста, морковь, уксус, масло, специи", "Закуски"),
//                new Recipe("Манник", "Смешать манку с кефиром, добавить яйца и сахар, запекать", "Манка, кефир, яйца, сахар, мука", "Выпечка"),
//                new Recipe("Уха", "Сварить рыбу с овощами, добавить специи", "Рыба, картофель, морковь, лук, специи", "Первые блюда"),
//                new Recipe("Голубцы", "Завернуть фарш в капустные листья, тушить в соусе", "Капуста, фарш, рис, томатная паста", "Основные блюда"),
//                new Recipe("Гренки", "Обмакнуть хлеб в яйцо, обжарить на сковороде", "Хлеб, яйца, молоко, соль", "Завтраки"),
//                new Recipe("Куриный суп", "Сварить курицу, добавить овощи и вермишель", "Курица, картофель, морковь, лук, вермишель", "Первые блюда"),
//                new Recipe("Тирамису", "Собрать слоями печенье, пропитанное кофе, и крем", "Печенье савоярди, сыр маскарпоне, кофе, какао", "Десерты"),
//                new Recipe("Фаршированный перец", "Нафаршировать перцы мясом с рисом, тушить в соусе", "Перец, фарш, рис, томатная паста", "Основные блюда"),
//                new Recipe("Окрошка", "Нарезать овощи и мясо, залить квасом", "Квас, колбаса, огурцы, редис, картофель, яйца", "Первые блюда")
//            };

//            filteredRecipes = new List<Recipe>(recipes);
//        }

//        private void DisplayRecipes()
//        {
//            recipesListBox.Items.Clear();
//            foreach (var recipe in filteredRecipes)
//            {
//                recipesListBox.Items.Add(recipe.Name);
//            }
//        }

//        private void searchButton_Click(object sender, EventArgs e)
//        {
//            string searchText = searchTextBox.Text.ToLower();

//            if (string.IsNullOrWhiteSpace(searchText))
//            {
//                filteredRecipes = new List<Recipe>(recipes);
//            }
//            else
//            {
//                filteredRecipes = recipes.Where(r =>
//                    r.Name.ToLower().Contains(searchText) ||
//                    r.Ingredients.ToLower().Contains(searchText) ||
//                    r.Category.ToLower().Contains(searchText))
//                    .ToList();
//            }

//            DisplayRecipes();
//        }

//        private void recipesListBox_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (recipesListBox.SelectedIndex >= 0 && recipesListBox.SelectedIndex < filteredRecipes.Count)
//            {
//                Recipe selectedRecipe = filteredRecipes[recipesListBox.SelectedIndex];
//                nameLabel.Text = selectedRecipe.Name;
//                ingredientsTextBox.Text = selectedRecipe.Ingredients;
//                instructionsTextBox.Text = selectedRecipe.Instructions;
//                categoryLabel.Text = $"Категория: {selectedRecipe.Category}";
//            }
//        }

//        private void addButton_Click(object sender, EventArgs e)
//        {
//            AddRecipeForm addForm = new AddRecipeForm();
//            if (addForm.ShowDialog() == DialogResult.OK)
//            {
//                recipes.Add(addForm.NewRecipe);
//                filteredRecipes = new List<Recipe>(recipes);
//                DisplayRecipes();
//                MessageBox.Show("Рецепт успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//        }

//        private void nameLabel_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

//namespace MYPROGECT
//{
//    public partial class MainForm : Form
//    {
//        private List<Recipe> recipes;
//        private List<Recipe> filteredRecipes;
//        private PictureBox recipePictureBox;

//        public MainForm()
//        {
//            InitializeComponent();
//            InitializePictureBox();
//            InitializeRecipes();
//            DisplayRecipes();
//        }

//        private void InitializePictureBox()
//        {
//            recipePictureBox = new PictureBox();
//            recipePictureBox.Location = new Point(300, 350);
//            recipePictureBox.Size = new Size(200, 150);
//            recipePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
//            recipePictureBox.BorderStyle = BorderStyle.FixedSingle;
//            this.Controls.Add(recipePictureBox);
//        }


namespace MYPROGECT
{
    public partial class MainForm : Form
    {
        private List<Recipe> recipes;
        private List<Recipe> filteredRecipes;
        private PictureBox recipePictureBox;
        private string imagesFolderPath;

        public MainForm()
        {
            InitializeComponent();
            InitializePictureBox();
            InitializeImagesFolder();
            InitializeRecipes();
            DisplayRecipes();
        }

        private void InitializeImagesFolder()
        {
            // Создаем папку для изображений в папке приложения
            imagesFolderPath = Path.Combine(Application.StartupPath, "RecipeImages");
            if (!Directory.Exists(imagesFolderPath))
            {
                Directory.CreateDirectory(imagesFolderPath);
            }
        }

        private void InitializePictureBox()
        {
            recipePictureBox = new PictureBox();
            recipePictureBox.Location = new Point(300, 350);
            recipePictureBox.Size = new Size(200, 150);
            recipePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            recipePictureBox.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(recipePictureBox);
        }
        private void InitializeRecipes()
        {

            string imagesPath = System.IO.Path.Combine(Application.StartupPath, "Images");

            recipes = new List<Recipe>
            {
                new Recipe("Борщ", "Сварить бульон, добавить овощи, варить 40 минут","Мясо, свекла, капуста, картофель, морковь", "Первые блюда",
                System.IO.Path.Combine(imagesPath, "borsh.jpg")),

                new Recipe("Оливье", "Отварить овощи и мясо, нарезать кубиками, смешать с майонезом","Картофель, морковь, колбаса, яйца, горошек, майонез", "Салаты",
                System.IO.Path.Combine(imagesPath, "olive.jpg")),

                new Recipe("Плов", "Обжарить мясо и овощи, добавить рис и тушить", "Рис, мясо, морковь, лук, специи", "Основные блюда",
                System.IO.Path.Combine(imagesPath, "plov.jpg")),

                new Recipe("Шарлотка", "Взбить яйца с сахаром, добавить муку, запекать 30 минут", "Яйца, мука, сахар, яблоки", "Десерты",
                System.IO.Path.Combine(imagesPath, "sharlotka.jpg")),

                new Recipe("Греческий салат", "Нарезать овощи кубиками, добавить сыр и оливки", "Помидоры, огурцы, перец, сыр фета, оливки, лук", "Салаты",
                System.IO.Path.Combine(imagesPath, "grechesk.jpg")),

                new Recipe("Курица по-французски", "Выложить слоями картофель, курицу, лук, залить майонезом и запекать", "Курица, картофель, лук, майонез, сыр", "Основные блюда",
                System.IO.Path.Combine(imagesPath, "chikenfranch.jpg")),

                new Recipe("Томатный суп", "Обжарить овощи, добавить томаты и бульон, варить 20 минут", "Помидоры, лук, чеснок, бульон, сливки", "Первые блюда",
                System.IO.Path.Combine(imagesPath, "tomatosup.jpg")),

                new Recipe("Сырники", "Смешать творог с яйцами и мукой, обжарить на сковороде", "Творог, яйца, мука, сахар", "Завтраки",
                System.IO.Path.Combine(imagesPath, "sirniki.jpg")),

                new Recipe("Паста Карбонара", "Обжарить бекон, смешать с яйцами и сыром, добавить к пасте", "Спагетти, бекон, яйца, сыр пармезан", "Основные блюда",
                System.IO.Path.Combine(imagesPath, "karbonara.jpg")),

                new Recipe("Цезарь", "Обжарить курицу, приготовить соус, смешать с листьями салата", "Курица, салат, сухарики, сыр, соус цезарь", "Салаты",
                System.IO.Path.Combine(imagesPath, "salat.jpg")),

                new Recipe("Омлет", "Взбить яйца с молоком, жарить на сковороде", "Яйца, молоко, соль, масло", "Завтраки",
                System.IO.Path.Combine(imagesPath, "omlet.jpg")),

                new Recipe("Гуляш", "Обжарить мясо, добавить овощи и тушить с соусом", "Говядина, лук, томатная паста, мука, специи", "Основные блюда",
                System.IO.Path.Combine(imagesPath, "gylash.jpg")),

                new Recipe("Винегрет", "Отварить овощи, нарезать кубиками, заправить маслом", "Свекла, картофель, морковь, огурцы, горошек", "Салаты",
                System.IO.Path.Combine(imagesPath, "vinigret.jpg")),

                new Recipe("Печенье", "Смешать ингредиенты, вырезать фигурки, запекать 15 минут", "Мука, масло, сахар, яйца, разрыхлитель", "Десерты",
                System.IO.Path.Combine(imagesPath, "cookies.jpg")),

                new Recipe("Солянка", "Сварить бульон, добавить соленые огурцы, колбасу, оливки", "Мясо, колбаса, огурцы, оливки, томатная паста", "Первые блюда",
                System.IO.Path.Combine(imagesPath, "solanka.jpg")),

                new Recipe("Жаркое", "Обжарить мясо, добавить овощи и тушить в горшочках", "Свинина, картофель, морковь, лук", "Основные блюда",
                System.IO.Path.Combine(imagesPath, "zharkoe.jpg")),

                new Recipe("Мимоза", "Слоями выложить рыбу, овощи, яйца, промазать майонезом", "Консервированная рыба, картофель, морковь, яйца, майонез", "Салаты",
                System.IO.Path.Combine(imagesPath, "mimoza.jpg")),

                new Recipe("Чизкейк", "Приготовить основу из печенья, залить сырной массой, запекать", "Печенье, творожный сыр, сахар, яйца, сливки", "Десерты",
                System.IO.Path.Combine(imagesPath, "cheescake.jpg")),

                new Recipe("Рассольник", "Сварить бульон с перловкой, добавить огурцы и картофель", "Мясо, перловка, соленые огурцы, картофель", "Первые блюда",
                System.IO.Path.Combine(imagesPath, "rassolnik.jpg")),

                new Recipe("Котлеты", "Смешать фарш с луком и хлебом, обжарить с двух сторон", "Фарш, лук, хлеб, яйцо, специи", "Основные блюда",
                System.IO.Path.Combine(imagesPath, "kotleta.jpg")),

                new Recipe("Капуста по-корейски", "Нашинковать капусту, добавить специи, дать настояться", "Капуста, морковь, уксус, масло, специи", "Закуски",
                System.IO.Path.Combine(imagesPath, "cabbage.jpg")),

                new Recipe("Манник", "Смешать манку с кефиром, добавить яйца и сахар, запекать", "Манка, кефир, яйца, сахар, мука", "Выпечка",
                System.IO.Path.Combine(imagesPath, "Manna.jpg")),

                new Recipe("Уха", "Сварить рыбу с овощами, добавить специи", "Рыба, картофель, морковь, лук, специи", "Первые блюда",
                System.IO.Path.Combine(imagesPath, "fishsup.jpg")),

                new Recipe("Голубцы", "Завернуть фарш в капустные листья, тушить в соусе", "Капуста, фарш, рис, томатная паста", "Основные блюда",
                System.IO.Path.Combine(imagesPath, "Stuffed cabbage rolls.jpg")),

                new Recipe("Гренки", "Обмакнуть хлеб в яйцо, обжарить на сковороде", "Хлеб, яйца, молоко, соль", "Завтраки",
                System.IO.Path.Combine(imagesPath, "toast.jpg")),

                new Recipe("Куриный суп", "Сварить курицу, добавить овощи и вермишель", "Курица, картофель, морковь, лук, вермишель", "Первые блюда",
                System.IO.Path.Combine(imagesPath, "chikensup.jpg")),

                new Recipe("Тирамису", "Собрать слоями печенье, пропитанное кофе, и крем", "Печенье савоярди, сыр маскарпоне, кофе, какао", "Десерты",
                System.IO.Path.Combine(imagesPath, "tiramisu.jpg")),

                new Recipe("Фаршированный перец", "Нафаршировать перцы мясом с рисом, тушить в соусе", "Перец, фарш, рис, томатная паста", "Основные блюда",
                System.IO.Path.Combine(imagesPath, "Stuffed peppers.jpg")),

                new Recipe("Окрошка", "Нарезать овощи и мясо, залить квасом", "Квас, колбаса, огурцы, редис, картофель, яйца", "Первые блюда",
                System.IO.Path.Combine(imagesPath, "Okroshka.jpg")),

                new Recipe("Блины", "Смешать ингредиенты, жарить на сковороде с двух сторон",
                    "Мука, яйца, молоко, сахар, соль", "Выпечка",
                    System.IO.Path.Combine(imagesPath, "blini.jpg"))
            };

                  
            LoadRecipeImages();

            filteredRecipes = new List<Recipe>(recipes);
        }
      

        private void LoadRecipeImages()
        {
            foreach (var recipe in recipes)
            {
                // Проверяем, есть ли сохраненное изображение для этого рецепта
                string imagePath = Path.Combine(imagesFolderPath, $"{recipe.Name.Replace(" ", "_")}.jpg");
                if (File.Exists(imagePath))
                {
                    recipe.ImagePath = imagePath;
                    recipe.LoadImage();
                }
            }
        }

        private void DisplayRecipes()
        {
            recipesListBox.Items.Clear();
            foreach (var recipe in filteredRecipes)
            {
                recipesListBox.Items.Add(recipe.Name);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                filteredRecipes = new List<Recipe>(recipes);
            }
            else
            {
                filteredRecipes = recipes.Where(r =>
                    r.Name.ToLower().Contains(searchText) ||
                    r.Ingredients.ToLower().Contains(searchText) ||
                    r.Category.ToLower().Contains(searchText))
                    .ToList();
            }

            DisplayRecipes();
        }

        private void recipesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recipesListBox.SelectedIndex >= 0 && recipesListBox.SelectedIndex < filteredRecipes.Count)
            {
                Recipe selectedRecipe = filteredRecipes[recipesListBox.SelectedIndex];
                nameLabel.Text = selectedRecipe.Name;
                ingredientsTextBox.Text = selectedRecipe.Ingredients;
                instructionsTextBox.Text = selectedRecipe.Instructions;
                categoryLabel.Text = $"Категория: {selectedRecipe.Category}";

                // Отображение изображения
                if (selectedRecipe.Image != null)
                {
                    recipePictureBox.Image = selectedRecipe.Image;
                }
                else
                {
                    recipePictureBox.Image = CreateDefaultImage();
                }
            }
        }

        private Image CreateDefaultImage()
        {
            Bitmap bmp = new Bitmap(200, 150);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                using (Font font = new Font("Arial", 10))
                {
                    g.DrawString("Нет изображения", font, Brushes.DarkGray, 50, 60);
                }
            }
            return bmp;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddRecipeForm addForm = new AddRecipeForm();

            if (addForm.ShowDialog() == DialogResult.OK && addForm.NewRecipe != null)
            {
                // Отладочное сообщение (можно удалить после отладки)
                MessageBox.Show($"Путь к изображению: {addForm.NewRecipe.ImagePath}\n" +
                               $"Файл существует: {File.Exists(addForm.NewRecipe.ImagePath)}",
                               "Отладка", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Копируем изображение в папку приложения
                if (!string.IsNullOrEmpty(addForm.NewRecipe.ImagePath) &&
                    File.Exists(addForm.NewRecipe.ImagePath))

                //        AddRecipeForm addForm = new AddRecipeForm();
                //if (addForm.ShowDialog() == DialogResult.OK && addForm.NewRecipe != null)
                {
                    // Копируем изображение в папку приложения
                    if (!string.IsNullOrEmpty(addForm.NewRecipe.ImagePath) &&
                        File.Exists(addForm.NewRecipe.ImagePath))
                    {
                        // Создаем безопасное имя файла
                        string safeFileName = addForm.NewRecipe.Name
                            .Replace(" ", "_")
                            .Replace("\\", "")
                            .Replace("/", "")
                            .Replace(":", "")
                            .Replace("*", "")
                            .Replace("?", "")
                            .Replace("\"", "")
                            .Replace("<", "")
                            .Replace(">", "")
                            .Replace("|", "");

                        string destinationPath = Path.Combine(imagesFolderPath, $"{safeFileName}.jpg");

                       

                        try
                        {
                            // Копируем файл
                            File.Copy(addForm.NewRecipe.ImagePath, destinationPath, true);

                            // Обновляем путь к изображению в рецепте
                            addForm.NewRecipe.ImagePath = destinationPath;
                            addForm.NewRecipe.LoadImage();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Не удалось сохранить изображение: {ex.Message}",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    recipes.Add(addForm.NewRecipe);
                    filteredRecipes = new List<Recipe>(recipes);
                    DisplayRecipes();

                    // Выбираем новый рецепт в списке
                    int newIndex = recipesListBox.Items.IndexOf(addForm.NewRecipe.Name);
                    if (newIndex >= 0)
                    {
                        recipesListBox.SelectedIndex = newIndex;
                    }

                    MessageBox.Show("Рецепт успешно добавлен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
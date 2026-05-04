
////using System.Drawing;

////namespace MYPROGECT
////{
////    public class Recipe
////    {
////        public string Name { get; set; }
////        public string Instructions { get; set; }
////        public string Ingredients { get; set; }
////        public string Category { get; set; }
////        public Image Image { get; set; }
////        public string ImagePath { get; set; }

////        public Recipe(string name, string instructions, string ingredients, string category)
////        {
////            Name = name;
////            Instructions = instructions;
////            Ingredients = ingredients;
////            Category = category;
////            Image = null;
////            ImagePath = string.Empty;
////        }

////        public Recipe(string name, string instructions, string ingredients, string category, string imagePath)
////        {
////            Name = name;
////            Instructions = instructions;
////            Ingredients = ingredients;
////            Category = category;
////            ImagePath = imagePath;

////            try
////            {
////                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
////                {
////                    Image = Image.FromFile(imagePath);
////                }
////                else
////                {
////                    Image = Properties.Resources.default_image; // Добавьте изображение по умолчанию в ресурсы
////                }
////            }
////            catch
////            {
////                Image = null;
////            }
////        }
////    }
////}
//using System;
//using System.Drawing;

//namespace MYPROGECT
//{
//    public class Recipe
//    {
//        public string Name { get; set; }
//        public string Instructions { get; set; }
//        public string Ingredients { get; set; }
//        public string Category { get; set; }
//        public Image Image { get; set; }
//        public string ImagePath { get; set; }

//        public Recipe(string name, string instructions, string ingredients, string category)
//        {
//            Name = name;
//            Instructions = instructions;
//            Ingredients = ingredients;
//            Category = category;
//            Image = CreateDefaultImage(); // Используем метод создания заглушки
//            ImagePath = string.Empty;
//        }

//        public Recipe(string name, string instructions, string ingredients, string category, string imagePath)
//        {
//            Name = name;
//            Instructions = instructions;
//            Ingredients = ingredients;
//            Category = category;
//            ImagePath = imagePath;

//            try
//            {
//                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
//                {
//                    Image = Image.FromFile(imagePath);
//                }
//                else
//                {
//                    Image = CreateDefaultImage(); 
//                }
//            }
//            catch
//            {
//                Image = CreateDefaultImage(); 
//            }
//        }


//        private Image CreateDefaultImage()
//        {
//            Bitmap bmp = new Bitmap(200, 150);
//            using (Graphics g = Graphics.FromImage(bmp))
//            {
//                // Заливаем фон
//                g.Clear(Color.LightGray);

//                // Рисуем рамку
//                g.DrawRectangle(Pens.Gray, 0, 0, 199, 149);

//                // Рисуем иконку фотоаппарата 
//                g.DrawRectangle(Pens.DarkGray, 70, 40, 60, 50); // Корпус
//                g.DrawEllipse(Pens.DarkGray, 85, 55, 30, 30); // Объектив
//                g.FillEllipse(Brushes.DarkGray, 92, 62, 16, 16); // Линза
//                g.DrawRectangle(Pens.DarkGray, 115, 45, 15, 10); // Вспышка

//                // Добавляем текст
//                using (Font font = new Font("Arial", 10))
//                {
//                    StringFormat sf = new StringFormat();
//                    sf.Alignment = StringAlignment.Center;
//                    sf.LineAlignment = StringAlignment.Far;
//                    g.DrawString("Нет фото", font, Brushes.Black,
//                        new RectangleF(0, 120, 200, 30), sf);
//                }
//            }
//            return bmp;
//        }
//    }
//}
using System.IO;
using System;
using System.Drawing;

namespace MYPROGECT
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Instructions { get; set; }
        public string Ingredients { get; set; }
        public string Category { get; set; }
        public Image Image { get; set; }
        public string ImagePath { get; set; }

        public Recipe(string name, string instructions, string ingredients, string category)
        {
            Name = name;
            Instructions = instructions;
            Ingredients = ingredients;
            Category = category;
            Image = CreateDefaultImage();
            ImagePath = string.Empty;
        }

        public Recipe(string name, string instructions, string ingredients, string category, string imagePath)
        {
            Name = name;
            Instructions = instructions;
            Ingredients = ingredients;
            Category = category;
            ImagePath = imagePath;

            LoadImage();
        }

        public void LoadImage()
        {
            try
            {
                if (!string.IsNullOrEmpty(ImagePath) && System.IO.File.Exists(ImagePath))
                {
                    Image = Image.FromFile(ImagePath);
                }
                else
                {
                    Image = CreateDefaultImage();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка загрузки изображения: {ex.Message}");
                Image = CreateDefaultImage();
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
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    g.DrawString("Нет изображения", font, Brushes.DarkGray,
                        new RectangleF(0, 0, 200, 150), sf);
                }
            }
            return bmp;
        }
    }
}
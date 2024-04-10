
using Draft_Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draft_Demo
{
    public partial class UserControlMaterial : UserControl
    {
        public event EventHandler<(Material, byte[])> onImageChange;
        private readonly Material _material1;
        public UserControlMaterial(Material material)
        {
            InitializeComponent();
            this._material1 = material;
            initMatrial(material);
        }

        public Material _material => _material1;

        private void initMatrial(Material material)
        {
            using (var db = new Draft_DemoContext())
            {


                var suuplerForreal = "";
                foreach (var suppler in material.MaterialSupplier)
                {
                    suuplerForreal += suppler.Supplier.Title + ", ";

                }


                TypeMaterial.Text = $"{material.MaterialType.Title}";
                NameOFMatrial.Text = $"{material.Title}";
                MinCount.Text = $"Минимальное количество: {material.MinCount}";
                Suppler.Text = $"Поставщики {suuplerForreal}";
                CountInStock.Text = $"Остаток {material.CountInStock}";
                Price.Text = $"Цена: {material.Cost}";

                if (material.Image != null)
                {
                    pictureBox1.Image = Image.FromStream(new MemoryStream(material.Image));
                }


            }



        }

        public event EventHandler<(Material, byte[])> ImageChanged
        {
            add
            {
                onImageChange += value;
            }
            remove
            {
                onImageChange -= value;
            }
        }



        private void AddPhotoBTN_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var image = File.ReadAllBytes(openFileDialog1.FileName);
            onImageChange?.Invoke(this,(_material1, image));
            pictureBox1.Image = Image.FromStream(new MemoryStream(image));
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            using (var db = new Draft_DemoContext())
            {
                
                Material material = db.Material.FirstOrDefault(x=>x.Id== _material1.Id) ;
              
                if (material != null)
                {
                    db.Material.Remove(material);
                    db.SaveChanges();
                    this.Hide();
                    
                }
            }
        }
    }
}

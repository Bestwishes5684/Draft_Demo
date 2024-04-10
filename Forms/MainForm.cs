
using Draft_Demo.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Draft_Demo.Forms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            FiltrcomboBox.DisplayMember = nameof(MaterialType.Title);



        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter();

        }

        private void MaterialImageChange(object sender, (Material, byte[]) e)
        {
            using (var db = new Draft_DemoContext())
            {
                e.Item1.Image = e.Item2;
                db.Entry(e.Item1).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            

            PanalLoading();
        }

        private void PanalLoading()
        {
            using (var db = new Draft_DemoContext())
            {
                var query = db.MaterialType.OrderBy(x => x.Title);

                FiltrcomboBox.Items.Clear();
                FiltrcomboBox.Items.AddRange(query.ToArray());
                FiltrcomboBox.SelectedIndex = 0;
            

                var materials = db.Material.Include(x => x.MaterialType).Include(x => x.MaterialSupplier).ThenInclude(x => x.Supplier).ToList();

                foreach (var material in materials)
                {


                    var materialview = new UserControlMaterial(material);
                    materialview.Parent = flowLayoutPanel1;
                    materialview.onImageChange += MaterialImageChange;

                }

            }
        }



        private void FiltrcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Filter();

        }

        private void Filter()
        {
            if (FiltrcomboBox.SelectedItem == null) return;
            var selectedTypeId = ((MaterialType)FiltrcomboBox.SelectedItem).Id;
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var visible = true;

                if (item is UserControlMaterial material)
                {


                    if (material._material.MaterialTypeId == selectedTypeId)


                    {
                        visible = false;
                    }


                    if (!(string.IsNullOrEmpty(SearchTextBox.Text) ||
                   material._material.Title.Contains(SearchTextBox.Text)))
                    {
                        visible = false;
                    }



                    material.Visible = visible;
                }




            }
        }

        private void SortcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();

            if (SortcomboBox1.SelectedIndex == 0)
            {
                using (var db = new Draft_DemoContext())
                {
                    


                    var materials = db.Material.Include(x => x.MaterialType).Include(x => x.MaterialSupplier).ThenInclude(x => x.Supplier).ToList();

                    foreach (var material in materials)
                    {


                        var materialview = new UserControlMaterial(material);
                        materialview.Parent = flowLayoutPanel1;
                        materialview.onImageChange += MaterialImageChange;

                    }

                }
            }


            if (SortcomboBox1.SelectedIndex == 1)
            {
                using (var db = new Draft_DemoContext())
                {
                    var query = db.MaterialType.OrderBy(x => x.Title);

                  

                    var materials = db.Material.Include(x => x.MaterialType).OrderBy(x=>x.Title).Include(x => x.MaterialSupplier).ThenInclude(x => x.Supplier).ToList();

                    foreach (var material in materials)
                    {


                        var materialview = new UserControlMaterial(material);
                        materialview.Parent = flowLayoutPanel1;
                        materialview.onImageChange += MaterialImageChange;

                    }

                }
            }

            if (SortcomboBox1.SelectedIndex == 2)
            {
                using (var db = new Draft_DemoContext())
                {
                  

                   

                    var materials = db.Material.Include(x => x.MaterialType).OrderBy(x => x.CountInStock).Include(x => x.MaterialSupplier).ThenInclude(x => x.Supplier).ToList();

                    foreach (var material in materials)
                    {


                        var materialview = new UserControlMaterial(material);
                        materialview.Parent = flowLayoutPanel1;
                        materialview.onImageChange += MaterialImageChange;

                    }

                }
            }

            if (SortcomboBox1.SelectedIndex == 3)
            {
                using (var db = new Draft_DemoContext())
                {
                



                    var materials = db.Material.Include(x => x.MaterialType).OrderBy(x => x.Cost).Include(x => x.MaterialSupplier).ThenInclude(x => x.Supplier).ToList();

                    foreach (var material in materials)
                    {


                        var materialview = new UserControlMaterial(material);
                        materialview.Parent = flowLayoutPanel1;
                        materialview.onImageChange += MaterialImageChange;

                    }

                }
            }



        }
    }
}

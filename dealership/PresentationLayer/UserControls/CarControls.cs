using BusinessLayer;
using ServiceLayer;


namespace PresentationLayer.UserControls
{
    public partial class CarControls : UserControl
    {
        private DbManager<Cars, int> dbManager = new DbManager<Cars, int>(ServiceLayer.ContextGenerator.GetCarsContext());
        private Cars selectedCar;


        public CarControls()
        {
            InitializeComponent();
            LoadCars();
        }

        private Cars GetSelectedCar()
        {
            return selectedCar;
        }

        private void LoadCars()
        {
            CarsDataGridView.DataSource = dbManager.ReadAll();
        }

        private void FillTextBoxes(Cars selectedCar)
        {
            if (selectedCar != null)
            {
                textBox1.Text = selectedCar.Model;

                textBox2.Text = selectedCar.Location.Name.ToString();
           

            }
        }

        private void ClearTextBoxes()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCar != null)
                {
                    dbManager.Delete(selectedCar.Id);
                    MessageBox.Show("Car deleted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    selectedCar = null;
                    LoadCars();
                }
                else
                {
                    MessageBox.Show("Choose Interest from the table! ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "@", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string model = textBox1.Text;
                Location location = new Location(Convert.ToString(textBox2.Text));
                Cars car = new Cars(model, location);
                dbManager.Create(car);
                MessageBox.Show("Car created successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCars();

                ClearTextBoxes();

                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "@", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("");
                return;
            }
            selectedCar = CarsDataGridView.Rows[e.RowIndex].DataBoundItem as Cars;
            FillTextBoxes(GetSelectedCar());
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                selectedCar.Model = textBox1.Text;
                selectedCar.Location= new Location(Convert.ToString(textBox2.Text));


                dbManager.Update(selectedCar);

                MessageBox.Show("Car updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "@", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

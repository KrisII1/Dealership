using BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class ClientControls : UserControl
    {

        private DbManager<Client, int> dbManager = new DbManager<Client, int>(ServiceLayer.ContextGenerator.GetClientContext());
        private Client selectedClient;


        public ClientControls()
        {
            InitializeComponent();
            LoadClients();
        }

        private Client GetSelectedClient()
        {
            return selectedClient;
        }

        private void LoadClients()
        {
            userDataGridView.DataSource = dbManager.ReadAll();
        }

        private void FillTextBoxes(Client selectedClient)
        {
            if (selectedClient != null)
            {
                name_txtBox.Text = selectedClient.FirstName;
                textBox1.Text = selectedClient.LastName;
                age_numericUpDown.Value = selectedClient.Age;
                textBox4.Text = selectedClient.Email;

            }
        }

        private void ClearTextBoxes()
        {
            name_txtBox.Text = string.Empty;
            textBox1.Text = string.Empty;
            age_numericUpDown.Value = 0;
            textBox4.Text = string.Empty;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("!");
                return;
            }
            selectedClient = userDataGridView.Rows[e.RowIndex].DataBoundItem as Client;
            FillTextBoxes(GetSelectedClient());
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstName = name_txtBox.Text;
                string LastName = textBox1.Text;
                decimal Age = age_numericUpDown.Value;
                string Email = textBox4.Text;
                Client client = new Client(FirstName, LastName, (int)Age, Email);
                dbManager.Create(client);
                MessageBox.Show("Client created successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadClients();

                ClearTextBoxes();

                name_txtBox.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "@", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                selectedClient.FirstName = name_txtBox.Text;
                selectedClient.LastName = textBox1.Text;
                selectedClient.Age = (int)age_numericUpDown.Value;
                selectedClient.Email = textBox4.Text;


                dbManager.Update(selectedClient);

                MessageBox.Show("Client updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadClients();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedClient != null)
                {
                    dbManager.Delete(selectedClient.ID);
                    MessageBox.Show("User removed successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    selectedClient = null;
                    LoadClients();
                }
                else
                {
                    MessageBox.Show("Choose client from the table!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
    }
}

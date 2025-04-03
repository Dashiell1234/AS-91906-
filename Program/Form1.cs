using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace MyWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(800, 400);
            LoadFromCSV();
        }

        public class Products
        {

            public string Product { get; set; } = string.Empty;
            public string Name { get; set; } = string.Empty;
            public string Notes { get; set; } = string.Empty;
            public int Quantity { get; set; }

        }

        private List<Products> records = new List<Products>();
        private string filePath = "data.csv";
    

            
            
        
        private void AddButton_click(object sender, EventArgs e)
        {
            try
            {
                string productType = ProductBox.Text;
                string productName = NameBox.Text;
                string productNotes = NotesBox.Text;
                int productQuantity = int.Parse(QuantityBox.Text);

                records.Add(new Products
                {
                    Product = productType,
                    Name = productName,
                    Notes = productNotes,
                    Quantity = productQuantity
                });


                SaveToCSV();

                MessageBox.Show($"successfully added: {productType},{productName},{productNotes},{productQuantity} to {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}");
            }

            
        }
         private void SaveToCSV()
            {
                using (var writer = new StreamWriter(filePath, false))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(records);
                }

            }
        private void LoadFromCSV()
        {
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<Products>().ToList(); // Load the existing data into the list
                }
            }
        }

     
    }
    
}

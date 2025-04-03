namespace MyWindowsFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox ProductBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox NotesBox;
        private System.Windows.Forms.NumericUpDown QuantityBox;
         private System.Windows.Forms.Button AddButton;




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
            
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.ProductBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NotesBox = new System.Windows.Forms.TextBox();
            this.QuantityBox = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // GroupBox
            this.groupBox.Controls.Add(this.ProductBox);
            this.groupBox.Controls.Add(this.NameBox);
            this.groupBox.Controls.Add(this.NotesBox);
            this.groupBox.Controls.Add(this.QuantityBox);
            this.groupBox.Controls.Add(this.AddButton);
            this.groupBox.Location = new System.Drawing.Point(20, 20);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(700, 50);

            this.ProductBox.Items.AddRange(new object[] { "Monitor", "Mouse", "KeyBord" });
            this.ProductBox.Location = new System.Drawing.Point(10, 20);
            this.ProductBox.Name = "comboBox";
            this.ProductBox.Size = new System.Drawing.Size(120, 21);
            this.ProductBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;

            this.NameBox.Location = new System.Drawing.Point(150, 20);
            this.NameBox.Name = "NameBox";
            this.NameBox.Text = "Name";
            this.NameBox.Size = new System.Drawing.Size(120, 20);

            this.NotesBox.Location = new System.Drawing.Point(300, 20);
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Text = "Notes";
            this.NotesBox.Size = new System.Drawing.Size(120, 20);

            this.QuantityBox.Location = new System.Drawing.Point(450, 20);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Text = "0";
            this.QuantityBox.Size = new System.Drawing.Size(40, 20);

            this.AddButton.Location = new System.Drawing.Point(510, 20);
            this.AddButton.Name = "AddButton";
            this.AddButton.Text = "Add";
            this.AddButton.Size = new System.Drawing.Size(80, 20);
            this.AddButton.Click += new System.EventHandler(this.AddButton_click);

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.groupBox);
            this.Text = "Windows Forms UI";
            this.ResumeLayout(false);
        }
    }
}

// Form1.Designer.cs
namespace Cashiering_Rasonable_IT13L
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // NOTE: All controls that your Form1.cs references are declared here.
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtAmount;

        private System.Windows.Forms.ComboBox cmbPaymentMethod;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;

        private System.Windows.Forms.DataGridView dataGridView1;

        /// <summary>
        /// Method required for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtID = new TextBox();
            txtCode = new TextBox();
            txtCustomer = new TextBox();
            txtDescription = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtAmount = new TextBox();
            cmbPaymentMethod = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnView = new Button();
            btnSearch = new Button();
            btnClear = new Button();
            btnPrint = new Button();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.5F, FontStyle.Bold); // Slightly smaller font
            label1.ForeColor = Color.FromArgb(45, 52, 54); // Darker text for better contrast
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 21;
            label1.Text = "Transaction ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 52, 54);
            label2.Location = new Point(30, 65);
            label2.Name = "label2";
            label2.Size = new Size(163, 21);
            label2.TabIndex = 20;
            label2.Text = "Transaction Code:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.5F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 52, 54);
            label3.Location = new Point(30, 105);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 19;
            label3.Text = "Customer Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.5F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 52, 54);
            label4.Location = new Point(30, 145);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 18;
            label4.Text = "Item:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.5F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 52, 54);
            label5.Location = new Point(30, 185);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 17;
            label5.Text = "Quantity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.5F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(45, 52, 54);
            label6.Location = new Point(30, 225);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 16;
            label6.Text = "Unit Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.5F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(45, 52, 54);
            label7.Location = new Point(30, 307);
            label7.Name = "label7";
            label7.Size = new Size(160, 21);
            label7.TabIndex = 15;
            label7.Text = "Payment Method:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.5F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(45, 52, 54);
            label8.Location = new Point(30, 269);
            label8.Name = "label8";
            label8.Size = new Size(79, 21);
            label8.TabIndex = 23;
            label8.Text = "Amount:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.White; // Use pure white for calendar
            dateTimePicker1.Font = new Font("Century Gothic", 10F);
            dateTimePicker1.Location = new Point(220, 347);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 28);
            dateTimePicker1.TabIndex = 14;
            // 
            // txtID
            // 
            txtID.BackColor = Color.White; // Pure white for textboxes
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Century Gothic", 10F);
            txtID.Location = new Point(220, 25);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(150, 28);
            txtID.TabIndex = 13;
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Font = new Font("Century Gothic", 10F);
            txtCode.Location = new Point(220, 65);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(150, 28);
            txtCode.TabIndex = 12;
            // 
            // txtCustomer
            // 
            txtCustomer.BackColor = Color.White;
            txtCustomer.BorderStyle = BorderStyle.FixedSingle;
            txtCustomer.Font = new Font("Century Gothic", 10F);
            txtCustomer.Location = new Point(220, 105);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(260, 28);
            txtCustomer.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Century Gothic", 10F);
            txtDescription.Location = new Point(220, 145);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(260, 28);
            txtDescription.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.White;
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Century Gothic", 10F);
            txtQuantity.Location = new Point(220, 185);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 28);
            txtQuantity.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = Color.White;
            txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            txtUnitPrice.Font = new Font("Century Gothic", 10F);
            txtUnitPrice.Location = new Point(220, 225);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(150, 28);
            txtUnitPrice.TabIndex = 8;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.White;
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Font = new Font("Century Gothic", 10F);
            txtAmount.Location = new Point(220, 263);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(150, 28);
            txtAmount.TabIndex = 22;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.BackColor = Color.White;
            cmbPaymentMethod.Font = new Font("Century Gothic", 10F);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Card", "Online" }); // Added "Online" for more options
            cmbPaymentMethod.Location = new Point(220, 307);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(150, 29);
            cmbPaymentMethod.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 204, 113); // Green (Success)
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(30, 413);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(52, 152, 219); // Blue (Info/Action)
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(160, 413);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60); // Red (Danger)
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(290, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(149, 165, 166); // Muted Blue-Gray
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(30, 463);
            btnView.Name = "btnView";
            btnView.Size = new Size(120, 40);
            btnView.TabIndex = 3;
            btnView.Text = "View All";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 73, 94); // Dark Blue-Gray
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1057, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(189, 195, 199); // Light Gray
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(160, 463);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 40);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(155, 89, 182); // Purple
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(290, 463);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(150, 40);
            btnPrint.TabIndex = 24;
            btnPrint.Text = "Print Receipt";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94); // Dark Blue-Gray header
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10F, FontStyle.Bold); // Slightly smaller header font
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 35; // Slightly taller header
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F); // Slightly smaller row font
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(178, 190, 195); // Lighter gray for selection
            dataGridViewCellStyle2.SelectionForeColor = Color.Black; // Black text on selection for contrast
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(507, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(803, 466);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Century Gothic", 10F);
            txtSearch.Location = new Point(591, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(446, 28);
            txtSearch.TabIndex = 25;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(245, 246, 250); // Lighter, modern background
            ClientSize = new Size(1322, 580);
            Controls.Add(txtSearch);
            Controls.Add(txtAmount);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnPrint);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtDescription);
            Controls.Add(txtCustomer);
            Controls.Add(txtCode);
            Controls.Add(txtID);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Cashiering Transaction System";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
    }
}
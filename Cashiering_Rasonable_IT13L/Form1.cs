using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Cashiering_Rasonable_IT13L
{
    public partial class Form1 : Form
    {
        DB_Connections db = new DB_Connections();

        // Add PrintDocument and PrintPreviewDialog for printing
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();

        public Form1()
        {
            InitializeComponent();

            txtAmount.ReadOnly = true;
            txtCode.ReadOnly = true;

            LoadTransactions();
            GenerateTransactionCode();

            txtQuantity.TextChanged += CalculateAmount;
            txtUnitPrice.TextChanged += CalculateAmount;

            // Initialize print document settings
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            btnPrint.Click += btnPrint_Click; // Wire up the print button click event
        }

        // Auto-calculate Amount
        private void CalculateAmount(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtQuantity.Text, out decimal qty) &&
                decimal.TryParse(txtUnitPrice.Text, out decimal price))
            {
                txtAmount.Text = (qty * price).ToString("0.00");
            }
            else
            {
                txtAmount.Text = "0.00";
            }
        }

        // Auto-generate transaction code
        private void GenerateTransactionCode()
        {
            try
            {
                db.OpenConn();
                string sql = "SELECT TOP 1 TransactionCode FROM dbo.Cashiering_TransactionsTbl ORDER BY TransactionID DESC";
                using (SqlCommand cmd = new SqlCommand(sql, db.GetConn()))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string lastCode = result.ToString();
                        int number = int.Parse(lastCode.Substring(3)) + 1;
                        txtCode.Text = "TRX" + number.ToString("D4");
                    }
                    else
                    {
                        txtCode.Text = "TRX0001";
                    }
                }
            }
            catch
            {
                txtCode.Text = "TRX0001";
            }
            finally
            {
                db.CloseConn();
            }
        }

        // Load all records
        private void LoadTransactions()
        {
            try
            {
                db.OpenConn();
                string sql = @"SELECT TransactionID, TransactionCode, CustomerName, Description,
                               Quantity, UnitPrice, Amount, PaymentMethod, TransactionDate
                               FROM dbo.Cashiering_TransactionsTbl
                               ORDER BY TransactionID DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, db.GetConn());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
            finally
            {
                db.CloseConn();
            }
        }

        // --- ADD TRANSACTION ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text == "" || txtDescription.Text == "" ||
                txtQuantity.Text == "" || txtUnitPrice.Text == "" ||
                cmbPaymentMethod.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!decimal.TryParse(txtQuantity.Text, out decimal qty))
            {
                MessageBox.Show("Quantity must be a number");
                return;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price))
            {
                MessageBox.Show("Unit Price must be a number");
                return;
            }

            decimal amount = qty * price;

            try
            {
                db.OpenConn();
                using (SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO dbo.Cashiering_TransactionsTbl
                    (TransactionCode, CustomerName, Description, Quantity, UnitPrice, Amount, PaymentMethod, TransactionDate)
                    VALUES (@Code, @Customer, @Desc, @Qty, @Price, @Amount, @Method, @Date)",
                    db.GetConn()))
                {
                    cmd.Parameters.AddWithValue("@Code", txtCode.Text);
                    cmd.Parameters.AddWithValue("@Customer", txtCustomer.Text);
                    cmd.Parameters.AddWithValue("@Desc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@Qty", qty);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Method", cmbPaymentMethod.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Added!");

                    LoadTransactions();
                    ClearFields();
                    GenerateTransactionCode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Error: " + ex.Message);
            }
            finally
            {
                db.CloseConn();
            }
        }

        // --- UPDATE TRANSACTION ---
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Select a record from table first!");
                return;
            }

            try
            {
                db.OpenConn();
                using (SqlCommand cmd = new SqlCommand(
                    @"UPDATE dbo.Cashiering_TransactionsTbl SET 
                    CustomerName=@Customer, Description=@Desc, Quantity=@Qty,
                    UnitPrice=@Price, Amount=@Amount, PaymentMethod=@Method, TransactionDate=@Date
                    WHERE TransactionID=@ID", db.GetConn()))
                {
                    cmd.Parameters.AddWithValue("@Customer", txtCustomer.Text);
                    cmd.Parameters.AddWithValue("@Desc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@Qty", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@Price", txtUnitPrice.Text);
                    cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                    cmd.Parameters.AddWithValue("@Method", cmbPaymentMethod.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated!");

                    LoadTransactions();
                    ClearFields();
                    GenerateTransactionCode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
            }
            finally
            {
                db.CloseConn();
            }
        }

        // --- DELETE ---
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Select a record to delete.");
                return;
            }

            try
            {
                db.OpenConn();
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM dbo.Cashiering_TransactionsTbl WHERE TransactionID=@ID", db.GetConn()))
                {
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Record Deleted!");
                LoadTransactions();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error: " + ex.Message);
            }
            finally
            {
                db.CloseConn();
            }
        }

        // --- VIEW ALL ---
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        // --- SEARCH: now uses txtSearch ---
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                MessageBox.Show("Enter a name to search.");
                return;
            }

            try
            {
                db.OpenConn();
                string sql = @"SELECT * FROM dbo.Cashiering_TransactionsTbl 
                               WHERE CustomerName LIKE @Search";

                SqlCommand cmd = new SqlCommand(sql, db.GetConn());
                cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text.Trim() + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No matching customer found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
            finally
            {
                db.CloseConn();
            }
        }

        // --- CLEAR FORM ---
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            GenerateTransactionCode();
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtCustomer.Clear();
            txtDescription.Clear();
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            txtAmount.Text = "0.00";
            cmbPaymentMethod.SelectedIndex = -1;
        }

        // When clicking table row, load data into fields
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCustomer.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtUnitPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmbPaymentMethod.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            }
            catch { }
        }

        // --- PRINT RECEIPT FUNCTIONALITY ---
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Please select a transaction to print a receipt for.");
                return;
            }

            // Generate the receipt string
            string receiptContent = GenerateReceiptContent();

            // Display the receipt in a MessageBox
            MessageBox.Show(receiptContent, "Receipt Preview", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // You can also uncomment the following lines to actually show a print preview dialog
            // printPreviewDialog1.Document = printDocument1;
            // printPreviewDialog1.ShowDialog();
        }

        private string GenerateReceiptContent()
        {
            string receipt = "";
            receipt += "--------------------------------------\n";
            receipt += "          CASHIERING RECEIPT          \n";
            receipt += "--------------------------------------\n";
            receipt += $"Transaction Code: {txtCode.Text}\n";
            receipt += $"Date: {dateTimePicker1.Value.ToShortDateString()}\n";
            receipt += $"Customer Name: {txtCustomer.Text}\n";
            receipt += "--------------------------------------\n";
            receipt += $"Item: {txtDescription.Text}\n";
            receipt += $"Quantity: {txtQuantity.Text}\n";
            receipt += $"Unit Price: {decimal.Parse(txtUnitPrice.Text).ToString("C")}\n";
            receipt += "--------------------------------------\n";
            receipt += $"Total Amount: {decimal.Parse(txtAmount.Text).ToString("C")}\n";
            receipt += $"Payment Method: {cmbPaymentMethod.Text}\n";
            receipt += "--------------------------------------\n";
            receipt += "          THANK YOU FOR YOUR          \n";
            receipt += "             PURCHASE!              \n";
            receipt += "--------------------------------------\n";
            return receipt;
        }

        // This event handler is for actual printing, not just displaying in a message box.
        // It will be triggered if printPreviewDialog1.ShowDialog() or printDocument1.Print() is called.
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string receiptContent = GenerateReceiptContent();
            Font font = new Font("Consolas", 10); // A monospaced font is good for receipts
            float lineHeight = font.GetHeight(e.Graphics);
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            foreach (string line in receiptContent.Split('\n'))
            {
                e.Graphics.DrawString(line, font, Brushes.Black, x, y);
                y += lineHeight;
            }
        }
    }
}
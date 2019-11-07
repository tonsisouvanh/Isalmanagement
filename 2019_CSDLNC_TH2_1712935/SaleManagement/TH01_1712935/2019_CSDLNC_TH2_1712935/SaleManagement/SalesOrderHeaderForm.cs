using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class SalesOrderHeaderForm : Form
    {
        DataConnection dtc = new DataConnection();
        public SalesOrderHeaderForm()
        {
            MessageBox.Show("Sales order record can not be delete","Warning message!");
            InitializeComponent();
            LoadSalesOrderHeaderList();
            LoadCustomerList();
        }

        public void LoadSalesOrderHeaderList()
        {
            SqlConnection con = dtc.getConnect();

            string query = "SELECT * FROM n_SalesOrderHeader";
            
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            con.Open();

            adapter.Fill(dt);

            con.Close();
            dataGridView_SalesOrderHeaderList.DataSource = dt;
        }
        public void LoadCustomerList()
        {
            SqlConnection con = dtc.getConnect();

            string query = "SELECT * FROM n_Customer";
            
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            con.Open();

            adapter.Fill(dt);

            con.Close();

            dataGridView_Customer.DataSource = dt;


        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSeeDetail_Click(object sender, EventArgs e)
        {
            FormSalesOrderDetail f = new FormSalesOrderDetail();
            f.ShowDialog();
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string procName = "usp_ThemHoaDon";
            SqlConnection con = dtc.getConnect();
            try
            {
                SqlCommand command = new SqlCommand(procName, con);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@SalesOrderID", SqlDbType.Int)).Value = int.Parse(textBoxSaleOrderID.Text);

                command.Parameters.Add(new SqlParameter("@RevisionNumber", SqlDbType.TinyInt)).Value = byte.Parse(textBoxRevisionNumber.Text);

                command.Parameters.Add(new SqlParameter("@DueDate", SqlDbType.DateTime)).Value = DateTime.Parse(dateTimePickerDue.Text);

                command.Parameters.Add(new SqlParameter("@ShipDate", SqlDbType.DateTime)).Value = DateTime.Parse(dateTimePickerShip.Text);

                command.Parameters.Add(new SqlParameter("@Status", SqlDbType.TinyInt)).Value = byte.Parse(textBoxStatus.Text);

                command.Parameters.Add(new SqlParameter("@OnlineOrderFlag", SqlDbType.Bit)).Value = bool.Parse(textBoxOnlineOrderFlag.Text);

                string nvarPur = textBoxPurchaseOrderNumber.Text;
                command.Parameters.Add(new SqlParameter("@PurchaseOrderNumber", SqlDbType.NVarChar)).Value = nvarPur;

                string nvarAccNo = textBoxAccountNumber.Text;
                command.Parameters.Add(new SqlParameter("@AccountNumber", SqlDbType.NVarChar)).Value = nvarAccNo;

                command.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int)).Value = int.Parse(textBoxCustomerID.Text);

                command.Parameters.Add(new SqlParameter("@SalesPersonID", SqlDbType.Int)).Value = int.Parse(textBoxSalePersonID.Text);

                command.Parameters.Add(new SqlParameter("@TerritoryID", SqlDbType.Int)).Value = int.Parse(textBoxTerritoryID.Text);

                command.Parameters.Add(new SqlParameter("@BillToAddressID", SqlDbType.Int)).Value = int.Parse(textBoxBillToAddress.Text);

                command.Parameters.Add(new SqlParameter("@ShipToAddressID", SqlDbType.Int)).Value = int.Parse(textBoxShipToAddress.Text);

                command.Parameters.Add(new SqlParameter("@ShipMethodID", SqlDbType.Int)).Value = int.Parse(textBoxShipToMethod.Text);

                command.Parameters.Add(new SqlParameter("@CreditCardID", SqlDbType.Int)).Value = int.Parse(textBoxCreditCardID.Text);

                string varchCreditApproval = textBoxCreditCardApprovalCode.Text;
                command.Parameters.Add(new SqlParameter("@CreditCardApprovalCode", SqlDbType.VarChar)).Value = varchCreditApproval;

                command.Parameters.Add(new SqlParameter("@CurrencyRateID", SqlDbType.Int)).Value = int.Parse(textBoxCurrencyRateID.Text);

                command.Parameters.Add(new SqlParameter("@SubTotal", SqlDbType.Money)).Value = decimal.Parse(textBoxSubtotal.Text);

                command.Parameters.Add(new SqlParameter("@TaxAmt", SqlDbType.Money)).Value = decimal.Parse(textBoxTaxAmt.Text);

                command.Parameters.Add(new SqlParameter("@Freight", SqlDbType.Money)).Value = decimal.Parse(textBoxFreight.Text);

                string nvarComment = textBoxComment.Text;
                command.Parameters.Add(new SqlParameter("@Comment", SqlDbType.NVarChar)).Value = nvarComment;

                con.Open();

                command.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                con.Close();
            }
        }

        private void dataGridView_SalesOrderHeaderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_SalesOrderHeaderList.Rows[e.RowIndex];

                textBoxSaleOrderID.Text = row.Cells["SalesOrderID"].Value.ToString();

                textBoxRevisionNumber.Text = row.Cells["RevisionNumber"].Value.ToString();

                dateTimePickerDue.Text = row.Cells["DueDate"].Value.ToString();

                dateTimePickerShip.Text = row.Cells["ShipDate"].Value.ToString();

                textBoxStatus.Text = row.Cells["Status"].Value.ToString();

                textBoxOnlineOrderFlag.Text = row.Cells["OnlineOrderFlag"].Value.ToString();

                textBoxPurchaseOrderNumber.Text = row.Cells["PurchaseOrderNumber"].Value.ToString();

                textBoxAccountNumber.Text = row.Cells["AccountNumber"].Value.ToString();

                textBoxCustomerID.Text = row.Cells["CustomerID"].Value.ToString();

                textBoxSalePersonID.Text = row.Cells["SalesPersonID"].Value.ToString();

                textBoxTerritoryID.Text = row.Cells["TerritoryID"].Value.ToString();

                textBoxBillToAddress.Text = row.Cells["BillToAddressID"].Value.ToString();

                textBoxShipToAddress.Text = row.Cells["ShiptoAddressID"].Value.ToString();

                textBoxShipToMethod.Text = row.Cells["ShipMethodID"].Value.ToString();

                textBoxCreditCardID.Text = row.Cells["CreditCardID"].Value.ToString();

                textBoxCreditCardApprovalCode.Text = row.Cells["CreditCardApprovalCode"].Value.ToString();

                textBoxCurrencyRateID.Text = row.Cells["CurrencyRateID"].Value.ToString();

                textBoxSubtotal.Text = row.Cells["SubTotal"].Value.ToString();

                textBoxTaxAmt.Text = row.Cells["TaxAmt"].Value.ToString();

                textBoxFreight.Text = row.Cells["Freight"].Value.ToString();

                textBoxComment.Text = row.Cells["Comment"].Value.ToString();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }
        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
        
        private void btSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = dtc.getConnect();
            try
            {
                SqlCommand com = new SqlCommand("usp_TimKiemHoaDon", con);
                DataTable dt = new DataTable();

                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add(new SqlParameter("@personID", SqlDbType.Int)).Value = int.Parse(txtbPersonID.Text);

                com.Parameters.Add(new SqlParameter("@tu", SqlDbType.DateTime)).Value = DateTime.Parse(dateTimePickerFrom.Text);

                com.Parameters.Add(new SqlParameter("@den", SqlDbType.DateTime)).Value = DateTime.Parse(dateTimePickerTo.Text);

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                dataGridView_SalesOrderHeaderList.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("The Sales order you search for is not exist");
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = dtc.getConnect();
            string procName = "usp_ThemCustomer";
            try
            {
                SqlCommand command = new SqlCommand(procName, con);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int)).Value = int.Parse(txtCustomerID.Text);
                command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int)).Value = int.Parse(txtPersonID.Text);
                command.Parameters.Add(new SqlParameter("@StoreID", SqlDbType.Int)).Value = int.Parse(txtStoreId.Text);
                command.Parameters.Add(new SqlParameter("@TerritoryID", SqlDbType.Int)).Value = int.Parse(txtTerritoryID.Text);

                con.Open();

                command.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
            con.Close();
        }
       
        private void btClearCustomer_Click(object sender, EventArgs e)
        {
            ClearTextBoxesCustomer(this.Controls);
        }
        public void ClearTextBoxesCustomer(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        private void dataGridView_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Customer.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();

                txtPersonID.Text = row.Cells["PersonID"].Value.ToString();
                         
                txtStoreId.Text = row.Cells["StoreID"].Value.ToString();

                txtTerritoryID.Text = row.Cells["TerritoryID"].Value.ToString();            
            }
        }

        private void btLoadSalesOrderList_Click(object sender, EventArgs e)
        {
            LoadSalesOrderHeaderList();
        }

        private void btLoadCustomerList_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

    }
}

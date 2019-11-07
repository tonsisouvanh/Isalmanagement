using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SaleManagement
{
    public partial class FormSalesOrderDetail : Form
    {
        DataConnection dtc = new DataConnection();
        public FormSalesOrderDetail()
        {
            MessageBox.Show("Sales order detail record can not be delete!","Warning message");
            InitializeComponent();
            LoadSalesOrderDetailList();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadSalesOrderDetailList()
        {
            SqlConnection con = dtc.getConnect();

            string query = "SELECT * FROM n_SalesOrderDetail";
            
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            con.Open();

            adapter.Fill(dt);

            con.Close();
            dataGridViewSalesOrderDetail.DataSource = dt;
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            SalesOrderHeaderForm f = new SalesOrderHeaderForm();
            f.ShowDialog();
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string procName = "usp_ThemHoaDonCT";
            SqlConnection con = dtc.getConnect();
            try
            {
                SqlCommand command = new SqlCommand(procName, con);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@SalesOrderID", SqlDbType.Int)).Value = int.Parse(txtbSaelsOrderID.Text);

                command.Parameters.Add(new SqlParameter("@SalesOrderDetailID", SqlDbType.Int)).Value = int.Parse(txtbSalesOrderIDDetail.Text);

                string CarrierTN = txtbCarrier.Text;
                command.Parameters.Add(new SqlParameter("@CarrierTrackingNumber", SqlDbType.NVarChar)).Value = CarrierTN;

                command.Parameters.Add(new SqlParameter("@OrderQty", SqlDbType.SmallInt)).Value = short.Parse(txtbOrderQty.Text);

                command.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int)).Value = int.Parse(txtbProdctID.Text);

                command.Parameters.Add(new SqlParameter("@SpecialOfferID", SqlDbType.Int)).Value = int.Parse(txtbSpecialID.Text);

                command.Parameters.Add(new SqlParameter("@UnitPrice", SqlDbType.Money)).Value = decimal.Parse(txtbUnitPrice.Text);

                command.Parameters.Add(new SqlParameter("@UnitPriceDiscount", SqlDbType.Money)).Value = decimal.Parse(txtbDiscount.Text);

                con.Open();

                command.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btClear_Click(object sender, EventArgs e)
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
                    ClearTextBoxesCustomer(ctrl.Controls);
                }
            }
        }
    

        private void dataGridViewSalesOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewSalesOrderDetail.Rows[e.RowIndex];

                txtbSaelsOrderID.Text = row.Cells["SalesOrderID"].Value.ToString();

                txtbSalesOrderIDDetail.Text = row.Cells["SalesOrderDetailID"].Value.ToString();

                txtbCarrier.Text = row.Cells["CarrierTrackingNumber"].Value.ToString();

                txtbOrderQty.Text = row.Cells["OrderQty"].Value.ToString();

                txtbProdctID.Text = row.Cells["ProductID"].Value.ToString();

                txtbSpecialID.Text = row.Cells["SpecialOfferID"].Value.ToString();

                txtbUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();

                txtbDiscount.Text = row.Cells["UnitPriceDiscount"].Value.ToString();
            }
        }

        private void btLoadDetailList_Click(object sender, EventArgs e)
        {
            LoadSalesOrderDetailList();
        }
    }
}

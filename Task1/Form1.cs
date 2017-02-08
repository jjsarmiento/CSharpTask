using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region FIELDS
        #region CONSTANTS
        /*<summary>
            constants
        </summary>*/
        private const int GENDER_MALE   = 0;
        private const int GENDER_FEMALE = 1;

        private const string GENDER_MALE_STRING = "MALE";
        private const string GENDER_FEMALE_STRING = "FEMALE";
        private const string GENDER_BLANK = null;
        #endregion CONSTANTS

        /*<summary>
            fields for customer data
        </summary>*/

        private static string cust_first_name;
        private static string cust_mid_name;
        private static string cust_last_name;
        private static int cust_age;
        private static int cust_gender;

        private List<TextBox> textBox = new List<TextBox>();
        #endregion FIELDS

        #region PROPERTIES
        /*<summary>
            GET and SET `first_name` variable values 
        </summary>*/
        public string customerFirstName
        {
            get { return cust_first_name; }
            set { cust_first_name = value; }
        }

        /*<summary>
            GET and SET `mid_name` variable values 
        </summary>*/
        public string customerMidName
        {
            get { return cust_mid_name; }
            set { cust_mid_name = value; }
        }

        /*<summary>
            GET and SET `last_name` variable values 
        </summary>*/
        public string customerLastName
        {
            get { return cust_last_name; }
            set { cust_last_name = value; }
        }

        /*<summary>
            GET and SET `age` variable values 
        </summary>*/
        public int customerAge
        {
            get { return cust_age; }
            set { cust_age = value; }
        }

        /*<summary>
            GET and SET `gender` variable values 
        </summary>*/
        public int customerGender
        {
            get { return cust_gender; }
            set { cust_gender = value; }
        }

        /*<summary>
            GET and SET `id` variable values 
        </summary>*/
        public int customerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        #endregion PROPERTIES

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customers_dbDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customers_dbDataSet.customers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(getFirstName()) || String.IsNullOrEmpty(getMidName()) ||
                    String.IsNullOrEmpty(getLastName()) || String.IsNullOrEmpty(getAge().ToString()) ||
                    String.IsNullOrEmpty(getGender().ToString())
                    )
                {
                    MessageBox.Show("Please provide complete details for the fields.");
                }else
                {
                    this.customersTableAdapter.Insert(
                        getFirstName(),
                        getMidName(),
                        getLastName(),
                        getAge(),
                        getGender()
                    );
                    MessageBox.Show("Customer Added!\n"
                        + "Name : " + customerFirstName + " " + customerMidName + " " + customerLastName
                        + "\nAge : " + customerAge
                        + "\nGender : " + (customerGender == 1 ? "MALE" : "FEMALE"));
                    clearText();
                }
                this.customersTableAdapter.Fill(this.customers_dbDataSet.customers);
            }
            catch(Exception x)
            {
                MessageBox.Show("INSERT OPERATION FAILED");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void txt_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                labelInputID.Text = dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txt_first_name.Text = dataGridView2.Rows[e.RowIndex].Cells["first_name"].Value.ToString();
                txt_mid_name.Text = dataGridView2.Rows[e.RowIndex].Cells["mid_name"].Value.ToString();
                txt_last_name.Text = dataGridView2.Rows[e.RowIndex].Cells["last_name"].Value.ToString();
                txt_age.Text = dataGridView2.Rows[e.RowIndex].Cells["age"].Value.ToString();
                cmb_gender.Text = dataGridView2.Rows[e.RowIndex].Cells["gender"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("SELECTION HAS FAILED");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView2.SelectedCells.Count == 0)
                {
                    MessageBox.Show("No customer has been selected");
                }
                else if (dataGridView2.RowCount == 0)
                {
                    MessageBox.Show("No items in the database");
                }else
                {
                    this.customersTableAdapter.Update(
                        getFirstName(),
                        getMidName(),
                        getLastName(),
                        getAge(),
                        getGender(),
                        int.Parse(labelInputID.Text)
                    );
                }
                
                this.customersTableAdapter.Fill(this.customers_dbDataSet.customers);
            }
            catch
            {
                MessageBox.Show("UPDATE OPERATION FAILED");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView2.SelectedCells.Count > 0)
                {
                    var confirmDelete = MessageBox.Show("Are you sure to delete this customer?", "Delete Customer Confrimation", MessageBoxButtons.YesNo);
                    if (confirmDelete == DialogResult.Yes)
                    {
                        this.customersTableAdapter.Delete(
                            int.Parse(labelInputID.Text)
                        );
                        clearText();
                        this.customersTableAdapter.Fill(this.customers_dbDataSet.customers);
                    }
                }
                else if (dataGridView2.RowCount == 0)
                {
                    MessageBox.Show("No items in the database.");
                }
                else
                {
                    MessageBox.Show("No customer has been selected.");
                }
            }
            catch
            {
                MessageBox.Show("DELETE OPERATION FAILED");
            }
        }

        private void txt_first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PREVENT_SPECIAL_CHAR(e);
        }

        private void txt_last_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PREVENT_SPECIAL_CHAR(e);
        }

        private void txt_mid_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = PREVENT_SPECIAL_CHAR(e);
        }

        #region METHODS
        /*<summary>
            GET `customer_first_name` value from `txt_first_name`
        </summary>*/
        private string getFirstName()
        {
            customerFirstName = txt_first_name.Text.Trim();
            return customerFirstName;
        }

        /*<summary>
            GET `customer_mid_name` value from `txt_mid_name`
        </summary>*/
        private string getMidName()
        {
            customerMidName = txt_mid_name.Text.Trim();
            return customerMidName;
        }

        /*<summary>
            GET `cust_last_name` value from `txt_mid_name`
        </summary>*/
        private string getLastName()
        {
            customerFirstName = txt_last_name.Text.Trim();
            return customerFirstName;
        }

        /*<summary>
            GET `customer_age` value from `txt_age`
        </summary>*/
        private int getAge()
        {
            customerAge = int.Parse(txt_age.Text.Trim());
            return customerAge;
        }

        /*<summary>
            GET `customer_gender` value from `txt_mid_name`
        </summary>*/
        private int getGender()
        {
            customerGender = cmb_gender.Text.Trim() == GENDER_MALE_STRING ? 0 : 1;
            return customerGender;
        }

        /*<summary>
            REMOVES CONTENT FROM TEXT FIELDS
        </summary>*/
        private void clearText()
        {
            labelInputID.Text = "N/A";
            textBox.Clear();
            textBox.Add(txt_first_name);
            textBox.Add(txt_mid_name);
            textBox.Add(txt_last_name);
            textBox.Add(txt_age);
            cmb_gender.Text = GENDER_BLANK;

            foreach (TextBox textList in textBox)
            {
                textList.Clear();
            }
        }

        /*<summary>
            Prevents any special characters (except space and backspace) to be inputted to the text field
        </summary>*/
        private bool PREVENT_SPECIAL_CHAR(KeyPressEventArgs e)
        {
            if (!new Regex("[a-zA-Z0-9 \b]").IsMatch(e.KeyChar.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion METHODS
    }
}

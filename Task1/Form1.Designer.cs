namespace Task1
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.txt_mid_name = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mid_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customers_dbDataSet = new Task1.customers_dbDataSet();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.labelInputID = new System.Windows.Forms.Label();
            this.customersTableAdapter = new Task1.customers_dbDataSetTableAdapters.customersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(60, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "First Name";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Location = new System.Drawing.Point(19, 69);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(58, 13);
            this.lblSname.TabIndex = 2;
            this.lblSname.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middle Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // txt_first_name
            // 
            this.txt_first_name.Location = new System.Drawing.Point(84, 40);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(198, 20);
            this.txt_first_name.TabIndex = 6;
            this.txt_first_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_first_name_KeyPress);
            // 
            // txt_last_name
            // 
            this.txt_last_name.Location = new System.Drawing.Point(84, 66);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(198, 20);
            this.txt_last_name.TabIndex = 7;
            this.txt_last_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_last_name_KeyPress);
            // 
            // txt_mid_name
            // 
            this.txt_mid_name.Location = new System.Drawing.Point(84, 92);
            this.txt_mid_name.Name = "txt_mid_name";
            this.txt_mid_name.Size = new System.Drawing.Size(198, 20);
            this.txt_mid_name.TabIndex = 8;
            this.txt_mid_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mid_name_KeyPress);
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(84, 119);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(198, 20);
            this.txt_age.TabIndex = 9;
            this.txt_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_age_KeyPress);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(84, 172);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(96, 23);
            this.btn_insert.TabIndex = 11;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(186, 172);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(96, 23);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(84, 201);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(96, 23);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "DELETE";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(186, 201);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 23);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.first_name,
            this.mid_name,
            this.last_name,
            this.age,
            this.gender});
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(291, 13);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(644, 257);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "first_name";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // mid_name
            // 
            this.mid_name.DataPropertyName = "mid_name";
            this.mid_name.HeaderText = "mid_name";
            this.mid_name.Name = "mid_name";
            this.mid_name.ReadOnly = true;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "last_name";
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "sGender";
            this.gender.HeaderText = "gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "customers";
            this.bindingSource1.DataSource = this.customers_dbDataSet;
            // 
            // customers_dbDataSet
            // 
            this.customers_dbDataSet.DataSetName = "customers_dbDataSet";
            this.customers_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_gender
            // 
            this.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmb_gender.Location = new System.Drawing.Point(84, 146);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(198, 21);
            this.cmb_gender.TabIndex = 16;
            // 
            // labelInputID
            // 
            this.labelInputID.AutoSize = true;
            this.labelInputID.Location = new System.Drawing.Point(84, 14);
            this.labelInputID.Name = "labelInputID";
            this.labelInputID.Size = new System.Drawing.Size(27, 13);
            this.labelInputID.TabIndex = 17;
            this.labelInputID.Text = "N/A";
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 279);
            this.Controls.Add(this.labelInputID);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_mid_name);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Name = "Form1";
            this.Text = "Task 1 by Jan Sarmiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_first_name;
        private System.Windows.Forms.TextBox txt_last_name;
        private System.Windows.Forms.TextBox txt_mid_name;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_update;
        //private customer_dbDataSet customer_dbDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        //private customer_dbDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        //private customer_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        //private customer_dbDataSet1 customer_dbDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        //private customer_dbDataSet1TableAdapters.customersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private customers_dbDataSet customers_dbDataSet;
        private System.Windows.Forms.BindingSource newtableBindingSource;
        //private customers_dbDataSetTableAdapters.new_tableTbleAdapter new_tableTableAdapter;
        //private customers_dbDataSet1 customers_dbDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private customers_dbDataSet customers_dbDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private customers_dbDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.Label labelInputID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mid_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        //private customers_dbDataSet1TableAdapters.customersTableAdapter customersTableAdapter2;
    }
}


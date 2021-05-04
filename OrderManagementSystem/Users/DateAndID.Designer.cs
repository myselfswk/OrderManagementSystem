
namespace OrderManagementSystem.Users
{
    partial class DateAndID
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.orderManagementSystemDataSet = new OrderManagementSystem.OrderManagementSystemDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new OrderManagementSystem.OrderManagementSystemDataSetTableAdapters.CustomerTableAdapter();
            this.addNewOrder = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.orderManagementSystemDataSet1 = new OrderManagementSystem.OrderManagementSystemDataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new OrderManagementSystem.OrderManagementSystemDataSet1TableAdapters.ProductTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.customerBindingSource;
            this.comboBox1.DisplayMember = "customerName";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "id";
            // 
            // orderManagementSystemDataSet
            // 
            this.orderManagementSystemDataSet.DataSetName = "OrderManagementSystemDataSet";
            this.orderManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.orderManagementSystemDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // addNewOrder
            // 
            this.addNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewOrder.Location = new System.Drawing.Point(131, 336);
            this.addNewOrder.Name = "addNewOrder";
            this.addNewOrder.Size = new System.Drawing.Size(185, 64);
            this.addNewOrder.TabIndex = 2;
            this.addNewOrder.Text = "Add New Order";
            this.addNewOrder.UseVisualStyleBackColor = true;
            this.addNewOrder.Click += new System.EventHandler(this.addNewOrder_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.productBindingSource;
            this.comboBox2.DisplayMember = "productName";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(131, 192);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(317, 33);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "id";
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderQuantity.Location = new System.Drawing.Point(131, 265);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(317, 31);
            this.txtOrderQuantity.TabIndex = 4;
            // 
            // orderManagementSystemDataSet1
            // 
            this.orderManagementSystemDataSet1.DataSetName = "OrderManagementSystemDataSet1";
            this.orderManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.orderManagementSystemDataSet1;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.productBindingSource;
            this.listBox1.DisplayMember = "productName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(591, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(248, 290);
            this.listBox1.TabIndex = 5;
            this.listBox1.ValueMember = "id";
            // 
            // DateAndID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 482);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtOrderQuantity);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.addNewOrder);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DateAndID";
            this.Text = "Add New Order";
            this.Load += new System.EventHandler(this.DateAndID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private OrderManagementSystemDataSet orderManagementSystemDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private OrderManagementSystemDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button addNewOrder;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private OrderManagementSystemDataSet1 orderManagementSystemDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private OrderManagementSystemDataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
    }
}
namespace MD_CRUD_App
{
  partial class SalesEntry
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
      this.txtSalesId = new System.Windows.Forms.TextBox();
      this.txtCustomerName = new System.Windows.Forms.TextBox();
      this.salesDate = new System.Windows.Forms.DateTimePicker();
      this.nmTotal = new System.Windows.Forms.NumericUpDown();
      this.nmPaid = new System.Windows.Forms.NumericUpDown();
      this.chkFullPaid = new System.Windows.Forms.CheckBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnReset = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      this.gridList = new System.Windows.Forms.DataGridView();
      this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ItemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.salesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.nmTotal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nmPaid)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesDetailsBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // txtSalesId
      // 
      this.txtSalesId.Location = new System.Drawing.Point(96, 19);
      this.txtSalesId.Name = "txtSalesId";
      this.txtSalesId.ReadOnly = true;
      this.txtSalesId.Size = new System.Drawing.Size(201, 20);
      this.txtSalesId.TabIndex = 1;
      this.txtSalesId.TabStop = false;
      this.txtSalesId.Text = "0";
      // 
      // txtCustomerName
      // 
      this.txtCustomerName.Location = new System.Drawing.Point(96, 45);
      this.txtCustomerName.Name = "txtCustomerName";
      this.txtCustomerName.Size = new System.Drawing.Size(201, 20);
      this.txtCustomerName.TabIndex = 0;
      // 
      // salesDate
      // 
      this.salesDate.Location = new System.Drawing.Point(96, 71);
      this.salesDate.Name = "salesDate";
      this.salesDate.Size = new System.Drawing.Size(201, 20);
      this.salesDate.TabIndex = 2;
      // 
      // nmTotal
      // 
      this.nmTotal.Location = new System.Drawing.Point(96, 97);
      this.nmTotal.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
      this.nmTotal.Name = "nmTotal";
      this.nmTotal.ReadOnly = true;
      this.nmTotal.Size = new System.Drawing.Size(201, 20);
      this.nmTotal.TabIndex = 3;
      this.nmTotal.TabStop = false;
      // 
      // nmPaid
      // 
      this.nmPaid.Location = new System.Drawing.Point(96, 123);
      this.nmPaid.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
      this.nmPaid.Name = "nmPaid";
      this.nmPaid.Size = new System.Drawing.Size(201, 20);
      this.nmPaid.TabIndex = 3;
      // 
      // chkFullPaid
      // 
      this.chkFullPaid.AutoSize = true;
      this.chkFullPaid.Location = new System.Drawing.Point(96, 149);
      this.chkFullPaid.Name = "chkFullPaid";
      this.chkFullPaid.Size = new System.Drawing.Size(72, 17);
      this.chkFullPaid.TabIndex = 4;
      this.chkFullPaid.Text = "Full Paid?";
      this.chkFullPaid.UseVisualStyleBackColor = true;
      this.chkFullPaid.CheckedChanged += new System.EventHandler(this.chkFullPaid_CheckedChanged);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnReset);
      this.groupBox1.Controls.Add(this.btnSave);
      this.groupBox1.Controls.Add(this.pictureBox1);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.txtSalesId);
      this.groupBox1.Controls.Add(this.chkFullPaid);
      this.groupBox1.Controls.Add(this.txtCustomerName);
      this.groupBox1.Controls.Add(this.nmPaid);
      this.groupBox1.Controls.Add(this.salesDate);
      this.groupBox1.Controls.Add(this.nmTotal);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(800, 228);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "groupBox1";
      // 
      // btnReset
      // 
      this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReset.Location = new System.Drawing.Point(195, 178);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(75, 34);
      this.btnReset.TabIndex = 7;
      this.btnReset.Text = "Reset";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Location = new System.Drawing.Point(94, 178);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(78, 34);
      this.btnSave.TabIndex = 7;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(395, 32);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(121, 99);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(395, 137);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(121, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Upload";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // gridList
      // 
      this.gridList.AutoGenerateColumns = false;
      this.gridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Quantity,
            this.UnitPrice,
            this.ItemTotal});
      this.gridList.DataSource = this.salesDetailsBindingSource;
      this.gridList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridList.Location = new System.Drawing.Point(0, 228);
      this.gridList.Name = "gridList";
      this.gridList.Size = new System.Drawing.Size(800, 222);
      this.gridList.TabIndex = 6;
      this.gridList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridList_CellValueChanged);
      // 
      // ItemName
      // 
      this.ItemName.DataPropertyName = "ItemName";
      this.ItemName.HeaderText = "Item Name";
      this.ItemName.Name = "ItemName";
      // 
      // Quantity
      // 
      this.Quantity.DataPropertyName = "Quantity";
      this.Quantity.HeaderText = "Quantity";
      this.Quantity.Name = "Quantity";
      // 
      // UnitPrice
      // 
      this.UnitPrice.DataPropertyName = "UnitPrice";
      this.UnitPrice.HeaderText = "Unit Price";
      this.UnitPrice.Name = "UnitPrice";
      // 
      // ItemTotal
      // 
      this.ItemTotal.DataPropertyName = "ItemTotal";
      this.ItemTotal.HeaderText = "Item Total";
      this.ItemTotal.Name = "ItemTotal";
      this.ItemTotal.ReadOnly = true;
      // 
      // salesDetailsBindingSource
      // 
      this.salesDetailsBindingSource.AllowNew = true;
      this.salesDetailsBindingSource.DataSource = typeof(MD_CRUD_App.BLL.SalesDetails);
      // 
      // SalesEntry
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.gridList);
      this.Controls.Add(this.groupBox1);
      this.Name = "SalesEntry";
      this.Text = "SalesEntry";
      this.Load += new System.EventHandler(this.SalesEntry_Load);
      ((System.ComponentModel.ISupportInitialize)(this.nmTotal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nmPaid)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesDetailsBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox txtSalesId;
    private System.Windows.Forms.TextBox txtCustomerName;
    private System.Windows.Forms.DateTimePicker salesDate;
    private System.Windows.Forms.NumericUpDown nmTotal;
    private System.Windows.Forms.NumericUpDown nmPaid;
    private System.Windows.Forms.CheckBox chkFullPaid;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView gridList;
    private System.Windows.Forms.BindingSource salesDetailsBindingSource;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
    private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn ItemTotal;
  }
}
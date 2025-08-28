namespace MD_CRUD_App
{
  partial class SalesListForm
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnReport = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.gridList = new System.Windows.Forms.DataGridView();
      this.ImageUrl = new System.Windows.Forms.DataGridViewImageColumn();
      this.SalesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.salesDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.paidAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fullPaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.salesMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesMasterBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnReport);
      this.groupBox1.Controls.Add(this.btnDelete);
      this.groupBox1.Controls.Add(this.btnEdit);
      this.groupBox1.Controls.Add(this.btnAdd);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(800, 100);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "groupBox1";
      // 
      // btnReport
      // 
      this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReport.Location = new System.Drawing.Point(477, 35);
      this.btnReport.Name = "btnReport";
      this.btnReport.Size = new System.Drawing.Size(129, 41);
      this.btnReport.TabIndex = 0;
      this.btnReport.Text = "Report";
      this.btnReport.UseVisualStyleBackColor = true;
      this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDelete.Location = new System.Drawing.Point(326, 35);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(129, 41);
      this.btnDelete.TabIndex = 0;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEdit.Location = new System.Drawing.Point(180, 35);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(129, 41);
      this.btnEdit.TabIndex = 0;
      this.btnEdit.Text = "Edit";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.Location = new System.Drawing.Point(33, 35);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(129, 41);
      this.btnAdd.TabIndex = 0;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // gridList
      // 
      this.gridList.AllowUserToAddRows = false;
      this.gridList.AllowUserToDeleteRows = false;
      this.gridList.AutoGenerateColumns = false;
      this.gridList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.gridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesId,
            this.CustomerName,
            this.salesDateDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.paidAmountDataGridViewTextBoxColumn,
            this.fullPaidDataGridViewCheckBoxColumn,
            this.ImageUrl});
      this.gridList.DataSource = this.salesMasterBindingSource;
      this.gridList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridList.GridColor = System.Drawing.SystemColors.Control;
      this.gridList.Location = new System.Drawing.Point(0, 100);
      this.gridList.MultiSelect = false;
      this.gridList.Name = "gridList";
      this.gridList.ReadOnly = true;
      this.gridList.RowHeadersWidth = 50;
      this.gridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gridList.Size = new System.Drawing.Size(800, 350);
      this.gridList.TabIndex = 1;
      // 
      // ImageUrl
      // 
      this.ImageUrl.DataPropertyName = "Image";
      this.ImageUrl.HeaderText = "Image";
      this.ImageUrl.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
      this.ImageUrl.Name = "ImageUrl";
      this.ImageUrl.ReadOnly = true;
      // 
      // SalesId
      // 
      this.SalesId.DataPropertyName = "SalesId";
      this.SalesId.HeaderText = "Sales Id";
      this.SalesId.Name = "SalesId";
      this.SalesId.ReadOnly = true;
      // 
      // CustomerName
      // 
      this.CustomerName.DataPropertyName = "CustomerName";
      this.CustomerName.HeaderText = "Customer Name";
      this.CustomerName.Name = "CustomerName";
      this.CustomerName.ReadOnly = true;
      // 
      // salesDateDataGridViewTextBoxColumn
      // 
      this.salesDateDataGridViewTextBoxColumn.DataPropertyName = "SalesDate";
      this.salesDateDataGridViewTextBoxColumn.HeaderText = "Sales Date";
      this.salesDateDataGridViewTextBoxColumn.Name = "salesDateDataGridViewTextBoxColumn";
      this.salesDateDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // totalAmountDataGridViewTextBoxColumn
      // 
      this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
      this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount";
      this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
      this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // paidAmountDataGridViewTextBoxColumn
      // 
      this.paidAmountDataGridViewTextBoxColumn.DataPropertyName = "PaidAmount";
      this.paidAmountDataGridViewTextBoxColumn.HeaderText = "Paid Amount";
      this.paidAmountDataGridViewTextBoxColumn.Name = "paidAmountDataGridViewTextBoxColumn";
      this.paidAmountDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // fullPaidDataGridViewCheckBoxColumn
      // 
      this.fullPaidDataGridViewCheckBoxColumn.DataPropertyName = "FullPaid";
      this.fullPaidDataGridViewCheckBoxColumn.HeaderText = "Full Paid";
      this.fullPaidDataGridViewCheckBoxColumn.Name = "fullPaidDataGridViewCheckBoxColumn";
      this.fullPaidDataGridViewCheckBoxColumn.ReadOnly = true;
      // 
      // salesMasterBindingSource
      // 
      this.salesMasterBindingSource.DataSource = typeof(MD_CRUD_App.BLL.SalesMaster);
      // 
      // SalesListForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.gridList);
      this.Controls.Add(this.groupBox1);
      this.Name = "SalesListForm";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesMasterBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView gridList;
    private System.Windows.Forms.BindingSource salesMasterBindingSource;
    private System.Windows.Forms.Button btnReport;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.DataGridViewTextBoxColumn SalesId;
    private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
    private System.Windows.Forms.DataGridViewTextBoxColumn salesDateDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn paidAmountDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn fullPaidDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewImageColumn ImageUrl;
  }
}


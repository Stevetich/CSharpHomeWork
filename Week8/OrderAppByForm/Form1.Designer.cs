namespace OrderAppByForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.showPanel = new System.Windows.Forms.Panel();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderserDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlPanel = new System.Windows.Forms.Panel();
            this.idButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.inquiryByIdBtn = new System.Windows.Forms.Button();
            this.inquiryAllBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.showPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderserDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.ctrlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderserBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // showPanel
            // 
            this.showPanel.BackColor = System.Drawing.SystemColors.Control;
            this.showPanel.Controls.Add(this.OrderserDataGridView);
            this.showPanel.Controls.Add(this.panel1);
            this.showPanel.Controls.Add(this.ctrlPanel);
            this.showPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPanel.Location = new System.Drawing.Point(0, 0);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(912, 506);
            this.showPanel.TabIndex = 0;
            this.showPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.showPanel_Paint);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGridView.Location = new System.Drawing.Point(0, 0);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowTemplate.Height = 23;
            this.orderDataGridView.Size = new System.Drawing.Size(693, 277);
            this.orderDataGridView.TabIndex = 0;
            this.orderDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellDoubleClick);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.AllowNew = true;
            this.orderBindingSource.DataMember = "Items";
            this.orderBindingSource.DataSource = this.orderserBindingSource;
            // 
            // OrderserDataGridView
            // 
            this.OrderserDataGridView.AutoGenerateColumns = false;
            this.OrderserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.OrderserDataGridView.DataSource = this.orderserBindingSource;
            this.OrderserDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderserDataGridView.Location = new System.Drawing.Point(0, 0);
            this.OrderserDataGridView.Name = "OrderserDataGridView";
            this.OrderserDataGridView.RowTemplate.Height = 23;
            this.OrderserDataGridView.Size = new System.Drawing.Size(695, 227);
            this.OrderserDataGridView.TabIndex = 2;
            this.OrderserDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderserDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 279);
            this.panel1.TabIndex = 1;
            // 
            // ctrlPanel
            // 
            this.ctrlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlPanel.Controls.Add(this.exportButton);
            this.ctrlPanel.Controls.Add(this.importButton);
            this.ctrlPanel.Controls.Add(this.idButton);
            this.ctrlPanel.Controls.Add(this.textBox2);
            this.ctrlPanel.Controls.Add(this.inquiryByIdBtn);
            this.ctrlPanel.Controls.Add(this.inquiryAllBtn);
            this.ctrlPanel.Controls.Add(this.delBtn);
            this.ctrlPanel.Controls.Add(this.addBtn);
            this.ctrlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrlPanel.Location = new System.Drawing.Point(695, 0);
            this.ctrlPanel.Name = "ctrlPanel";
            this.ctrlPanel.Size = new System.Drawing.Size(217, 506);
            this.ctrlPanel.TabIndex = 0;
            // 
            // idButton
            // 
            this.idButton.Location = new System.Drawing.Point(129, 331);
            this.idButton.Name = "idButton";
            this.idButton.Size = new System.Drawing.Size(75, 23);
            this.idButton.TabIndex = 5;
            this.idButton.Text = "ID查询";
            this.idButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 333);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            // 
            // inquiryByIdBtn
            // 
            this.inquiryByIdBtn.Location = new System.Drawing.Point(65, 247);
            this.inquiryByIdBtn.Name = "inquiryByIdBtn";
            this.inquiryByIdBtn.Size = new System.Drawing.Size(75, 23);
            this.inquiryByIdBtn.TabIndex = 3;
            this.inquiryByIdBtn.Text = "添加订单";
            this.inquiryByIdBtn.UseVisualStyleBackColor = true;
            // 
            // inquiryAllBtn
            // 
            this.inquiryAllBtn.Location = new System.Drawing.Point(65, 185);
            this.inquiryAllBtn.Name = "inquiryAllBtn";
            this.inquiryAllBtn.Size = new System.Drawing.Size(75, 23);
            this.inquiryAllBtn.TabIndex = 2;
            this.inquiryAllBtn.Text = "查询所有";
            this.inquiryAllBtn.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(65, 121);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "删除订单";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(65, 60);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "添加订单";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "数量";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "商品ID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // orderserBindingSource
            // 
            this.orderserBindingSource.AllowNew = true;
            this.orderserBindingSource.DataSource = typeof(OrderAppByForm.Order);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "订单ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "订单总价格";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.orderDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 277);
            this.panel2.TabIndex = 0;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(65, 384);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 6;
            this.importButton.Text = "导入文件";
            this.importButton.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(65, 434);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 7;
            this.exportButton.Text = "导出文件";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 506);
            this.Controls.Add(this.showPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.showPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderserDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ctrlPanel.ResumeLayout(false);
            this.ctrlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderserBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel showPanel;
        private System.Windows.Forms.Panel ctrlPanel;
        private System.Windows.Forms.Button inquiryByIdBtn;
        private System.Windows.Forms.Button inquiryAllBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView OrderserDataGridView;
        private System.Windows.Forms.BindingSource orderserBindingSource;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button idButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
    }
}


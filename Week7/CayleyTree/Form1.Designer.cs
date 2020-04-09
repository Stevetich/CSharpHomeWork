namespace CayleyTree
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
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.controlpanel = new System.Windows.Forms.Panel();
            this.penComboBox = new System.Windows.Forms.ComboBox();
            this.penLbl = new System.Windows.Forms.Label();
            this.nLbl = new System.Windows.Forms.Label();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.lengText = new System.Windows.Forms.Label();
            this.lengLbl = new System.Windows.Forms.Label();
            this.lengTrackBar = new System.Windows.Forms.TrackBar();
            this.per1TrackBar = new System.Windows.Forms.TrackBar();
            this.per1Lbl = new System.Windows.Forms.Label();
            this.per1Text = new System.Windows.Forms.Label();
            this.per2TrackBar = new System.Windows.Forms.TrackBar();
            this.per2Lbl = new System.Windows.Forms.Label();
            this.per2Text = new System.Windows.Forms.Label();
            this.th1TrackBar = new System.Windows.Forms.TrackBar();
            this.th1Lbl = new System.Windows.Forms.Label();
            this.th1Text = new System.Windows.Forms.Label();
            this.th2TrackBar = new System.Windows.Forms.TrackBar();
            this.th2Lbl = new System.Windows.Forms.Label();
            this.th2Text = new System.Windows.Forms.Label();
            this.nNumber = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.controlpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始运行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.controlpanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.drawingPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(713, 479);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // controlpanel
            // 
            this.controlpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlpanel.Controls.Add(this.nNumber);
            this.controlpanel.Controls.Add(this.th2TrackBar);
            this.controlpanel.Controls.Add(this.th2Lbl);
            this.controlpanel.Controls.Add(this.th2Text);
            this.controlpanel.Controls.Add(this.th1TrackBar);
            this.controlpanel.Controls.Add(this.th1Lbl);
            this.controlpanel.Controls.Add(this.th1Text);
            this.controlpanel.Controls.Add(this.per2TrackBar);
            this.controlpanel.Controls.Add(this.per2Lbl);
            this.controlpanel.Controls.Add(this.per2Text);
            this.controlpanel.Controls.Add(this.per1TrackBar);
            this.controlpanel.Controls.Add(this.per1Lbl);
            this.controlpanel.Controls.Add(this.per1Text);
            this.controlpanel.Controls.Add(this.lengTrackBar);
            this.controlpanel.Controls.Add(this.lengLbl);
            this.controlpanel.Controls.Add(this.lengText);
            this.controlpanel.Controls.Add(this.penComboBox);
            this.controlpanel.Controls.Add(this.penLbl);
            this.controlpanel.Controls.Add(this.nLbl);
            this.controlpanel.Controls.Add(this.button1);
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlpanel.Location = new System.Drawing.Point(366, 10);
            this.controlpanel.Margin = new System.Windows.Forms.Padding(10);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(337, 459);
            this.controlpanel.TabIndex = 1;
            // 
            // penComboBox
            // 
            this.penComboBox.FormattingEnabled = true;
            this.penComboBox.Location = new System.Drawing.Point(142, 69);
            this.penComboBox.Name = "penComboBox";
            this.penComboBox.Size = new System.Drawing.Size(121, 20);
            this.penComboBox.TabIndex = 4;
            // 
            // penLbl
            // 
            this.penLbl.AutoSize = true;
            this.penLbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.penLbl.Location = new System.Drawing.Point(55, 68);
            this.penLbl.Name = "penLbl";
            this.penLbl.Size = new System.Drawing.Size(72, 16);
            this.penLbl.TabIndex = 3;
            this.penLbl.Text = "画笔颜色";
            // 
            // nLbl
            // 
            this.nLbl.AutoSize = true;
            this.nLbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nLbl.Location = new System.Drawing.Point(55, 37);
            this.nLbl.Name = "nLbl";
            this.nLbl.Size = new System.Drawing.Size(72, 16);
            this.nLbl.TabIndex = 1;
            this.nLbl.Text = "递归深度";
            // 
            // drawingPanel
            // 
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingPanel.Location = new System.Drawing.Point(10, 10);
            this.drawingPanel.Margin = new System.Windows.Forms.Padding(10);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(336, 459);
            this.drawingPanel.TabIndex = 2;
            // 
            // lengText
            // 
            this.lengText.AutoSize = true;
            this.lengText.Location = new System.Drawing.Point(140, 132);
            this.lengText.Name = "lengText";
            this.lengText.Size = new System.Drawing.Size(23, 12);
            this.lengText.TabIndex = 5;
            this.lengText.Text = "100";
            // 
            // lengLbl
            // 
            this.lengLbl.AutoSize = true;
            this.lengLbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lengLbl.Location = new System.Drawing.Point(55, 128);
            this.lengLbl.Name = "lengLbl";
            this.lengLbl.Size = new System.Drawing.Size(72, 16);
            this.lengLbl.TabIndex = 6;
            this.lengLbl.Text = "主干长度";
            // 
            // lengTrackBar
            // 
            this.lengTrackBar.Location = new System.Drawing.Point(167, 123);
            this.lengTrackBar.Maximum = 200;
            this.lengTrackBar.Minimum = 50;
            this.lengTrackBar.Name = "lengTrackBar";
            this.lengTrackBar.Size = new System.Drawing.Size(135, 45);
            this.lengTrackBar.TabIndex = 7;
            this.lengTrackBar.Value = 100;
            this.lengTrackBar.Scroll += new System.EventHandler(this.lengTrackBar_Scroll);
            // 
            // per1TrackBar
            // 
            this.per1TrackBar.Location = new System.Drawing.Point(167, 174);
            this.per1TrackBar.Name = "per1TrackBar";
            this.per1TrackBar.Size = new System.Drawing.Size(135, 45);
            this.per1TrackBar.TabIndex = 10;
            this.per1TrackBar.Value = 6;
            this.per1TrackBar.Scroll += new System.EventHandler(this.per1TrackBar_Scroll);
            // 
            // per1Lbl
            // 
            this.per1Lbl.AutoSize = true;
            this.per1Lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.per1Lbl.Location = new System.Drawing.Point(23, 179);
            this.per1Lbl.Name = "per1Lbl";
            this.per1Lbl.Size = new System.Drawing.Size(104, 16);
            this.per1Lbl.TabIndex = 9;
            this.per1Lbl.Text = "右分支长度比";
            // 
            // per1Text
            // 
            this.per1Text.AutoSize = true;
            this.per1Text.Location = new System.Drawing.Point(140, 183);
            this.per1Text.Name = "per1Text";
            this.per1Text.Size = new System.Drawing.Size(23, 12);
            this.per1Text.TabIndex = 8;
            this.per1Text.Text = "0.6";
            // 
            // per2TrackBar
            // 
            this.per2TrackBar.Location = new System.Drawing.Point(167, 225);
            this.per2TrackBar.Name = "per2TrackBar";
            this.per2TrackBar.Size = new System.Drawing.Size(135, 45);
            this.per2TrackBar.TabIndex = 13;
            this.per2TrackBar.Value = 7;
            this.per2TrackBar.Scroll += new System.EventHandler(this.per2TrackBar_Scroll);
            // 
            // per2Lbl
            // 
            this.per2Lbl.AutoSize = true;
            this.per2Lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.per2Lbl.Location = new System.Drawing.Point(23, 230);
            this.per2Lbl.Name = "per2Lbl";
            this.per2Lbl.Size = new System.Drawing.Size(104, 16);
            this.per2Lbl.TabIndex = 12;
            this.per2Lbl.Text = "左分支长度比";
            // 
            // per2Text
            // 
            this.per2Text.AutoSize = true;
            this.per2Text.Location = new System.Drawing.Point(140, 234);
            this.per2Text.Name = "per2Text";
            this.per2Text.Size = new System.Drawing.Size(23, 12);
            this.per2Text.TabIndex = 11;
            this.per2Text.Text = "0.7";
            // 
            // th1TrackBar
            // 
            this.th1TrackBar.Location = new System.Drawing.Point(167, 276);
            this.th1TrackBar.Maximum = 960;
            this.th1TrackBar.Name = "th1TrackBar";
            this.th1TrackBar.Size = new System.Drawing.Size(135, 45);
            this.th1TrackBar.TabIndex = 16;
            this.th1TrackBar.Value = 480;
            this.th1TrackBar.Scroll += new System.EventHandler(this.th1TrackBar_Scroll);
            // 
            // th1Lbl
            // 
            this.th1Lbl.AutoSize = true;
            this.th1Lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.th1Lbl.Location = new System.Drawing.Point(39, 281);
            this.th1Lbl.Name = "th1Lbl";
            this.th1Lbl.Size = new System.Drawing.Size(88, 16);
            this.th1Lbl.TabIndex = 15;
            this.th1Lbl.Text = "右分支角度";
            // 
            // th1Text
            // 
            this.th1Text.AutoSize = true;
            this.th1Text.Location = new System.Drawing.Point(140, 285);
            this.th1Text.Name = "th1Text";
            this.th1Text.Size = new System.Drawing.Size(17, 12);
            this.th1Text.TabIndex = 14;
            this.th1Text.Text = "30";
            // 
            // th2TrackBar
            // 
            this.th2TrackBar.Location = new System.Drawing.Point(167, 327);
            this.th2TrackBar.Maximum = 960;
            this.th2TrackBar.Name = "th2TrackBar";
            this.th2TrackBar.Size = new System.Drawing.Size(135, 45);
            this.th2TrackBar.TabIndex = 19;
            this.th2TrackBar.Value = 320;
            this.th2TrackBar.Scroll += new System.EventHandler(this.th2TrackBar_Scroll);
            // 
            // th2Lbl
            // 
            this.th2Lbl.AutoSize = true;
            this.th2Lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.th2Lbl.Location = new System.Drawing.Point(39, 332);
            this.th2Lbl.Name = "th2Lbl";
            this.th2Lbl.Size = new System.Drawing.Size(88, 16);
            this.th2Lbl.TabIndex = 18;
            this.th2Lbl.Text = "左分支角度";
            // 
            // th2Text
            // 
            this.th2Text.AutoSize = true;
            this.th2Text.Location = new System.Drawing.Point(140, 336);
            this.th2Text.Name = "th2Text";
            this.th2Text.Size = new System.Drawing.Size(17, 12);
            this.th2Text.TabIndex = 17;
            this.th2Text.Text = "20";
            // 
            // nNumber
            // 
            this.nNumber.Location = new System.Drawing.Point(142, 37);
            this.nNumber.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nNumber.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nNumber.Name = "nNumber";
            this.nNumber.Size = new System.Drawing.Size(120, 21);
            this.nNumber.TabIndex = 20;
            this.nNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 479);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.controlpanel.ResumeLayout(false);
            this.controlpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Label nLbl;
        private System.Windows.Forms.ComboBox penComboBox;
        private System.Windows.Forms.Label penLbl;
        private System.Windows.Forms.TrackBar th2TrackBar;
        private System.Windows.Forms.Label th2Lbl;
        private System.Windows.Forms.Label th2Text;
        private System.Windows.Forms.TrackBar th1TrackBar;
        private System.Windows.Forms.Label th1Lbl;
        private System.Windows.Forms.Label th1Text;
        private System.Windows.Forms.TrackBar per2TrackBar;
        private System.Windows.Forms.Label per2Lbl;
        private System.Windows.Forms.Label per2Text;
        private System.Windows.Forms.TrackBar per1TrackBar;
        private System.Windows.Forms.Label per1Lbl;
        private System.Windows.Forms.Label per1Text;
        private System.Windows.Forms.TrackBar lengTrackBar;
        private System.Windows.Forms.Label lengLbl;
        private System.Windows.Forms.Label lengText;
        private System.Windows.Forms.NumericUpDown nNumber;
    }
}


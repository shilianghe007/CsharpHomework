namespace homework7
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(437, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单系统";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 575);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.goodNameDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.pricesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 573);
            this.dataGridView1.TabIndex = 0;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "goodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "goodName";
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // pricesDataGridViewTextBoxColumn
            // 
            this.pricesDataGridViewTextBoxColumn.DataPropertyName = "prices";
            this.pricesDataGridViewTextBoxColumn.HeaderText = "prices";
            this.pricesDataGridViewTextBoxColumn.Name = "pricesDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(program1.Person);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(709, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 575);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(67, 420);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(251, 73);
            this.button5.TabIndex = 4;
            this.button5.Text = "网页化";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(67, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(252, 74);
            this.button4.TabIndex = 3;
            this.button4.Text = "查询订单";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "修改订单";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "删除订单";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加订单";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricesDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource bindingSource1;
    }
}


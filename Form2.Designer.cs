namespace CWA_Expense_Tracking
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.load = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadedMiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emptyMiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Load Tracking Application";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(206, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(528, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(830, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.load,
            this.date,
            this.from,
            this.to,
            this.payType,
            this.loadedMiles,
            this.emptyMiles,
            this.payRate,
            this.loadRevenue,
            this.totalPay});
            this.dataGridView1.Location = new System.Drawing.Point(43, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // load
            // 
            this.load.HeaderText = "Load";
            this.load.Name = "load";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // from
            // 
            this.from.HeaderText = "From";
            this.from.Name = "from";
            // 
            // to
            // 
            this.to.HeaderText = "To";
            this.to.Name = "to";
            // 
            // payType
            // 
            this.payType.HeaderText = "Pay Type";
            this.payType.Name = "payType";
            // 
            // loadedMiles
            // 
            this.loadedMiles.HeaderText = "Loaded Miles";
            this.loadedMiles.Name = "loadedMiles";
            // 
            // emptyMiles
            // 
            this.emptyMiles.HeaderText = "Empty Miles";
            this.emptyMiles.Name = "emptyMiles";
            // 
            // payRate
            // 
            this.payRate.HeaderText = "Pay Rate";
            this.payRate.Name = "payRate";
            // 
            // loadRevenue
            // 
            this.loadRevenue.HeaderText = "Load Revenue";
            this.loadRevenue.Name = "loadRevenue";
            // 
            // totalPay
            // 
            this.totalPay.HeaderText = "Total Pay";
            this.totalPay.Name = "totalPay";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1160, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn load;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn payType;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadedMiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn emptyMiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPay;
    }
}
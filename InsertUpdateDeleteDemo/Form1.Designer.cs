namespace NetPromoterScore
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technologyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblnpsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationsDataSet = new NetPromoterScore.OperationsDataSet();
            this.npstableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsqlDataSet = new NetPromoterScore.testsqlDataSet();
            this.nps_tableTableAdapter = new NetPromoterScore.testsqlDataSetTableAdapters.nps_tableTableAdapter();
            this.txt_Ticket_number = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Customer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Technology = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Score = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Comment = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.testsqlDataSet1 = new NetPromoterScore.testsqlDataSet1();
            this.npstableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nps_tableTableAdapter1 = new NetPromoterScore.testsqlDataSet1TableAdapters.nps_tableTableAdapter();
            this.tbl_npsTableAdapter = new NetPromoterScore.OperationsDataSetTableAdapters.tbl_npsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblnpsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npstableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsqlDataSet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsqlDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npstableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.customerDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.technologyDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.Country});
            this.dataGridView1.DataSource = this.tblnpsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ticket number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ticket number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date of call";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date of call";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // technologyDataGridViewTextBoxColumn
            // 
            this.technologyDataGridViewTextBoxColumn.DataPropertyName = "Technology";
            this.technologyDataGridViewTextBoxColumn.HeaderText = "Technology";
            this.technologyDataGridViewTextBoxColumn.Name = "technologyDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // tblnpsBindingSource
            // 
            this.tblnpsBindingSource.DataMember = "tbl_nps";
            this.tblnpsBindingSource.DataSource = this.operationsDataSet;
            // 
            // operationsDataSet
            // 
            this.operationsDataSet.DataSetName = "OperationsDataSet";
            this.operationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // npstableBindingSource
            // 
            this.npstableBindingSource.DataMember = "nps_table";
            this.npstableBindingSource.DataSource = this.testsqlDataSet;
            // 
            // testsqlDataSet
            // 
            this.testsqlDataSet.DataSetName = "testsqlDataSet";
            this.testsqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nps_tableTableAdapter
            // 
            this.nps_tableTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Ticket_number
            // 
            this.txt_Ticket_number.Location = new System.Drawing.Point(170, 23);
            this.txt_Ticket_number.Name = "txt_Ticket_number";
            this.txt_Ticket_number.Size = new System.Drawing.Size(248, 20);
            this.txt_Ticket_number.TabIndex = 1;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(89, 182);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 2;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(170, 182);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticket number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer";
            // 
            // txt_Customer
            // 
            this.txt_Customer.Location = new System.Drawing.Point(170, 50);
            this.txt_Customer.Name = "txt_Customer";
            this.txt_Customer.Size = new System.Drawing.Size(248, 20);
            this.txt_Customer.TabIndex = 6;
            this.txt_Customer.TextChanged += new System.EventHandler(this.txt_Customer_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date of call";
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(503, 81);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(100, 20);
            this.txt_Country.TabIndex = 8;
            this.txt_Country.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Technology";
            // 
            // txt_Technology
            // 
            this.txt_Technology.Location = new System.Drawing.Point(170, 78);
            this.txt_Technology.Name = "txt_Technology";
            this.txt_Technology.Size = new System.Drawing.Size(248, 20);
            this.txt_Technology.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Score";
            // 
            // txt_Score
            // 
            this.txt_Score.Location = new System.Drawing.Point(503, 50);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(100, 20);
            this.txt_Score.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Other information from customer";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_Comment
            // 
            this.txt_Comment.Location = new System.Drawing.Point(254, 120);
            this.txt_Comment.Multiline = true;
            this.txt_Comment.Name = "txt_Comment";
            this.txt_Comment.Size = new System.Drawing.Size(534, 52);
            this.txt_Comment.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(503, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Country";
            // 
            // testsqlDataSet1
            // 
            this.testsqlDataSet1.DataSetName = "testsqlDataSet1";
            this.testsqlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // npstableBindingSource1
            // 
            this.npstableBindingSource1.DataMember = "nps_table";
            this.npstableBindingSource1.DataSource = this.testsqlDataSet1;
            // 
            // nps_tableTableAdapter1
            // 
            this.nps_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_npsTableAdapter
            // 
            this.tbl_npsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_Comment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Technology);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Customer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Ticket_number);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Net Promoter Score";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblnpsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npstableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsqlDataSet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testsqlDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npstableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private testsqlDataSet testsqlDataSet;
        private System.Windows.Forms.BindingSource npstableBindingSource;
        private testsqlDataSetTableAdapters.nps_tableTableAdapter nps_tableTableAdapter;
        private System.Windows.Forms.TextBox txt_Ticket_number;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Technology;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Score;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Comment;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label7;
        private testsqlDataSet1 testsqlDataSet1;
        private System.Windows.Forms.BindingSource npstableBindingSource1;
        private testsqlDataSet1TableAdapters.nps_tableTableAdapter nps_tableTableAdapter1;
        private OperationsDataSet operationsDataSet;
        private System.Windows.Forms.BindingSource tblnpsBindingSource;
        private OperationsDataSetTableAdapters.tbl_npsTableAdapter tbl_npsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn technologyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
    }
}


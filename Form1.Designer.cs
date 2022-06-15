namespace Assistant_VI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox_Assistant = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_Assistant = new System.Windows.Forms.Label();
            this.listBox_History = new System.Windows.Forms.ListBox();
            this.button_Send2 = new System.Windows.Forms.Button();
            this.textBox_You = new System.Windows.Forms.TextBox();
            this.button_Send1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataGridView_Rezervacije = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistant_VI_dbDataSet = new Assistant_VI.Assistant_VI_dbDataSet();
            this.rezervacijeTableAdapter = new Assistant_VI.Assistant_VI_dbDataSetTableAdapters.RezervacijeTableAdapter();
            this.tableAdapterManager = new Assistant_VI.Assistant_VI_dbDataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Rezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistant_VI_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Assistant
            // 
            this.comboBox_Assistant.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_Assistant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Assistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Assistant.FormattingEnabled = true;
            this.comboBox_Assistant.Items.AddRange(new object[] {
            "-Izaberite termin-"});
            this.comboBox_Assistant.Location = new System.Drawing.Point(6, 420);
            this.comboBox_Assistant.Name = "comboBox_Assistant";
            this.comboBox_Assistant.Size = new System.Drawing.Size(895, 37);
            this.comboBox_Assistant.TabIndex = 19;
            this.comboBox_Assistant.Visible = false;
            this.comboBox_Assistant.SelectedIndexChanged += new System.EventHandler(this.comboBox_Assistant_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 502);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label_Assistant);
            this.tabPage1.Controls.Add(this.listBox_History);
            this.tabPage1.Controls.Add(this.button_Send2);
            this.tabPage1.Controls.Add(this.comboBox_Assistant);
            this.tabPage1.Controls.Add(this.textBox_You);
            this.tabPage1.Controls.Add(this.button_Send1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Početna";
            // 
            // label_Assistant
            // 
            this.label_Assistant.AutoSize = true;
            this.label_Assistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Assistant.Location = new System.Drawing.Point(3, 373);
            this.label_Assistant.Name = "label_Assistant";
            this.label_Assistant.Size = new System.Drawing.Size(0, 29);
            this.label_Assistant.TabIndex = 22;
            // 
            // listBox_History
            // 
            this.listBox_History.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_History.FormattingEnabled = true;
            this.listBox_History.ItemHeight = 20;
            this.listBox_History.Location = new System.Drawing.Point(6, 6);
            this.listBox_History.Name = "listBox_History";
            this.listBox_History.Size = new System.Drawing.Size(976, 342);
            this.listBox_History.TabIndex = 0;
            // 
            // button_Send2
            // 
            this.button_Send2.Image = ((System.Drawing.Image)(resources.GetObject("button_Send2.Image")));
            this.button_Send2.Location = new System.Drawing.Point(907, 419);
            this.button_Send2.Name = "button_Send2";
            this.button_Send2.Size = new System.Drawing.Size(75, 37);
            this.button_Send2.TabIndex = 20;
            this.button_Send2.UseVisualStyleBackColor = true;
            this.button_Send2.Visible = false;
            this.button_Send2.Click += new System.EventHandler(this.button_Send2_Click);
            // 
            // textBox_You
            // 
            this.textBox_You.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_You.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_You.Location = new System.Drawing.Point(6, 420);
            this.textBox_You.MaxLength = 128;
            this.textBox_You.Name = "textBox_You";
            this.textBox_You.Size = new System.Drawing.Size(895, 36);
            this.textBox_You.TabIndex = 0;
            this.textBox_You.TextChanged += new System.EventHandler(this.textBox_You_TextChanged);
            // 
            // button_Send1
            // 
            this.button_Send1.Enabled = false;
            this.button_Send1.Image = ((System.Drawing.Image)(resources.GetObject("button_Send1.Image")));
            this.button_Send1.Location = new System.Drawing.Point(907, 419);
            this.button_Send1.Name = "button_Send1";
            this.button_Send1.Size = new System.Drawing.Size(75, 37);
            this.button_Send1.TabIndex = 11;
            this.button_Send1.UseVisualStyleBackColor = true;
            this.button_Send1.Click += new System.EventHandler(this.button_Send1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.DataGridView_Rezervacije);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rezervacije";
            // 
            // DataGridView_Rezervacije
            // 
            this.DataGridView_Rezervacije.AllowUserToAddRows = false;
            this.DataGridView_Rezervacije.AllowUserToDeleteRows = false;
            this.DataGridView_Rezervacije.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_Rezervacije.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DataGridView_Rezervacije.AutoGenerateColumns = false;
            this.DataGridView_Rezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Rezervacije.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Rezervacije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DataGridView_Rezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Rezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DataGridView_Rezervacije.DataSource = this.rezervacijeBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Rezervacije.DefaultCellStyle = dataGridViewCellStyle17;
            this.DataGridView_Rezervacije.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_Rezervacije.Name = "DataGridView_Rezervacije";
            this.DataGridView_Rezervacije.ReadOnly = true;
            this.DataGridView_Rezervacije.RowHeadersWidth = 51;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Silver;
            this.DataGridView_Rezervacije.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.DataGridView_Rezervacije.RowTemplate.Height = 24;
            this.DataGridView_Rezervacije.Size = new System.Drawing.Size(998, 473);
            this.DataGridView_Rezervacije.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Polazno_mesto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Polazno mesto";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Dolazno_mesto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dolazno mesto";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Termin";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn4.HeaderText = "Termin";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataMember = "Rezervacije";
            this.rezervacijeBindingSource.DataSource = this.assistant_VI_dbDataSet;
            // 
            // assistant_VI_dbDataSet
            // 
            this.assistant_VI_dbDataSet.DataSetName = "Assistant_VI_dbDataSet";
            this.assistant_VI_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervacijeTableAdapter
            // 
            this.rezervacijeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RezervacijeTableAdapter = this.rezervacijeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Assistant_VI.Assistant_VI_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Assistant_VI.Properties.Resources.form_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 526);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1048, 573);
            this.MinimumSize = new System.Drawing.Size(1048, 573);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Rezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistant_VI_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Assistant;
        private System.Windows.Forms.Button button_Send2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_Send1;
        private System.Windows.Forms.TextBox textBox_You;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox_History;
        private System.Windows.Forms.Label label_Assistant;
        private Assistant_VI_dbDataSet assistant_VI_dbDataSet;
        private System.Windows.Forms.BindingSource rezervacijeBindingSource;
        private Assistant_VI_dbDataSetTableAdapters.RezervacijeTableAdapter rezervacijeTableAdapter;
        private Assistant_VI_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.DataGridView DataGridView_Rezervacije;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace LocalDB
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label genderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.costomersBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.costomersBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.costomersDataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullNameTextBox1 = new System.Windows.Forms.TextBox();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.locationTextBox1 = new System.Windows.Forms.TextBox();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.genderCheckBox1 = new System.Windows.Forms.CheckBox();
            this.costomersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modelDataSet1 = new LocalDB.ModelDataSet();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.costomersTableAdapter1 = new LocalDB.ModelDataSetTableAdapters.CostomersTableAdapter();
            this.tableAdapterManager1 = new LocalDB.ModelDataSetTableAdapters.TableAdapterManager();
            fullNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.costomersBindingSource1BindingNavigator)).BeginInit();
            this.costomersBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costomersDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(62, 53);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(71, 16);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "Full Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(62, 94);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(62, 134);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(61, 16);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "Location:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(62, 176);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(49, 16);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "Phone:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(62, 208);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(55, 16);
            genderLabel.TabIndex = 12;
            genderLabel.Text = "Gender:";
            genderLabel.Click += new System.EventHandler(this.genderLabel_Click);
            // 
            // costomersBindingSource1BindingNavigator
            // 
            this.costomersBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.costomersBindingSource1BindingNavigator.BindingSource = this.costomersBindingSource1;
            this.costomersBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.costomersBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.costomersBindingSource1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.costomersBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.costomersBindingSource1BindingNavigatorSaveItem});
            this.costomersBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.costomersBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.costomersBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.costomersBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.costomersBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.costomersBindingSource1BindingNavigator.Name = "costomersBindingSource1BindingNavigator";
            this.costomersBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.costomersBindingSource1BindingNavigator.Size = new System.Drawing.Size(1036, 27);
            this.costomersBindingSource1BindingNavigator.TabIndex = 0;
            this.costomersBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "Yeni ekle";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 24);
            this.toolStripLabel1.Text = "/ {0}";
            this.toolStripLabel1.ToolTipText = "Toplam öğe sayısı";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "Sil";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Başa taşı";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "Öne taşı";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Konum";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 27);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Geçerli konum";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "Arkaya taşı";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "Sona taşı";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // costomersBindingSource1BindingNavigatorSaveItem
            // 
            this.costomersBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.costomersBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("costomersBindingSource1BindingNavigatorSaveItem.Image")));
            this.costomersBindingSource1BindingNavigatorSaveItem.Name = "costomersBindingSource1BindingNavigatorSaveItem";
            this.costomersBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.costomersBindingSource1BindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.costomersBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.costomersBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // costomersDataGridView1
            // 
            this.costomersDataGridView1.AutoGenerateColumns = false;
            this.costomersDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costomersDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn2});
            this.costomersDataGridView1.DataSource = this.costomersBindingSource1;
            this.costomersDataGridView1.Location = new System.Drawing.Point(65, 269);
            this.costomersDataGridView1.Name = "costomersDataGridView1";
            this.costomersDataGridView1.RowHeadersWidth = 51;
            this.costomersDataGridView1.RowTemplate.Height = 24;
            this.costomersDataGridView1.Size = new System.Drawing.Size(801, 220);
            this.costomersDataGridView1.TabIndex = 1;
            // 
            // fullNameTextBox1
            // 
            this.fullNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costomersBindingSource1, "FullName", true));
            this.fullNameTextBox1.Location = new System.Drawing.Point(139, 47);
            this.fullNameTextBox1.Name = "fullNameTextBox1";
            this.fullNameTextBox1.Size = new System.Drawing.Size(302, 22);
            this.fullNameTextBox1.TabIndex = 5;
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costomersBindingSource1, "Email", true));
            this.emailTextBox1.Location = new System.Drawing.Point(139, 91);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(302, 22);
            this.emailTextBox1.TabIndex = 7;
            // 
            // locationTextBox1
            // 
            this.locationTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costomersBindingSource1, "Location", true));
            this.locationTextBox1.Location = new System.Drawing.Point(139, 131);
            this.locationTextBox1.Name = "locationTextBox1";
            this.locationTextBox1.Size = new System.Drawing.Size(302, 22);
            this.locationTextBox1.TabIndex = 9;
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costomersBindingSource1, "Phone", true));
            this.phoneTextBox1.Location = new System.Drawing.Point(139, 170);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(302, 22);
            this.phoneTextBox1.TabIndex = 11;
            this.phoneTextBox1.TextChanged += new System.EventHandler(this.phoneTextBox1_TextChanged);
            // 
            // genderCheckBox1
            // 
            this.genderCheckBox1.Checked = true;
            this.genderCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.genderCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.costomersBindingSource1, "Gender", true));
            this.genderCheckBox1.Location = new System.Drawing.Point(139, 205);
            this.genderCheckBox1.Name = "genderCheckBox1";
            this.genderCheckBox1.Size = new System.Drawing.Size(104, 22);
            this.genderCheckBox1.TabIndex = 13;
            this.genderCheckBox1.Text = "Male";
            this.genderCheckBox1.UseVisualStyleBackColor = true;
            this.genderCheckBox1.CheckedChanged += new System.EventHandler(this.genderCheckBox1_CheckedChanged);
            // 
            // costomersBindingSource1
            // 
            this.costomersBindingSource1.DataMember = "Costomers";
            this.costomersBindingSource1.DataSource = this.modelDataSet1;
            // 
            // modelDataSet1
            // 
            this.modelDataSet1.DataSetName = "ModelDataSet";
            this.modelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn7.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn9.HeaderText = "Location";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn10.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Gender";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Gender";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 125;
            // 
            // costomersTableAdapter1
            // 
            this.costomersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CostomersTableAdapter = this.costomersTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = LocalDB.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1036, 534);
            this.Controls.Add(this.phoneTextBox1);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderCheckBox1);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox1);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox1);
            this.Controls.Add(this.costomersDataGridView1);
            this.Controls.Add(this.costomersBindingSource1BindingNavigator);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocalDB";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.costomersBindingSource1BindingNavigator)).EndInit();
            this.costomersBindingSource1BindingNavigator.ResumeLayout(false);
            this.costomersBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costomersDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource costomersBindingSource;
        private ModelDataSetTableAdapters.CostomersTableAdapter costomersTableAdapter;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator costomersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton costomersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.CheckBox genderCheckBox;
        private System.Windows.Forms.DataGridView costomersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private ModelDataSet modelDataSet1;
        private System.Windows.Forms.BindingSource costomersBindingSource1;
        private ModelDataSetTableAdapters.CostomersTableAdapter costomersTableAdapter1;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator costomersBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton costomersBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView costomersDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.TextBox fullNameTextBox1;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.TextBox locationTextBox1;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.CheckBox genderCheckBox1;
    }
}


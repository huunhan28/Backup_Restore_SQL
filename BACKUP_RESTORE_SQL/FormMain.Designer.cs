
namespace BACKUP_RESTORE_SQL
{
    partial class FormMain
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
            this.txbSQL = new System.Windows.Forms.TextBox();
            this.chkXoaBackup = new System.Windows.Forms.CheckBox();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.chbThamSo = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTaoDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaoLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhucHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.xoá1BảnSaoLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1 = new BACKUP_RESTORE_SQL.DataSet1();
            this.databasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasesTableAdapter = new BACKUP_RESTORE_SQL.DataSet1TableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new BACKUP_RESTORE_SQL.DataSet1TableAdapters.TableAdapterManager();
            this.databasesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.position_backupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.position_backupTableAdapter = new BACKUP_RESTORE_SQL.DataSet1TableAdapters.position_backupTableAdapter();
            this.position_backupGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.position_backupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.position_backupGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSQL
            // 
            this.txbSQL.Location = new System.Drawing.Point(336, 405);
            this.txbSQL.Multiline = true;
            this.txbSQL.Name = "txbSQL";
            this.txbSQL.Size = new System.Drawing.Size(1008, 239);
            this.txbSQL.TabIndex = 16;
            this.txbSQL.Visible = false;
            // 
            // chkXoaBackup
            // 
            this.chkXoaBackup.AutoSize = true;
            this.chkXoaBackup.Location = new System.Drawing.Point(1216, 7);
            this.chkXoaBackup.Name = "chkXoaBackup";
            this.chkXoaBackup.Size = new System.Drawing.Size(128, 21);
            this.chkXoaBackup.TabIndex = 15;
            this.chkXoaBackup.Text = "Tạo backup mới";
            this.chkXoaBackup.UseVisualStyleBackColor = true;
            this.chkXoaBackup.CheckedChanged += new System.EventHandler(this.chkXoaBackup_CheckedChanged);
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "HH:mm:ss dd-MM-yyyy";
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(911, 0);
            this.dtpDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(200, 23);
            this.dtpDateTime.TabIndex = 14;
            this.dtpDateTime.Visible = false;
            // 
            // chbThamSo
            // 
            this.chbThamSo.AutoSize = true;
            this.chbThamSo.Location = new System.Drawing.Point(638, 2);
            this.chbThamSo.Name = "chbThamSo";
            this.chbThamSo.Size = new System.Drawing.Size(228, 21);
            this.chbThamSo.TabIndex = 13;
            this.chbThamSo.Text = "Tham số phục hồi theo thời gian";
            this.chbThamSo.UseVisualStyleBackColor = true;
            this.chbThamSo.CheckedChanged += new System.EventHandler(this.chbThamSo_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTaoDevice,
            this.menuSaoLuu,
            this.menuPhucHoi,
            this.xoá1BảnSaoLưuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTaoDevice
            // 
            this.menuTaoDevice.Name = "menuTaoDevice";
            this.menuTaoDevice.Size = new System.Drawing.Size(147, 24);
            this.menuTaoDevice.Text = "Tạo device sao lưu";
            this.menuTaoDevice.Click += new System.EventHandler(this.menuTaoDevice_Click);
            // 
            // menuSaoLuu
            // 
            this.menuSaoLuu.Name = "menuSaoLuu";
            this.menuSaoLuu.Size = new System.Drawing.Size(73, 24);
            this.menuSaoLuu.Text = "Sao lưu";
            this.menuSaoLuu.Click += new System.EventHandler(this.menuSaoLuu_Click_1);
            // 
            // menuPhucHoi
            // 
            this.menuPhucHoi.Name = "menuPhucHoi";
            this.menuPhucHoi.Size = new System.Drawing.Size(79, 24);
            this.menuPhucHoi.Text = "Phục hồi";
            this.menuPhucHoi.Click += new System.EventHandler(this.menuPhucHoi_Click_1);
            // 
            // xoá1BảnSaoLưuToolStripMenuItem
            // 
            this.xoá1BảnSaoLưuToolStripMenuItem.Name = "xoá1BảnSaoLưuToolStripMenuItem";
            this.xoá1BảnSaoLưuToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.xoá1BảnSaoLưuToolStripMenuItem.Text = "Xoá 1 bản sao lưu";
            this.xoá1BảnSaoLưuToolStripMenuItem.Click += new System.EventHandler(this.xoá1BảnSaoLưuToolStripMenuItem_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databasesBindingSource
            // 
            this.databasesBindingSource.DataMember = "databases";
            this.databasesBindingSource.DataSource = this.dataSet1;
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BACKUP_RESTORE_SQL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // databasesGridControl
            // 
            this.databasesGridControl.DataSource = this.databasesBindingSource;
            this.databasesGridControl.Location = new System.Drawing.Point(12, 46);
            this.databasesGridControl.MainView = this.gridView1;
            this.databasesGridControl.Name = "databasesGridControl";
            this.databasesGridControl.Size = new System.Drawing.Size(306, 598);
            this.databasesGridControl.TabIndex = 17;
            this.databasesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname});
            this.gridView1.GridControl = this.databasesGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click_1);
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.MinWidth = 25;
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 94;
            // 
            // position_backupBindingSource
            // 
            this.position_backupBindingSource.DataMember = "position_backup";
            this.position_backupBindingSource.DataSource = this.dataSet1;
            // 
            // position_backupTableAdapter
            // 
            this.position_backupTableAdapter.ClearBeforeFill = true;
            // 
            // position_backupGridControl
            // 
            this.position_backupGridControl.DataSource = this.position_backupBindingSource;
            this.position_backupGridControl.Location = new System.Drawing.Point(336, 46);
            this.position_backupGridControl.MainView = this.gridView2;
            this.position_backupGridControl.Name = "position_backupGridControl";
            this.position_backupGridControl.Size = new System.Drawing.Size(1008, 353);
            this.position_backupGridControl.TabIndex = 18;
            this.position_backupGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colname1,
            this.colbackup_start_date,
            this.coluser_name});
            this.gridView2.GridControl = this.position_backupGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.Click += new System.EventHandler(this.gridView2_Click_1);
            // 
            // colposition
            // 
            this.colposition.FieldName = "position";
            this.colposition.MinWidth = 25;
            this.colposition.Name = "colposition";
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 0;
            this.colposition.Width = 94;
            // 
            // colname1
            // 
            this.colname1.FieldName = "name";
            this.colname1.MinWidth = 25;
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 1;
            this.colname1.Width = 94;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.MinWidth = 25;
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 2;
            this.colbackup_start_date.Width = 94;
            // 
            // coluser_name
            // 
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.MinWidth = 25;
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 3;
            this.coluser_name.Width = 94;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 664);
            this.Controls.Add(this.txbSQL);
            this.Controls.Add(this.position_backupGridControl);
            this.Controls.Add(this.databasesGridControl);
            this.Controls.Add(this.chkXoaBackup);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.chbThamSo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.position_backupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.position_backupGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSQL;
        private System.Windows.Forms.CheckBox chkXoaBackup;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.CheckBox chbThamSo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTaoDevice;
        private System.Windows.Forms.ToolStripMenuItem menuSaoLuu;
        private System.Windows.Forms.ToolStripMenuItem menuPhucHoi;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource databasesBindingSource;
        private DataSet1TableAdapters.databasesTableAdapter databasesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl databasesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private System.Windows.Forms.BindingSource position_backupBindingSource;
        private DataSet1TableAdapters.position_backupTableAdapter position_backupTableAdapter;
        private DevExpress.XtraGrid.GridControl position_backupGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private System.Windows.Forms.ToolStripMenuItem xoá1BảnSaoLưuToolStripMenuItem;
    }
}
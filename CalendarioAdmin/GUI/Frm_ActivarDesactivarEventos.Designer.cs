namespace CalendarioAdmin.GUI
{
    partial class Frm_ActivarDesactivarEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ActivarDesactivarEventos));
            this.gridActivos = new DevExpress.XtraGrid.GridControl();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvActivos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridInactivos = new DevExpress.XtraGrid.GridControl();
            this.eventosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gvInactivos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInactivos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridActivos
            // 
            this.gridActivos.DataSource = this.eventosBindingSource;
            this.gridActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridActivos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridActivos.Location = new System.Drawing.Point(0, 20);
            this.gridActivos.MainView = this.gvActivos;
            this.gridActivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridActivos.Name = "gridActivos";
            this.gridActivos.Size = new System.Drawing.Size(280, 417);
            this.gridActivos.TabIndex = 0;
            this.gridActivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvActivos});
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataSource = typeof(CalendarioAdmin.Entity.eventos);
            // 
            // gvActivos
            // 
            this.gvActivos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvActivos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvActivos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvActivos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvActivos.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvActivos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvActivos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvActivos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvActivos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvActivos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvActivos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvActivos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvActivos.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvActivos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvActivos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvActivos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvActivos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvActivos.Appearance.Empty.Options.UseBackColor = true;
            this.gvActivos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvActivos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvActivos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvActivos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvActivos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvActivos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvActivos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvActivos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvActivos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvActivos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvActivos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvActivos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvActivos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvActivos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvActivos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvActivos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvActivos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvActivos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvActivos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvActivos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvActivos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvActivos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvActivos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvActivos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvActivos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvActivos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvActivos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvActivos.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvActivos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvActivos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvActivos.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvActivos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvActivos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvActivos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvActivos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvActivos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvActivos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvActivos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvActivos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvActivos.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvActivos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvActivos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvActivos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvActivos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvActivos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvActivos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvActivos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvActivos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvActivos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvActivos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvActivos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvActivos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvActivos.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvActivos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvActivos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvActivos.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvActivos.Appearance.GroupRow.Options.UseFont = true;
            this.gvActivos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvActivos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvActivos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvActivos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvActivos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvActivos.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvActivos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvActivos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvActivos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvActivos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvActivos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvActivos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvActivos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvActivos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvActivos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvActivos.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvActivos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvActivos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvActivos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvActivos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvActivos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvActivos.Appearance.Preview.Options.UseBackColor = true;
            this.gvActivos.Appearance.Preview.Options.UseForeColor = true;
            this.gvActivos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvActivos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvActivos.Appearance.Row.Options.UseBackColor = true;
            this.gvActivos.Appearance.Row.Options.UseForeColor = true;
            this.gvActivos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvActivos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvActivos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvActivos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvActivos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvActivos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvActivos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvActivos.Appearance.VertLine.Options.UseBackColor = true;
            this.gvActivos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre,
            this.colcantidad});
            this.gvActivos.GridControl = this.gridActivos;
            this.gvActivos.Name = "gvActivos";
            this.gvActivos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvActivos.OptionsView.EnableAppearanceOddRow = true;
            this.gvActivos.OptionsView.ShowGroupPanel = false;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 1;
            // 
            // gridInactivos
            // 
            this.gridInactivos.DataSource = this.eventosBindingSource1;
            this.gridInactivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridInactivos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridInactivos.Location = new System.Drawing.Point(0, 20);
            this.gridInactivos.MainView = this.gvInactivos;
            this.gridInactivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridInactivos.Name = "gridInactivos";
            this.gridInactivos.Size = new System.Drawing.Size(280, 417);
            this.gridInactivos.TabIndex = 1;
            this.gridInactivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInactivos});
            // 
            // eventosBindingSource1
            // 
            this.eventosBindingSource1.DataSource = typeof(CalendarioAdmin.Entity.eventos);
            // 
            // gvInactivos
            // 
            this.gvInactivos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray;
            this.gvInactivos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray;
            this.gvInactivos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray;
            this.gvInactivos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvInactivos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvInactivos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvInactivos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray;
            this.gvInactivos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray;
            this.gvInactivos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.gvInactivos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvInactivos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvInactivos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvInactivos.Appearance.Empty.BackColor = System.Drawing.Color.DimGray;
            this.gvInactivos.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvInactivos.Appearance.Empty.Options.UseBackColor = true;
            this.gvInactivos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvInactivos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvInactivos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.gvInactivos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.gvInactivos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvInactivos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvInactivos.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.gvInactivos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvInactivos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvInactivos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvInactivos.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black;
            this.gvInactivos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvInactivos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvInactivos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvInactivos.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gvInactivos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gvInactivos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvInactivos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvInactivos.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvInactivos.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvInactivos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvInactivos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvInactivos.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver;
            this.gvInactivos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver;
            this.gvInactivos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvInactivos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvInactivos.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray;
            this.gvInactivos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvInactivos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvInactivos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvInactivos.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.gvInactivos.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvInactivos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvInactivos.Appearance.GroupRow.Options.UseFont = true;
            this.gvInactivos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gvInactivos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gvInactivos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvInactivos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvInactivos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray;
            this.gvInactivos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvInactivos.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.gvInactivos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvInactivos.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvInactivos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvInactivos.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.gvInactivos.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.gvInactivos.Appearance.Preview.Options.UseBackColor = true;
            this.gvInactivos.Appearance.Preview.Options.UseForeColor = true;
            this.gvInactivos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvInactivos.Appearance.Row.Options.UseBackColor = true;
            this.gvInactivos.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.gvInactivos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvInactivos.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray;
            this.gvInactivos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvInactivos.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray;
            this.gvInactivos.Appearance.VertLine.Options.UseBackColor = true;
            this.gvInactivos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre1,
            this.colcantidad1});
            this.gvInactivos.GridControl = this.gridInactivos;
            this.gvInactivos.Name = "gvInactivos";
            this.gvInactivos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvInactivos.OptionsView.EnableAppearanceOddRow = true;
            this.gvInactivos.OptionsView.ShowGroupPanel = false;
            // 
            // colnombre1
            // 
            this.colnombre1.Caption = "Nombre";
            this.colnombre1.FieldName = "nombre";
            this.colnombre1.Name = "colnombre1";
            this.colnombre1.Visible = true;
            this.colnombre1.VisibleIndex = 0;
            // 
            // colcantidad1
            // 
            this.colcantidad1.Caption = "Cantidad";
            this.colcantidad1.FieldName = "cantidad";
            this.colcantidad1.Name = "colcantidad1";
            this.colcantidad1.Visible = true;
            this.colcantidad1.VisibleIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Activar o Desactvar Eventos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Activos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inactivos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridActivos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 437);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridInactivos);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(360, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 437);
            this.panel2.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(289, 481);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDesactivar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivar.Location = new System.Drawing.Point(298, 111);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(56, 35);
            this.btnDesactivar.TabIndex = 8;
            this.btnDesactivar.Text = ">>";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActivar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.Location = new System.Drawing.Point(298, 152);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(56, 35);
            this.btnActivar.TabIndex = 9;
            this.btnActivar.Text = "<<";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // Frm_ActivarDesactivarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 523);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_ActivarDesactivarEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activar o Desactivar Eventos";
            this.Load += new System.EventHandler(this.Frm_ActivarDesactivarEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInactivos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridActivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvActivos;
        private DevExpress.XtraGrid.GridControl gridInactivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInactivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private System.Windows.Forms.BindingSource eventosBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad1;
    }
}
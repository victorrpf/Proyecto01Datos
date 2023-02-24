namespace Proyecto01Datos
{
    partial class fmConsultaFiltra
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
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmConsultaFiltra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.telefonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_telefonosDataSet = new Proyecto01Datos.bd_telefonosDataSet();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.gbCiudad = new System.Windows.Forms.GroupBox();
            this.ckCiudad = new System.Windows.Forms.CheckBox();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.gbLetras = new System.Windows.Forms.GroupBox();
            this.ckLetra = new System.Windows.Forms.CheckBox();
            this.cbLetra = new System.Windows.Forms.ComboBox();
            this.gbProvincias = new System.Windows.Forms.GroupBox();
            this.ckProvincia = new System.Windows.Forms.CheckBox();
            this.cbProvincias = new System.Windows.Forms.ComboBox();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.ckAscendente = new System.Windows.Forms.CheckBox();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.telefonosTableAdapter = new Proyecto01Datos.bd_telefonosDataSetTableAdapters.telefonosTableAdapter();
            this.tableAdapterManager = new Proyecto01Datos.bd_telefonosDataSetTableAdapters.TableAdapterManager();
            this.telefonosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.telefonosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).BeginInit();
            this.gbCiudad.SuspendLayout();
            this.gbLetras.SuspendLayout();
            this.gbProvincias.SuspendLayout();
            this.gbOrdenar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingNavigator)).BeginInit();
            this.telefonosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(186, 20);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(107, 16);
            idLabel.TabIndex = 7;
            idLabel.Text = "ID Seleccionado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.btBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbBuscar);
            this.panel1.Controls.Add(this.gbCiudad);
            this.panel1.Controls.Add(this.gbLetras);
            this.panel1.Controls.Add(this.gbProvincias);
            this.panel1.Controls.Add(this.gbOrdenar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 539);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 148);
            this.panel1.TabIndex = 0;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(310, 17);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(48, 22);
            this.idTextBox.TabIndex = 8;
            // 
            // telefonosBindingSource
            // 
            this.telefonosBindingSource.DataMember = "telefonos";
            this.telefonosBindingSource.DataSource = this.bd_telefonosDataSet;
            // 
            // bd_telefonosDataSet
            // 
            this.bd_telefonosDataSet.DataSetName = "bd_telefonosDataSet";
            this.bd_telefonosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(186, 111);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar por ID";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(186, 80);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(172, 22);
            this.tbBuscar.TabIndex = 4;
            this.tbBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBuscar_KeyDown);
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
            // 
            // gbCiudad
            // 
            this.gbCiudad.Controls.Add(this.ckCiudad);
            this.gbCiudad.Controls.Add(this.cbCiudad);
            this.gbCiudad.Location = new System.Drawing.Point(874, 3);
            this.gbCiudad.Name = "gbCiudad";
            this.gbCiudad.Size = new System.Drawing.Size(200, 142);
            this.gbCiudad.TabIndex = 3;
            this.gbCiudad.TabStop = false;
            this.gbCiudad.Text = "Filtrar por Ciudad";
            // 
            // ckCiudad
            // 
            this.ckCiudad.AutoSize = true;
            this.ckCiudad.Location = new System.Drawing.Point(20, 77);
            this.ckCiudad.Name = "ckCiudad";
            this.ckCiudad.Size = new System.Drawing.Size(62, 20);
            this.ckCiudad.TabIndex = 1;
            this.ckCiudad.Text = "Filtrar";
            this.ckCiudad.UseVisualStyleBackColor = true;
            this.ckCiudad.CheckedChanged += new System.EventHandler(this.filtrosCk_CheckedChanged);
            // 
            // cbCiudad
            // 
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Items.AddRange(new object[] {
            "Alcalá de Henares",
            "Alcobendas",
            "Alicante",
            "Argentona",
            "Elche",
            "Gijón",
            "Mataporquera",
            "Muxía"});
            this.cbCiudad.Location = new System.Drawing.Point(20, 32);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(121, 24);
            this.cbCiudad.TabIndex = 0;
            this.cbCiudad.TextChanged += new System.EventHandler(this.filtrosCk_CheckedChanged);
            // 
            // gbLetras
            // 
            this.gbLetras.Controls.Add(this.ckLetra);
            this.gbLetras.Controls.Add(this.cbLetra);
            this.gbLetras.Location = new System.Drawing.Point(581, 3);
            this.gbLetras.Name = "gbLetras";
            this.gbLetras.Size = new System.Drawing.Size(286, 142);
            this.gbLetras.TabIndex = 3;
            this.gbLetras.TabStop = false;
            this.gbLetras.Text = "Filtrar por nombres que empiezan por...";
            // 
            // ckLetra
            // 
            this.ckLetra.AutoSize = true;
            this.ckLetra.Location = new System.Drawing.Point(25, 77);
            this.ckLetra.Name = "ckLetra";
            this.ckLetra.Size = new System.Drawing.Size(62, 20);
            this.ckLetra.TabIndex = 1;
            this.ckLetra.Text = "Filtrar";
            this.ckLetra.UseVisualStyleBackColor = true;
            this.ckLetra.CheckedChanged += new System.EventHandler(this.filtrosCk_CheckedChanged);
            // 
            // cbLetra
            // 
            this.cbLetra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetra.FormattingEnabled = true;
            this.cbLetra.Items.AddRange(new object[] {
            "A",
            "E",
            "J",
            "L",
            "M",
            "P",
            "S"});
            this.cbLetra.Location = new System.Drawing.Point(25, 31);
            this.cbLetra.Name = "cbLetra";
            this.cbLetra.Size = new System.Drawing.Size(60, 24);
            this.cbLetra.TabIndex = 0;
            this.cbLetra.TextChanged += new System.EventHandler(this.filtrosCk_CheckedChanged);
            // 
            // gbProvincias
            // 
            this.gbProvincias.Controls.Add(this.ckProvincia);
            this.gbProvincias.Controls.Add(this.cbProvincias);
            this.gbProvincias.Location = new System.Drawing.Point(375, 3);
            this.gbProvincias.Name = "gbProvincias";
            this.gbProvincias.Size = new System.Drawing.Size(200, 142);
            this.gbProvincias.TabIndex = 2;
            this.gbProvincias.TabStop = false;
            this.gbProvincias.Text = "Filtrar por Provincia";
            // 
            // ckProvincia
            // 
            this.ckProvincia.AutoSize = true;
            this.ckProvincia.Location = new System.Drawing.Point(15, 77);
            this.ckProvincia.Name = "ckProvincia";
            this.ckProvincia.Size = new System.Drawing.Size(62, 20);
            this.ckProvincia.TabIndex = 1;
            this.ckProvincia.Text = "Filtrar";
            this.ckProvincia.UseVisualStyleBackColor = true;
            this.ckProvincia.CheckedChanged += new System.EventHandler(this.filtrosCk_CheckedChanged);
            // 
            // cbProvincias
            // 
            this.cbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincias.FormattingEnabled = true;
            this.cbProvincias.Items.AddRange(new object[] {
            "Alicante",
            "Asturias",
            "Barcelona",
            "Cantabria",
            "la 12",
            "La Coruña",
            "Madrid"});
            this.cbProvincias.Location = new System.Drawing.Point(15, 32);
            this.cbProvincias.Name = "cbProvincias";
            this.cbProvincias.Size = new System.Drawing.Size(121, 24);
            this.cbProvincias.TabIndex = 0;
            this.cbProvincias.TextChanged += new System.EventHandler(this.filtrosCk_CheckedChanged);
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.ckAscendente);
            this.gbOrdenar.Controls.Add(this.rbId);
            this.gbOrdenar.Controls.Add(this.rbNombre);
            this.gbOrdenar.Location = new System.Drawing.Point(12, 3);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Size = new System.Drawing.Size(158, 142);
            this.gbOrdenar.TabIndex = 1;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Ordenar por";
            // 
            // ckAscendente
            // 
            this.ckAscendente.AutoSize = true;
            this.ckAscendente.Checked = true;
            this.ckAscendente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAscendente.Location = new System.Drawing.Point(40, 104);
            this.ckAscendente.Name = "ckAscendente";
            this.ckAscendente.Size = new System.Drawing.Size(101, 20);
            this.ckAscendente.TabIndex = 2;
            this.ckAscendente.Text = "Ascendente";
            this.ckAscendente.UseVisualStyleBackColor = true;
            this.ckAscendente.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // rbId
            // 
            this.rbId.AutoSize = true;
            this.rbId.Location = new System.Drawing.Point(24, 66);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(88, 20);
            this.rbId.TabIndex = 1;
            this.rbId.Text = "Codigo ID";
            this.rbId.UseVisualStyleBackColor = true;
            this.rbId.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Checked = true;
            this.rbNombre.Location = new System.Drawing.Point(24, 32);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(77, 20);
            this.rbNombre.TabIndex = 0;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // telefonosTableAdapter
            // 
            this.telefonosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.telefonosTableAdapter = this.telefonosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto01Datos.bd_telefonosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // telefonosBindingNavigator
            // 
            this.telefonosBindingNavigator.AddNewItem = null;
            this.telefonosBindingNavigator.BindingSource = this.telefonosBindingSource;
            this.telefonosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.telefonosBindingNavigator.DeleteItem = null;
            this.telefonosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.telefonosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.telefonosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.telefonosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.telefonosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.telefonosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.telefonosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.telefonosBindingNavigator.Name = "telefonosBindingNavigator";
            this.telefonosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.telefonosBindingNavigator.Size = new System.Drawing.Size(1094, 27);
            this.telefonosBindingNavigator.TabIndex = 1;
            this.telefonosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // telefonosDataGridView
            // 
            this.telefonosDataGridView.AllowUserToAddRows = false;
            this.telefonosDataGridView.AllowUserToDeleteRows = false;
            this.telefonosDataGridView.AutoGenerateColumns = false;
            this.telefonosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telefonosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.telefonosDataGridView.DataSource = this.telefonosBindingSource;
            this.telefonosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telefonosDataGridView.Location = new System.Drawing.Point(0, 27);
            this.telefonosDataGridView.Name = "telefonosDataGridView";
            this.telefonosDataGridView.RowHeadersWidth = 51;
            this.telefonosDataGridView.RowTemplate.Height = 24;
            this.telefonosDataGridView.Size = new System.Drawing.Size(1094, 512);
            this.telefonosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "observaciones";
            this.dataGridViewTextBoxColumn5.HeaderText = "observaciones";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ciudad";
            this.dataGridViewTextBoxColumn6.HeaderText = "ciudad";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "provincia";
            this.dataGridViewTextBoxColumn7.HeaderText = "provincia";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "pais";
            this.dataGridViewTextBoxColumn8.HeaderText = "pais";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // fmConsultaFiltra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 687);
            this.Controls.Add(this.telefonosDataGridView);
            this.Controls.Add(this.telefonosBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "fmConsultaFiltra";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.fmConsultaFiltra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).EndInit();
            this.gbCiudad.ResumeLayout(false);
            this.gbCiudad.PerformLayout();
            this.gbLetras.ResumeLayout(false);
            this.gbLetras.PerformLayout();
            this.gbProvincias.ResumeLayout(false);
            this.gbProvincias.PerformLayout();
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingNavigator)).EndInit();
            this.telefonosBindingNavigator.ResumeLayout(false);
            this.telefonosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbCiudad;
        private System.Windows.Forms.GroupBox gbLetras;
        private System.Windows.Forms.GroupBox gbProvincias;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBuscar;
        private bd_telefonosDataSet bd_telefonosDataSet;
        private System.Windows.Forms.BindingSource telefonosBindingSource;
        private bd_telefonosDataSetTableAdapters.telefonosTableAdapter telefonosTableAdapter;
        private bd_telefonosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator telefonosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView telefonosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.CheckBox ckAscendente;
        private System.Windows.Forms.RadioButton rbId;
        private System.Windows.Forms.CheckBox ckCiudad;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.CheckBox ckLetra;
        private System.Windows.Forms.ComboBox cbLetra;
        private System.Windows.Forms.CheckBox ckProvincia;
        private System.Windows.Forms.ComboBox cbProvincias;
    }
}
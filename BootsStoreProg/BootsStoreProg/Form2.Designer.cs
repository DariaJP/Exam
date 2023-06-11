namespace BootsStoreProg
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDBootDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edinicaIzmereniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razmerMaxVosmozhnoySkidkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvoditelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavshikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriiTovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deistvuyushayaSkidkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvonaskladeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagesDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.bootBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bootsStoreDataSet = new BootsStoreProg.BootsStoreDataSet();
            this.bootTableAdapter = new BootsStoreProg.BootsStoreDataSetTableAdapters.BootTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bootBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bootsStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBootDataGridViewTextBoxColumn,
            this.articulDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.edinicaIzmereniaDataGridViewTextBoxColumn,
            this.stoimostDataGridViewTextBoxColumn,
            this.razmerMaxVosmozhnoySkidkiDataGridViewTextBoxColumn,
            this.proizvoditelDataGridViewTextBoxColumn,
            this.postavshikDataGridViewTextBoxColumn,
            this.kategoriiTovaraDataGridViewTextBoxColumn,
            this.deistvuyushayaSkidkaDataGridViewTextBoxColumn,
            this.kolvonaskladeDataGridViewTextBoxColumn,
            this.opisanieDataGridViewTextBoxColumn,
            this.imagesDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.bootBindingSource;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1353, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDBootDataGridViewTextBoxColumn
            // 
            this.iDBootDataGridViewTextBoxColumn.DataPropertyName = "ID_Boot";
            this.iDBootDataGridViewTextBoxColumn.HeaderText = "ID_Boot";
            this.iDBootDataGridViewTextBoxColumn.Name = "iDBootDataGridViewTextBoxColumn";
            // 
            // articulDataGridViewTextBoxColumn
            // 
            this.articulDataGridViewTextBoxColumn.DataPropertyName = "Articul";
            this.articulDataGridViewTextBoxColumn.HeaderText = "Articul";
            this.articulDataGridViewTextBoxColumn.Name = "articulDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // edinicaIzmereniaDataGridViewTextBoxColumn
            // 
            this.edinicaIzmereniaDataGridViewTextBoxColumn.DataPropertyName = "Edinica_Izmerenia";
            this.edinicaIzmereniaDataGridViewTextBoxColumn.HeaderText = "Edinica_Izmerenia";
            this.edinicaIzmereniaDataGridViewTextBoxColumn.Name = "edinicaIzmereniaDataGridViewTextBoxColumn";
            // 
            // stoimostDataGridViewTextBoxColumn
            // 
            this.stoimostDataGridViewTextBoxColumn.DataPropertyName = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.HeaderText = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.Name = "stoimostDataGridViewTextBoxColumn";
            // 
            // razmerMaxVosmozhnoySkidkiDataGridViewTextBoxColumn
            // 
            this.razmerMaxVosmozhnoySkidkiDataGridViewTextBoxColumn.DataPropertyName = "RazmerMaxVosmozhnoySkidki";
            this.razmerMaxVosmozhnoySkidkiDataGridViewTextBoxColumn.HeaderText = "RazmerMaxVosmozhnoySkidki";
            this.razmerMaxVosmozhnoySkidkiDataGridViewTextBoxColumn.Name = "razmerMaxVosmozhnoySkidkiDataGridViewTextBoxColumn";
            // 
            // proizvoditelDataGridViewTextBoxColumn
            // 
            this.proizvoditelDataGridViewTextBoxColumn.DataPropertyName = "Proizvoditel";
            this.proizvoditelDataGridViewTextBoxColumn.HeaderText = "Proizvoditel";
            this.proizvoditelDataGridViewTextBoxColumn.Name = "proizvoditelDataGridViewTextBoxColumn";
            // 
            // postavshikDataGridViewTextBoxColumn
            // 
            this.postavshikDataGridViewTextBoxColumn.DataPropertyName = "Postavshik";
            this.postavshikDataGridViewTextBoxColumn.HeaderText = "Postavshik";
            this.postavshikDataGridViewTextBoxColumn.Name = "postavshikDataGridViewTextBoxColumn";
            // 
            // kategoriiTovaraDataGridViewTextBoxColumn
            // 
            this.kategoriiTovaraDataGridViewTextBoxColumn.DataPropertyName = "KategoriiTovara";
            this.kategoriiTovaraDataGridViewTextBoxColumn.HeaderText = "KategoriiTovara";
            this.kategoriiTovaraDataGridViewTextBoxColumn.Name = "kategoriiTovaraDataGridViewTextBoxColumn";
            // 
            // deistvuyushayaSkidkaDataGridViewTextBoxColumn
            // 
            this.deistvuyushayaSkidkaDataGridViewTextBoxColumn.DataPropertyName = "DeistvuyushayaSkidka";
            this.deistvuyushayaSkidkaDataGridViewTextBoxColumn.HeaderText = "DeistvuyushayaSkidka";
            this.deistvuyushayaSkidkaDataGridViewTextBoxColumn.Name = "deistvuyushayaSkidkaDataGridViewTextBoxColumn";
            // 
            // kolvonaskladeDataGridViewTextBoxColumn
            // 
            this.kolvonaskladeDataGridViewTextBoxColumn.DataPropertyName = "Kolvo_na_sklade";
            this.kolvonaskladeDataGridViewTextBoxColumn.HeaderText = "Kolvo_na_sklade";
            this.kolvonaskladeDataGridViewTextBoxColumn.Name = "kolvonaskladeDataGridViewTextBoxColumn";
            // 
            // opisanieDataGridViewTextBoxColumn
            // 
            this.opisanieDataGridViewTextBoxColumn.DataPropertyName = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn.HeaderText = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn.Name = "opisanieDataGridViewTextBoxColumn";
            // 
            // imagesDataGridViewImageColumn
            // 
            this.imagesDataGridViewImageColumn.DataPropertyName = "images";
            this.imagesDataGridViewImageColumn.HeaderText = "images";
            this.imagesDataGridViewImageColumn.Name = "imagesDataGridViewImageColumn";
            // 
            // bootBindingSource
            // 
            this.bootBindingSource.DataMember = "Boot";
            this.bootBindingSource.DataSource = this.bootsStoreDataSet;
            // 
            // bootsStoreDataSet
            // 
            this.bootsStoreDataSet.DataSetName = "BootsStoreDataSet";
            this.bootsStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bootTableAdapter
            // 
            this.bootTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "По возрастанию";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(12, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "По убыванию";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(1219, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(548, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 219);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Изображение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Выведённых данных: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 289);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 263);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 20);
            this.textBox2.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 468);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form2";
            this.Text = "Магазины обуви";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bootBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bootsStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BootsStoreDataSet bootsStoreDataSet;
        private System.Windows.Forms.BindingSource bootBindingSource;
        private BootsStoreDataSetTableAdapters.BootTableAdapter bootTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBootDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edinicaIzmereniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razmerMaxVosmozhnoySkidkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvoditelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavshikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriiTovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deistvuyushayaSkidkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvonaskladeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagesDataGridViewImageColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
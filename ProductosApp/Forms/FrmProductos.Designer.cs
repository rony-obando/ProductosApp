
namespace ProductosApp.Forms
{
    partial class FrmProductos
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rtbProductView = new System.Windows.Forms.RichTextBox();
            this.cmbFinderType = new System.Windows.Forms.ComboBox();
            this.cmbUnitMeasur = new System.Windows.Forms.ComboBox();
            this.txtFinder = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.nubRangeHigher = new System.Windows.Forms.NumericUpDown();
            this.nubRangeLess = new System.Windows.Forms.NumericUpDown();
            this.lblRangMn = new System.Windows.Forms.Label();
            this.lblRangMy = new System.Windows.Forms.Label();
            this.dtpFinder = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrden = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubRangeHigher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubRangeLess)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnOrden);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 299);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 46);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 40);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(109, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(215, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rtbProductView
            // 
            this.rtbProductView.Location = new System.Drawing.Point(6, 61);
            this.rtbProductView.Name = "rtbProductView";
            this.rtbProductView.Size = new System.Drawing.Size(776, 232);
            this.rtbProductView.TabIndex = 1;
            this.rtbProductView.Text = "";
            // 
            // cmbFinderType
            // 
            this.cmbFinderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinderType.FormattingEnabled = true;
            this.cmbFinderType.Items.AddRange(new object[] {
            "Buscar por ID",
            "Rango de Precio",
            "Fecha de Vencimiento",
            "Unidad de Medida"});
            this.cmbFinderType.Location = new System.Drawing.Point(6, 25);
            this.cmbFinderType.Name = "cmbFinderType";
            this.cmbFinderType.Size = new System.Drawing.Size(171, 21);
            this.cmbFinderType.TabIndex = 2;
            this.cmbFinderType.SelectedIndexChanged += new System.EventHandler(this.cmbFinderType_SelectedIndexChanged);
            // 
            // cmbUnitMeasur
            // 
            this.cmbUnitMeasur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitMeasur.FormattingEnabled = true;
            this.cmbUnitMeasur.Location = new System.Drawing.Point(234, 22);
            this.cmbUnitMeasur.Name = "cmbUnitMeasur";
            this.cmbUnitMeasur.Size = new System.Drawing.Size(241, 21);
            this.cmbUnitMeasur.TabIndex = 3;
            this.cmbUnitMeasur.Visible = false;
            // 
            // txtFinder
            // 
            this.txtFinder.Location = new System.Drawing.Point(234, 23);
            this.txtFinder.Name = "txtFinder";
            this.txtFinder.Size = new System.Drawing.Size(241, 20);
            this.txtFinder.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(594, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // nubRangeHigher
            // 
            this.nubRangeHigher.DecimalPlaces = 2;
            this.nubRangeHigher.Location = new System.Drawing.Point(375, 22);
            this.nubRangeHigher.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.nubRangeHigher.Name = "nubRangeHigher";
            this.nubRangeHigher.Size = new System.Drawing.Size(100, 20);
            this.nubRangeHigher.TabIndex = 6;
            this.nubRangeHigher.Visible = false;
            this.nubRangeHigher.ValueChanged += new System.EventHandler(this.nubRangeHigher_ValueChanged);
            // 
            // nubRangeLess
            // 
            this.nubRangeLess.DecimalPlaces = 2;
            this.nubRangeLess.Location = new System.Drawing.Point(234, 23);
            this.nubRangeLess.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nubRangeLess.Name = "nubRangeLess";
            this.nubRangeLess.Size = new System.Drawing.Size(100, 20);
            this.nubRangeLess.TabIndex = 7;
            this.nubRangeLess.Visible = false;
            this.nubRangeLess.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lblRangMn
            // 
            this.lblRangMn.AutoSize = true;
            this.lblRangMn.Location = new System.Drawing.Point(231, 3);
            this.lblRangMn.Name = "lblRangMn";
            this.lblRangMn.Size = new System.Drawing.Size(74, 13);
            this.lblRangMn.TabIndex = 8;
            this.lblRangMn.Text = "Rango menor:";
            this.lblRangMn.Visible = false;
            // 
            // lblRangMy
            // 
            this.lblRangMy.AutoSize = true;
            this.lblRangMy.Location = new System.Drawing.Point(375, 3);
            this.lblRangMy.Name = "lblRangMy";
            this.lblRangMy.Size = new System.Drawing.Size(73, 13);
            this.lblRangMy.TabIndex = 9;
            this.lblRangMy.Text = "Rango mayor:";
            this.lblRangMy.Visible = false;
            // 
            // dtpFinder
            // 
            this.dtpFinder.Location = new System.Drawing.Point(234, 23);
            this.dtpFinder.Name = "dtpFinder";
            this.dtpFinder.Size = new System.Drawing.Size(241, 20);
            this.dtpFinder.TabIndex = 10;
            this.dtpFinder.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar Por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOrden
            // 
            this.btnOrden.Location = new System.Drawing.Point(321, 3);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(100, 40);
            this.btnOrden.TabIndex = 3;
            this.btnOrden.Text = "Ordenar por precio";
            this.btnOrden.UseVisualStyleBackColor = true;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFinder);
            this.Controls.Add(this.lblRangMy);
            this.Controls.Add(this.lblRangMn);
            this.Controls.Add(this.nubRangeLess);
            this.Controls.Add(this.nubRangeHigher);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFinder);
            this.Controls.Add(this.cmbUnitMeasur);
            this.Controls.Add(this.cmbFinderType);
            this.Controls.Add(this.rtbProductView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nubRangeHigher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubRangeLess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox rtbProductView;
        private System.Windows.Forms.ComboBox cmbFinderType;
        private System.Windows.Forms.ComboBox cmbUnitMeasur;
        private System.Windows.Forms.TextBox txtFinder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown nubRangeHigher;
        private System.Windows.Forms.NumericUpDown nubRangeLess;
        private System.Windows.Forms.Label lblRangMn;
        private System.Windows.Forms.Label lblRangMy;
        private System.Windows.Forms.DateTimePicker dtpFinder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrden;
    }
}
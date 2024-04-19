namespace Supermarket_mvp.Views
{
    partial class CategoriaView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCategoriaList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCategoria = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoriaDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCategoriaObservation = new TextBox();
            label5 = new Label();
            TxtCategoriaName = new TextBox();
            label4 = new Label();
            TxtCategoriaId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoriaList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategoria).BeginInit();
            tabPageCategoriaDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categories;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(154, 34);
            label1.Name = "label1";
            label1.Size = new Size(224, 54);
            label1.TabIndex = 0;
            label1.Text = "Categorias";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoriaList);
            tabControl1.Controls.Add(tabPageCategoriaDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 325);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategoriaList
            // 
            tabPageCategoriaList.Controls.Add(BtnClose);
            tabPageCategoriaList.Controls.Add(BtnDelete);
            tabPageCategoriaList.Controls.Add(BtnEdit);
            tabPageCategoriaList.Controls.Add(BtnNew);
            tabPageCategoriaList.Controls.Add(DgCategoria);
            tabPageCategoriaList.Controls.Add(BtnSearch);
            tabPageCategoriaList.Controls.Add(TxtSearch);
            tabPageCategoriaList.Controls.Add(label2);
            tabPageCategoriaList.Location = new Point(4, 29);
            tabPageCategoriaList.Name = "tabPageCategoriaList";
            tabPageCategoriaList.Padding = new Padding(3);
            tabPageCategoriaList.Size = new Size(792, 292);
            tabPageCategoriaList.TabIndex = 0;
            tabPageCategoriaList.Text = "Categoria List";
            tabPageCategoriaList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackColor = Color.LightGray;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(645, 235);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(139, 38);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackColor = Color.LightGray;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(645, 183);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(139, 38);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.BackColor = Color.LightGray;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(645, 131);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(139, 40);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.BackColor = Color.LightGray;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(645, 77);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(139, 42);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // DgCategoria
            // 
            DgCategoria.AllowUserToAddRows = false;
            DgCategoria.AllowUserToDeleteRows = false;
            DgCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategoria.Location = new Point(8, 68);
            DgCategoria.Name = "DgCategoria";
            DgCategoria.ReadOnly = true;
            DgCategoria.RowHeadersWidth = 51;
            DgCategoria.Size = new Size(631, 216);
            DgCategoria.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small2;
            BtnSearch.Location = new Point(645, 27);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 43);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(21, 35);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(618, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(21, 12);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Categoria";
            // 
            // tabPageCategoriaDetail
            // 
            tabPageCategoriaDetail.Controls.Add(BtnCancel);
            tabPageCategoriaDetail.Controls.Add(BtnSave);
            tabPageCategoriaDetail.Controls.Add(TxtCategoriaObservation);
            tabPageCategoriaDetail.Controls.Add(label5);
            tabPageCategoriaDetail.Controls.Add(TxtCategoriaName);
            tabPageCategoriaDetail.Controls.Add(label4);
            tabPageCategoriaDetail.Controls.Add(TxtCategoriaId);
            tabPageCategoriaDetail.Controls.Add(label3);
            tabPageCategoriaDetail.Location = new Point(4, 29);
            tabPageCategoriaDetail.Name = "tabPageCategoriaDetail";
            tabPageCategoriaDetail.Padding = new Padding(3);
            tabPageCategoriaDetail.Size = new Size(792, 292);
            tabPageCategoriaDetail.TabIndex = 1;
            tabPageCategoriaDetail.Text = "Categoria Detail";
            tabPageCategoriaDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.LightGray;
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(119, 231);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 43);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.LightGray;
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(8, 231);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 43);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // TxtCategoriaObservation
            // 
            TxtCategoriaObservation.Location = new Point(8, 143);
            TxtCategoriaObservation.Multiline = true;
            TxtCategoriaObservation.Name = "TxtCategoriaObservation";
            TxtCategoriaObservation.PlaceholderText = "Observaciones Categoria";
            TxtCategoriaObservation.Size = new Size(251, 72);
            TxtCategoriaObservation.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(8, 120);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 4;
            label5.Text = "Observaciones";
            // 
            // TxtCategoriaName
            // 
            TxtCategoriaName.Location = new Point(8, 90);
            TxtCategoriaName.Name = "TxtCategoriaName";
            TxtCategoriaName.PlaceholderText = "Nombre Categoria";
            TxtCategoriaName.Size = new Size(251, 27);
            TxtCategoriaName.TabIndex = 3;
            TxtCategoriaName.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(8, 67);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 2;
            label4.Text = "Nombre Categoria";
            // 
            // TxtCategoriaId
            // 
            TxtCategoriaId.Location = new Point(8, 37);
            TxtCategoriaId.Name = "TxtCategoriaId";
            TxtCategoriaId.Size = new Size(251, 27);
            TxtCategoriaId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(8, 14);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 0;
            label3.Text = "Categoria Id";
            // 
            // CategoriaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriaView";
            Text = "Categoria Management";
            Load += CategoriaView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoriaList.ResumeLayout(false);
            tabPageCategoriaList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategoria).EndInit();
            tabPageCategoriaDetail.ResumeLayout(false);
            tabPageCategoriaDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCategoriaList;
        private TabPage tabPageCategoriaDetail;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCategoria;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCategoriaObservation;
        private Label label5;
        private TextBox TxtCategoriaName;
        private Label label4;
        private TextBox TxtCategoriaId;
        private Label label3;
    }
}
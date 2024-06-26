﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class CategoriaView : Form, ICategoriaView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public CategoriaView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageCategoriaDetail);
            BtnClose.Click += delegate { this.Close(); };
        }
        public string CategoriaId 
        {
            get { return TxtCategoriaId.Text; }
            set { TxtCategoriaId.Text = value; }

        }
        public string CategoriaName 
        {
            get { return TxtCategoriaName.Text; }
            set { TxtCategoriaName.Text = value; }
        }
        public string CategoriaObservation 
        {
            get { return TxtCategoriaObservation.Text; }
            set { TxtCategoriaObservation.Text = value; }
        }
        public string SearchValue 
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }

        }
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit = value; }

        }
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }

        }
        public string Message 
        {
            get { return message; }
            set { message = value; }

        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNew.Click += delegate {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategoriaList);
                tabControl1.TabPages.Add(tabPageCategoriaDetail);
                tabPageCategoriaDetail.Text = "Add New Categoria";

            };

            BtnEdit.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategoriaList);
                tabControl1.TabPages.Add(tabPageCategoriaDetail);
                tabPageCategoriaDetail.Text = "Edit Categoria";

            };

            BtnDelete.Click += delegate {
                DeleteEvent?.Invoke(this, EventArgs.Empty);

                var result = MessageBox.Show(
                    "Esta seguro que desea eliminar la categoria seleccionada",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };

            BtnSave.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageCategoriaDetail);
                    tabControl1.TabPages.Add(tabPageCategoriaList);
                }
                MessageBox.Show(Message);

            };

            BtnCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategoriaDetail);
                tabControl1.TabPages.Add(tabPageCategoriaList);
            };

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoriaView_Load(object sender, EventArgs e)
        {

        }

        public void SetCategoriaListBildingSource(BindingSource categoriaList)
        {
            DgCategoria.DataSource = categoriaList;
        }



        private static CategoriaView instance;
        public static CategoriaView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoriaView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }



    }
}

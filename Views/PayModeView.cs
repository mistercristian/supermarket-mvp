﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }
        public string PayModeName 
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }
        public string PayModeObservation 
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message {
            get { return message; }
            set { message = value; }
        }

        public PayModeView()
        {
            
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPagePayModeDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void PayModeView_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }
       
        private static PayModeView instance;

        public static PayModeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
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
                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Agregar Metodo de Pago";
             
            };
            BtnEdit.Click += delegate { 
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Editar Modo de Pago";
            };
            BtnDelete.Click += delegate 
            {
                var result = MessageBox.Show("Esta seguro que desea borrar el metodo de pago seleccionado",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) 
                {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message);
                }
                DeleteEvent?.Invoke(this, EventArgs.Empty); 


            
            };
            BtnSave.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPagePayModeList);
                    tabControl1.TabPages.Add(tabPagePayModeDetail);
                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);

            };
        }
    }
}

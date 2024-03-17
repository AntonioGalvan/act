﻿using act.Forms.UseCases.Index;
using act.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act.Forms.BaseFlows.Index
{
    //Código referente a la interfaz gráfica
    //Implementamos interfaz de la vista
    public partial class BaseFlow : Form, IBaseFlowView
    {
        public BaseFlow()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tbcBaseFlows.TabPages.Remove(tbpAdd);
            btnOut.Click += delegate { this.Close(); };
        }
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private bool haveUseCase;
        private int? idUseCase;


        //Asociamos los eventos con los métodos
        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tbxSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tbcBaseFlows.TabPages.Remove(tbpList);
                tbcBaseFlows.TabPages.Add(tbpAdd);
                tbpAdd.Text = "Agregar";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tbcBaseFlows.TabPages.Remove(tbpList);
                tbcBaseFlows.TabPages.Add(tbpAdd);
                if (idUseCase != null)
                    cmbUseCases.SelectedValue = idUseCase;
                tbpAdd.Text = "Editar";
            };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                //realizamos acciones si el guardado fue exitoso
                if (IsSuccessful && !HaveUseCase)
                {
                    tbcBaseFlows.TabPages.Remove(tbpAdd);
                    tbcBaseFlows.TabPages.Add(tbpList);
                }
                MessageBox.Show(Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbcBaseFlows.TabPages.Remove(tbpAdd);
                tbcBaseFlows.TabPages.Add(tbpList);
            };

            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("¿Deseas eliminar el registro seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    if (IsSuccessful)
                    {
                        MessageBox.Show(Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            btnAlternatingFlow.Click += delegate
            {
                this.Close();
                OpenbaFlowEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        //Asociamos propiedades a campos disponibles en pantalla
        public string Id
        {
            get { return tbxId.Text; }
            set { tbxId.Text = value; }
        }

        public string Key
        {
            get { return tbxKey.Text; }
            set { tbxKey.Text = value; }
        }

        public string FlowChartPath
        {
            get { return tbxFlowChartPath.Text; }
            set { tbxFlowChartPath.Text = value; }
        }

        public string Name
        {
            get { return tbxName.Text; }
            set { tbxName.Text = value; }
        }

        public int? UseCaseId
        {
            get
            {
                if (cmbUseCases.SelectedValue != null)
                {
                    return Convert.ToInt32(cmbUseCases.SelectedValue.ToString());
                }
                else
                {

                    return 0;
                }

            }
            set { idUseCase = value; }
        }

        //Varaible de control para operaciones de pantalla
        public string SearchValue
        {
            get { return tbxSearch.Text; }
            set { tbxSearch.Text = value; }
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

        //Propiedad que indica si se cuenta con caso de uso
        public bool HaveUseCase
        {
            get { return haveUseCase; }
            set { haveUseCase = value; }
        }

        //Declaramos los handlers para los eventos disparados en la vista
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler OpenbaFlowEvent;

        //Asociamos al grid de datos la lista de flujos base
        public void SetProjectListBindingSource(BindingSource baseFlowsList)
        {
            dgvBaseFlows.DataSource = baseFlowsList;
        }

        //Asociamos a lista la lista de casos de uso
        public void SetObjectTypeListBindingSource(BindingSource typeList)
        {

            cmbUseCases.DisplayMember = "name";
            cmbUseCases.ValueMember = "id";
            cmbUseCases.DataSource = typeList;
        }

        private static BaseFlow instance;

        //Obtenemos la instancia de la pantalla
        public static BaseFlow GetInstance(Form parent)
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new BaseFlow();

                //Código para fijar vista en pantalla
                instance.MdiParent = parent;
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

        //Ocultamos columnas innecesarias
        private void BaseFlow_Load(object sender, EventArgs e)
        {
            dgvBaseFlows.Columns["Id"].Visible = false;
            dgvBaseFlows.Columns["DiagramElementState"].Visible = false;
            dgvBaseFlows.Columns["ScreenElementState"].Visible = false;
            dgvBaseFlows.Columns["ProjectId"].Visible = false;
            dgvBaseFlows.Columns["UseCaseId"].Visible = false;
        }
    }
}

﻿using act.Models.BaseFlows;
using act.Models.Roles;
using act.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Presenters
{
    internal class BaseFlowsPresenter
    {
        private IBaseFlowsRView view;
        private IBaseFlowsRRepository repository;
        private BindingSource bFlowBindingSource;
        private IEnumerable<BaseFlowModel> bFlowList;

        public BaseFlowsPresenter(IBaseFlowsRView pView, IBaseFlowsRRepository pRepository)
        {
            this.bFlowBindingSource = new BindingSource();
            view = pView;
            repository = pRepository;

            this.view.AddNewEvent += AddNewBFlow;
            this.view.EditEvent += LoadSelectedBFlowToEdit;
            this.view.DeleteEvent += DeleteSelectedBFlow;
            this.view.SaveEvent += SaveBFlow;
            this.view.CancelEvent += CancelAction;

            this.view.SetProjectListBindingSource(bFlowBindingSource);

            LoadAllBFlowList();

            this.view.Show();
        }

        private void LoadAllBFlowList()
        {
            bFlowList = repository.GetAll();
            bFlowBindingSource.DataSource = bFlowList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveBFlow(object? sender, EventArgs e)
        {
            var model = new BaseFlowModel();
            if (view.IsEdit)
            {
                model.Id = Convert.ToInt32(this.view.Id);
            }
            model.Name = this.view.Name;
            model.Key = this.view.Key;
            model.FlowChartPath = this.view.FlowChartPath;

            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Flujo basse editado correctamente";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Flujo base agregado correctamente";
                }

                view.IsSuccessful = true;
                LoadAllBFlowList();
                CleanViewFields();

            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.Id = "0";
            view.Name = "";
            view.Key = "";
            view.FlowChartPath = "";
        }

        private void DeleteSelectedBFlow(object? sender, EventArgs e)
        {
            try
            {
                var role = (BaseFlowModel)bFlowBindingSource.Current;
                repository.Delete(role.Id);
                view.IsSuccessful = true;
                view.Message = "Flujo base eliminado correctamente";
                LoadAllBFlowList();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = "Ha ocurrido un error, se pudo eliminar el flujo base";
            }
        }

        private void LoadSelectedBFlowToEdit(object? sender, EventArgs e)
        {
            var bFlow = (BaseFlowModel)bFlowBindingSource.Current;
            view.Id = bFlow.Id.ToString();
            view.Name = bFlow.Name;
            view.Key = bFlow.Key;
            view.FlowChartPath = bFlow.FlowChartPath;
            view.IsEdit = true;
        }

        private void AddNewBFlow(object? sender, EventArgs e)
        {
            view.Name = "";
            view.IsEdit = false;
        }
    }
}

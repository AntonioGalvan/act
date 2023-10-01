using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Forms.Side_bar;
using act.Models.Projects;
using act.Views;

namespace act.Presenters
{
    internal class ProjectPresenter
    {
        private IProjectview view;
        private IProjectRepository repository;
        private BindingSource projectsBindingSource;
        private IEnumerable<ProjectModel> projectList;
        private readonly string sqlConnectionString;

        public ProjectPresenter(IProjectview pView, IProjectRepository pRepository, string sqlConnectionString)
        {
            this.projectsBindingSource = new BindingSource();
            view = pView;
            repository = pRepository;

            this.view.SearchEvent += SearchProject;
            this.view.AddNewEvent += AddNewProject;
            this.view.EditEvent += LoadSelectedProjectToEdit;
            this.view.DeleteEvent += DeleteSelectedProject;
            this.view.SaveEvent += SaveProject;
            this.view.CancelEvent += CancelAction;
            this.view.OpenEvent += OpenProject;

            this.view.SetProjectListBindingSource(projectsBindingSource);

            LoadAllProjectList();

            this.view.Show();
            this.sqlConnectionString = sqlConnectionString;
        }

        private void OpenProject(object? sender, EventArgs e)
        {
            var project = (ProjectModel)projectsBindingSource.Current;
            var projectId = project.Id;
            IMainView view = new SideBar();
            new MainPresenter(view, sqlConnectionString, projectId);

        }

        private void LoadAllProjectList()
        {
            projectList = repository.GetAll();
            projectsBindingSource.DataSource = projectList;
        }

        private void SearchProject(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                projectList = repository.GetByValue(this.view.SearchValue);
            else projectList = repository.GetAll();
            projectsBindingSource.DataSource = projectList;
        }


        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProject(object? sender, EventArgs e)
        {
            var model = new ProjectModel();
            if(view.IsEdit)
            {
                model.Id = Convert.ToInt32(this.view.Id);
            }
            model.Name = this.view.Name;
            model.Description = this.view.Description;  
            model.StartDate = this.view.StartDate;
            model.EndDate = this.view.EndDate;

            try
            {
                new Common.ModelDataValidation().Validate(model);

                if(view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Proyecto editado correctamente";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Proyecto agregado correctamente";
                }

                view.IsSuccessful = true;
                LoadAllProjectList();
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
            view.Description = "";
            view.StartDate = DateTime.Today;
            view.EndDate = DateTime.Today;
        }

        private void DeleteSelectedProject(object? sender, EventArgs e)
        {
            try
            {
                var project = (ProjectModel)projectsBindingSource.Current;
                repository.Delete(project.Id);
                view.IsSuccessful = true;
                view.Message = "Projecto eliminado correctamente";
                LoadAllProjectList();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = "Ha ocurrido un error, se pudo eliminar el proyecto";
            }
        }

        private void LoadSelectedProjectToEdit(object? sender, EventArgs e)
        {
            var project = (ProjectModel)projectsBindingSource.Current;
            view.Id = project.Id.ToString();
            view.Name = project.Name;
            view.Description = project.Description;
            view.StartDate = project.StartDate;
            view.EndDate = project.EndDate;
            view.IsEdit = true;
        }

        private void AddNewProject(object? sender, EventArgs e)
        {
            view.Name = "";
            view.IsEdit = false;
        }

        
    }
}

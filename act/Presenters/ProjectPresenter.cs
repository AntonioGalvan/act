using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Models;
using act.Views;

namespace act.Presenters
{
    internal class ProjectPresenter
    {
        private IProjectview view;
        private IProjectRepository repository;
        private BindingSource projectsBindingSource;
        private IEnumerable<ProjectModel> projectList;

        public ProjectPresenter(IProjectview pView, IProjectRepository pRepository)
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

            this.view.SetProjectListBindingSource(projectsBindingSource);

            LoadAllProjectList();

            this.view.Show();
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
            throw new NotImplementedException();
        }

        private void SaveProject(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedProject(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedProjectToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewProject(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}

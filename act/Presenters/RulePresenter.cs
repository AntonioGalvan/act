using act.Models.Rules;
using act.Views;

namespace act.Presenters
{
    internal class RulePresenter
    {
        private IRuleView view;
        private IRuleRepository repository;
        private BindingSource rulesBindingSource;
        private IEnumerable<BusinessRuleModel> ruleList;

        public RulePresenter(IRuleView pView, IRuleRepository pRepository)
        {
            this.rulesBindingSource = new BindingSource();
            view = pView;
            repository = pRepository;

            this.view.SearchEvent += SearchRule;
            this.view.AddNewEvent += AddNewRule;
            this.view.EditEvent += LoadSelectedRuleToEdit;
            this.view.DeleteEvent += DeleteSelectedRule;
            this.view.SaveEvent += SaveRule;
            this.view.CancelEvent += CancelAction;

            this.view.SetProjectListBindingSource(rulesBindingSource);

            LoadAllRuleList();

            this.view.Show();
        }

        private void LoadAllRuleList()
        {
            ruleList = repository.GetAll();
            rulesBindingSource.DataSource = ruleList;
        }

        private void SearchRule(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                ruleList = repository.GetByValue(this.view.SearchValue);
            else ruleList = repository.GetAll();
            rulesBindingSource.DataSource = ruleList;
        }


        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveRule(object? sender, EventArgs e)
        {
            var model = new BusinessRuleModel();
            if (view.IsEdit)
            {
                model.Id = Convert.ToInt32(this.view.Id);
            }
            model.Key = this.view.Key;
            model.Description = this.view.Description;

            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Regla editada correctamente";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Regla agregada correctamente";
                }

                view.IsSuccessful = true;
                LoadAllRuleList();
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
            view.Key = "";
            view.Description = "";
        }

        private void DeleteSelectedRule(object? sender, EventArgs e)
        {
            try
            {
                var rule = (BusinessRuleModel)rulesBindingSource.Current;
                repository.Delete(rule.Id);
                view.IsSuccessful = true;
                view.Message = "Regla eliminada correctamente";
                LoadAllRuleList();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = "Ha ocurrido un error, se pudo eliminar la regla";
            }
        }

        private void LoadSelectedRuleToEdit(object? sender, EventArgs e)
        {
            var rule = (BusinessRuleModel)rulesBindingSource.Current;
            view.Id = rule.Id.ToString();
            view.Key = rule.Key;
            view.Description = rule.Description;
            view.IsEdit = true;
        }

        private void AddNewRule(object? sender, EventArgs e)
        {
            view.Description = "";
            view.IsEdit = false;
        }
    }
}

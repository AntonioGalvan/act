namespace act.Models.Rules
{
    internal interface IRuleRepository
    {
        void Add(BusinessRuleModel projectModel);
        void Edit(BusinessRuleModel projectModel);
        void Delete(int id);

        //Listados
        IEnumerable<BusinessRuleModel> GetAll();

        //Busquedas
        IEnumerable<BusinessRuleModel> GetByValue(string value);
    }
}

using act.Models.Rules;

namespace act.Models.UseCases
{
    internal interface IUseCaseRepository
    {
        void Add(UseCaseModel projectModel);
        void Edit(UseCaseModel projectModel);
        void Delete(int id);

        //Listados
        IEnumerable<UseCaseModel> GetAll();

        //Busquedas
        IEnumerable<UseCaseModel> GetByValue(string value);
    }
}

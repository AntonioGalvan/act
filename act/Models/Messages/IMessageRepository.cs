using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act.Models.Messages
{
    internal interface IMessageRepository
    {
        void Add(MessageModel projectModel);
        void Edit(MessageModel projectModel);
        void Delete(int id);

        //Listados
        IEnumerable<MessageModel> GetAll();

        //Busquedas
        IEnumerable<MessageModel> GetByValue(string value);
    }
}

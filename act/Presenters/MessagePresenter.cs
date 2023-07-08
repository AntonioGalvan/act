using act.Models.Messages;
using act.Presenters.Common;
using act.Views;

namespace act.Presenters
{
    internal class MessagePresenter
    {
        private IMessageView view;
        private IMessageRepository repository;
        private BindingSource messagesBindingSource;
        private IEnumerable<MessageModel> messageList;

        public MessagePresenter(IMessageView pView, IMessageRepository pRepository)
        {
            messagesBindingSource = new BindingSource();
            view = pView;
            repository = pRepository;

            view.SearchEvent += SearchMessage;
            view.AddNewEvent += AddNewMessage;
            view.EditEvent += LoadSelectedMessageToEdit;
            view.DeleteEvent += DeleteSelectedMessage;
            view.SaveEvent += SaveMessage;
            view.CancelEvent += CancelAction;

            view.SetProjectListBindingSource(messagesBindingSource);

            LoadAllMessageList();

            view.Show();
        }

        private void LoadAllMessageList()
        {
            messageList = repository.GetAll();
            messagesBindingSource.DataSource = messageList;
        }

        private void SearchMessage(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(view.SearchValue);
            if (emptyValue == false)
                messageList = repository.GetByValue(view.SearchValue);
            else messageList = repository.GetAll();
            messagesBindingSource.DataSource = messageList;
        }


        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveMessage(object? sender, EventArgs e)
        {
            var model = new MessageModel();
            if (view.IsEdit)
            {
                model.Id = Convert.ToInt32(view.Id);
            }
            model.Key = view.Key;
            model.Description = view.Description;

            try
            {
                new ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Mensaje editado correctamente";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Mensaje agregado correctamente";
                }

                view.IsSuccessful = true;
                LoadAllMessageList();
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

        private void DeleteSelectedMessage(object? sender, EventArgs e)
        {
            try
            {
                var message = (MessageModel)messagesBindingSource.Current;
                repository.Delete(message.Id);
                view.IsSuccessful = true;
                view.Message = "Mensaje eliminado correctamente";
                LoadAllMessageList();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = "Ha ocurrido un error, se pudo eliminar el mensaje";
            }
        }

        private void LoadSelectedMessageToEdit(object? sender, EventArgs e)
        {
            var message = (MessageModel)messagesBindingSource.Current;
            view.Id = message.Id.ToString();
            view.Key = message.Key;
            view.Description = message.Description;
            view.IsEdit = true;
        }

        private void AddNewMessage(object? sender, EventArgs e)
        {
            view.Description = "";
            view.IsEdit = false;
        }
    }
}

using web.DatabaseModel;
using web.ViewModel;

namespace web.Service;

public interface ITransactionService
{
    List<Transaction> GetAllTransactions();
    Transaction GetTransactionById(int id);
}
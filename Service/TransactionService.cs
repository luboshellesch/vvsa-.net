using web.ViewModel;
using web.DatabaseModel;
using web.Repository;

namespace web.Service;
public class TransactionService: ITransactionService
{
    private readonly ITransactionRepository transactionRepository;
    public TransactionService(ITransactionRepository transactionRepository)
    {
        this.transactionRepository = transactionRepository;
    }
    public List<Transaction> GetAllTransactions()
    {
        var transactions = transactionRepository.GetAllTransactions();
        // var transactionsViewModel = new List<TransactionViewModel>();
        // foreach (var transaction in transactions) 
        // {
        //     var transcationViewModel = new TransactionViewModel {
        //         AccountNumber = transaction.AccountNumber,
        //         Amount = transaction.Amount,
        //         BankCode = transaction.BankCode,
        //         FullName = transaction.User.Name,
        //         IssueDate = transaction.IssueDate,
        //         TransactionType = transaction.TransactionType.Name
        //     };
        //     transactionsViewModel.Add(transcationViewModel);
        // }
        return transactions; 
    }
    public Transaction GetTransactionById(int id)
    {
        var transaction = transactionRepository.GetTransactionById(id);
        // var transcationViewModel = new TransactionViewModel {
        //         AccountNumber = transaction.AccountNumber,
        //         Amount = transaction.Amount,
        //         BankCode = transaction.BankCode,
        //         FullName = transaction.User.Name,
        //         IssueDate = transaction.IssueDate,
        //         TransactionType = transaction.TransactionType.Name
        //     };
        return transaction;
    }

}
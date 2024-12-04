using web.DatabaseModel;

namespace web.Repository;

public class TransactionRepository : ITransactionRepository
{   
    private readonly Whiyes5oContext context; 
    public TransactionRepository(Whiyes5oContext context){
        // transactions = new List<Transaction>{
        //     new Transaction {
        //         TransactionId = 1, 
        //     }, 
        //     new Transaction {
        //         TransactionId = 2, 
        //     }
        // };
        this.context = context;
    }
    public List<Transaction> GetAllTransactions()
    {
        return context.Transactions.ToList();
    }
    public Transaction GetTransactionById(int id)
    {
        // return transactions.FirstOrDefault(p => p.TransactionId == id);
        return context.Transactions.FirstOrDefault(p => p.Id == id);;
    }
}
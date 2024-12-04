using Microsoft.AspNetCore.Mvc;
using web.Repository;
using web.Service;
using web.DatabaseModel;
using web.ViewModel;


namespace web.Controllers;

[ApiController]
[Route("api/transaction")]
public class TransactionController : ControllerBase
{
    private readonly ILogger<TransactionController> _logger;
    private readonly ITransactionService _transactionService;

    public TransactionController(ILogger<TransactionController> logger, ITransactionService transactionService)
    {
        _logger = logger;
        _transactionService = transactionService;
    }

    [HttpGet(Name = "GetTransaction")]
    public string Get()
    {
        return "First message!";
    }
    [HttpGet("all")]
    public List<Transaction> GetAllTransactions()
    {
        var transactions = _transactionService.GetAllTransactions();
        return transactions;
    }
    [HttpGet("{id}")]
    public Transaction GetTransactionById(int id)
    {
        var transaction = _transactionService.GetTransactionById(id);
        return transaction;
    }
    
}

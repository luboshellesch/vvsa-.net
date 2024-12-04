namespace web.Model;
public partial class TransactionType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
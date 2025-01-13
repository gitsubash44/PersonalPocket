using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPocket.Components
{
   public class TransactionServices
{
    private List<TransactionModel> transactions;

    public TransactionServices()
    {
        transactions = new List<TransactionModel>();
    }

    // Ensure this method exists in the class
    public List<TransactionModel> GetTransactions()
    {
        return transactions;
    }

    // Method to add transactions (if needed)
    public void AddTransaction(TransactionModel transaction)
    {
        transactions.Add(transaction);
    }
}

}

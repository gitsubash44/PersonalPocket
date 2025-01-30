using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPocket.Components
{
    public class TransactionService
    {
        private readonly HttpClient _httpClient;

        public TransactionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TransactionModel>> GetTransactionsAsync()
        {
            // Assuming you are calling an API endpoint to fetch transactions
            var response = await _httpClient.GetFromJsonAsync<List<TransactionModel>>("transactions");

            // Return the list of transactions
            return response ?? new List<TransactionModel>();
        }
    }

}

public class Debt
{
    public int Id { get; set; }
    public string SourceOfDebt { get; set; }
    public decimal Amount { get; set; }
    public bool IsCleared { get; set; }
    public DateTime Date { get; set; }
}

public class DebtService
{
    private List<Debt> _debts;

    public DebtService()
    {
        _debts = new List<Debt>();
    }

    public List<Debt> GetDebts()
    {
        return _debts;
    }

    public void AddDebt(Debt debt)
    {
        _debts.Add(debt);
    }

    public void ClearDebt(int debtId)
    {
        var debt = _debts.FirstOrDefault(d => d.Id == debtId);
        if (debt != null)
        {
            debt.IsCleared = true;
        }
    }
}

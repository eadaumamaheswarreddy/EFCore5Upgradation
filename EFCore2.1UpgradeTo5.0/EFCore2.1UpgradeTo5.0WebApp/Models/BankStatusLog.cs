namespace EFCore2._1UpgradeTo5._0WebApp.Models
{
    public class BankStatusLog
    {
		public int Id { get; private set; }
        public int BankTransactionId { get; set; }
        public ProcessBank BankTransaction { get; set; }
    }
}

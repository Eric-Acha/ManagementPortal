namespace ManagementPortal.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string Title { get; set; }
        public decimal PayRate { get; set; }
        public decimal Hours { get; set; }

        public decimal CalculatePay()
        {
            return PayRate * Hours;
        }
    }
}

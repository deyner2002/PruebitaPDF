namespace PruebitaPDF.Models
{
    public class DashBoardMetricsDto 
    {
        public NumberServiceSolicitudeByState NumberServiceSolicitudeByState { get; set; }
        public NumberServiceOrderByState NumberServiceOrderByState { get; set; }
        public List<NumberOfTimesTheyRequestService> NumbersOfTimesTheyRequestService { get; set; }
        public List<TotalPaidByCustomer> TotalPaidByCustomers { get; set; }
    }

    public class NumberServiceSolicitudeByState 
    {
        public int AmountPending { get; set; }
        public int AmountInProgress { get; set; }
        public int AmountCanceled { get; set; }
        public int AmountClosed { get; set; }
        public int TotalAmount { get; set; }
    }

    public class NumberServiceOrderByState 
    {
        public int AmountPending { get; set; }
        public int AmountPendingAssignment { get; set; }
        public int AmountAssigned { get; set; }
        public int AmountCancelled { get; set; }
        public int AmountInProgress { get; set; }
        public int AmountFinishedApproved { get; set; }
        public int AmountFinishedRejected { get; set; }
        public int TotalAmount { get; set; }
    }

    public class NumberOfTimesTheyRequestService 
    {
        public string ServiceName { get; set; }
        public int Amount { get; set; }
    }

    public class TotalPaidByCustomer 
    {
        public string CustomerName { get; set; }
        public double TotalGenerated { get; set; }
    }
}

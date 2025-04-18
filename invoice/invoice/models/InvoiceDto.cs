using Microsoft.EntityFrameworkCore;

namespace invoice.models
{
    public class InvoiceDto
    {

        public string Number { get; set; } = "";
        public string Status { get; set; } = ""; // paid or pending
        public DateOnly? IssueDate { get; set; }
        public DateOnly? DueDate { get; set; }
        //services details
        public string Service { get; set; } = "";
        [Precision(16, 2)]
        public decimal unitPrice { get; set; }
        public int Quantity { get; set; }

        //Client details
        public string ClientName { get; set; } = "";
        public string Email { get; set; } = "";

        public string Phone { get; set; } = "";

        public string Address { get; set; } = "";

    }
}

using invoice.models;
using invoice.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace invoice.Pages.invoices
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public InvoiceDto InvoiceDto { get; set; } = new();
        
        public CreateModel(ApplicationDbContext Context)
        {
            this.context = context;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        { 
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var invoice = new Invoice
            {
                Number = InvoiceDto.Number,
                Status = InvoiceDto.Status,
                IssueDate = InvoiceDto.IssueDate,
                DueDate = InvoiceDto.DueDate,
                Service = InvoiceDto.Service,
                unitPrice = InvoiceDto.unitPrice,
                Quantity = InvoiceDto.Quantity,
                ClientName = InvoiceDto.ClientName,
                Email = InvoiceDto.Email,
                Phone = InvoiceDto.Phone,
                Address = InvoiceDto.Address,

            };

            context.Invoices.Add(invoice);
            context.SaveChanges();

            return RedirectToPage("/Invoicex/Index");

        }
    }
}

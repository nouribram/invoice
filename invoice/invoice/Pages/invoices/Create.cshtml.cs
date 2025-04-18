using invoice.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace invoice.Pages.invoices
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public InvoiceDto InvoiceDto { get; set; } = new();
        public void OnGet()
        {
        }
    }
}

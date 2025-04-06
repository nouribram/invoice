using invoice.models;
using invoice.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace invoice.Pages.invoices
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public List<Invoice> invoiceLList = new();

        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            invoiceLList = context.Invoices.ToList();
        }
    }
}

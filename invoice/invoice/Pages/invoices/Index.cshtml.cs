using invoice.models;
using invoice.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace invoice.Pages.Invoices
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public List<Invoice> invoiceList = [];

        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            invoiceList = context.Invoices.OrderByDescending(i => i.Id).ToList();
        }
    }
}

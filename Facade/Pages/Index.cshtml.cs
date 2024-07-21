using Application.Facade;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Facade.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IFacadeServicecs _facadeServicecs;
        public IndexModel(IFacadeServicecs IFacadeServicecs)
        {
            _facadeServicecs = IFacadeServicecs;
        }

   

        public void OnGet()
        {
            _facadeServicecs.RegisterService.Execute();
            _facadeServicecs.LoginService.Execute();
        }
    }
}

using Microsoft.AspNetCore.Antiforgery;
using HorasComplementaresApp.Controllers;

namespace HorasComplementaresApp.Web.Host.Controllers
{
    public class AntiForgeryController : HorasComplementaresAppControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QrCode_Generator.Pages
{
    public class QrCodeModel : PageModel
    {
        public IActionResult OnGet([FromQuery]string url)
        {
            var image = Generator.GenerateByteArray(url);
            return File(image, "image/jpeg");
        }
    }
}

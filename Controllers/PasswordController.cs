using Microsoft.AspNetCore.Mvc;

namespace PasswordValidationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PasswordController : ControllerBase
    {
        [HttpGet("validate")]
        public ActionResult<bool> ValidatePassword(string password)
        {
            bool isValid = PasswordValidator.IsValidPassword(password);
            return isValid;
        }
    }
}

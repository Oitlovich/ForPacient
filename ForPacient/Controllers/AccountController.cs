using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ForPacient.ViewModels;
namespace ForPacient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly MainContext _context;

        public AccountController(MainContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllAsync()
        {
            var user = await _context.Users.Include(p => p.Role).ToListAsync();
            var viewModel = user.Select(u => new
            {
                u.Id,
                u.Firstname,
                u.Lastname,
                u.Age,
                u.Email,
                u.Phone,
                u.Password,
                u.Role.Role_name
            });

            return Ok(viewModel);
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetUsers([FromQuery] int id)
        {
            var user = await _context.Users.Include(p => p.Role).ToListAsync();
            var viewModel = user.Select(u => new
            {
                u.Id,
                u.Firstname,
                u.Lastname,
                u.Age,
                u.Email,
                u.Phone,
                u.Password,
                u.Role.Role_name
            });

            return Ok(viewModel);
        }


        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> RegisterAsync([FromQuery] RegistrationViewModel viewModel)
        {
            User user = new User()
            {
                Age = viewModel.Age,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Password = viewModel.Password,
                Firstname = viewModel.Firstname,
                Lastname = viewModel.Lastname,
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok();
        }
        /*[HttpGet]
        [Route("medcard")]
        public async Task<IActionResult> MedCardAsync([FromQuery] int id)
        {
            var user = await _context.MedCard.Include(p => p.User).ToListAsync();
            var viewModel = user.Select(u => new
            {
                u.Id,
                u.UserId,
                u.Disease
            });

            return Ok(viewModel);
        }*/
    }
}

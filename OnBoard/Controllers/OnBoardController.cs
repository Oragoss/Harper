using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace OnBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnBoardController : ControllerBase
    {
        public OnBoardController()
        {
            //TODO: Dependency Injection
        }

        public async Task StoreNewUser(User newUser)
        {

        }

        public async Task UpdateUser(int userId, User user)
        {

        }

        public async Task DeleteUser (int userId)
        {

        }
    }
}
using AccountManagementService.V1.Interface;
using Microsoft.AspNetCore.Mvc;
using RecruitmentManagementSystemModels.V1;

namespace AccountManagementService.V1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult GetAllAccounts()
        {
            var accounts = _accountService.GetAllAccounts();
           return Ok(accounts);
        }

        [HttpGet("{id}")]
        public IActionResult GetAccountById(string id)
        {
            var account = _accountService.GetAccountById(id);
            return Ok(account);
        }

        [HttpPost]
        public IActionResult CreateAccounts(Account account)
        {
            _accountService.CreateAccounts(account);
            return Ok(new { message = "New Account Created" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAccount(string str, Account account)
        {
            _accountService.UpdateAccounts(str, account);
            return Ok(new { message = "Account Updated" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAccount(string id)
        {
            _accountService.DeleteAccount(id);
            return Ok(new { message = "Account Deleted" });
        }
    }
}

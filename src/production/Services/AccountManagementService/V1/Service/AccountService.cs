using AccountManagementService.V1.Interface;
using OpenPositionService;
using OpenPositionService.V1.Helpers;
using RecruitmentManagementSystemModels.V1;

namespace AccountManagementService.V1.Service
{
    public class AccountService : IAccountService
    {
        private readonly RecruitmentMgmtSystemDbContext _context;

        public AccountService(RecruitmentMgmtSystemDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _context.Accounts;
        }

        public Account GetAccountById(Guid id)
        {
            return GetAccount(id);
        }

        public void CreateAccounts(Account account)
        {
            //Validate
            if (_context.Accounts.Any(x => x.AccountId == account.AccountId))
            {
                throw new AppException("Account With AccountId '" + account.AccountId + "' already exists");
            }
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void UpdateAccounts(Guid id, Account account)
        {
            var acc = GetAccount(id);

            if (account.AccountId != acc.AccountId && _context.Accounts.Any(x => x.AccountId == account.AccountId))
                throw new AppException("Account With AccountId '" + account.AccountId + "' already exists");

            acc.AccountId = account.AccountId;
            acc.AccountManager = account.AccountManager;
            acc.AccountName = account.AccountName;
            acc.AccountDetail = account.AccountDetail;
            _context.Accounts.Update(acc);
            _context.SaveChanges();
        }


        public void DeleteAccount(Guid id)
        {
            var acc = GetAccount(id);
            _context.Accounts.Remove(acc);
            _context.SaveChanges();
        }

        private Account GetAccount(Guid id)
        {
            var account = _context.Accounts.Find(id);
            if (account == null) throw new KeyNotFoundException("Account Not Found");
            return account;
        }

    }
}

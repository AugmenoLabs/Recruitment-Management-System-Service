using RecruitmentManagementSystemModels.V1;

namespace AccountManagementService.V1.Interface
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAllAccounts();
        Account GetAccountById(string id);
        void CreateAccounts(Account account);
        void UpdateAccounts(string id, Account account);
        void DeleteAccount(string id);
    }
}

using Lab02.Model;

namespace Lab02
{
    public class AccountLogic
    {
        public bool Login(string account, string password)
        {
            var accountDa = new AccountDa();

            var member = accountDa.GetMemberForLogin(account);
            var encryptedPassword = new Cryptography().CashSha(password);
            var isValid = member.Password == encryptedPassword;

            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
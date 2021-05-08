
using System;

namespace ET
{
    [MessageHandler]
    public class C2R_RegisterHandler : AMRpcHandler<C2R_Register, R2C_Register>
    {
        protected override async ETTask Run(Session session, C2R_Register request, R2C_Register response, Action reply)
        {
            string account = request.Account;
            string password = request.Password;

            if(string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
            {
                response.Error = ErrorCode.ERR_AccountOrPasswordError;
                reply();
                return;
            }

            var accountList = await session.DomainScene().GetComponent<DBComponent>().Query<AccountInfo>(d=>d.Account == account);
            if (accountList.Count > 0)
            {
                response.Error = ErrorCode.ERR_AccountOrPasswordError;
                reply();
                return;
            }
            try
            {
                AccountInfo accountInfo = EntityFactory.CreateWithId<AccountInfo>(session,IdGenerater.Instance.GenerateId());
                accountInfo.Account = account;
                accountInfo.Password = password;

                await session.DomainScene().GetComponent<DBComponent>().Save(accountInfo);
            }
            catch (Exception e)
            {
                Log.Error(e);
                response.Error = ErrorCode.ERR_AccountOrPasswordError;
                response.Message = e.ToString();
                reply();
                return;
            }
            response.Error = ErrorCode.ERR_Success;
            reply();
            await ETTask.CompletedTask;
        }
    }
}

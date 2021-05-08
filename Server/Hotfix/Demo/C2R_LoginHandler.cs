using System;
using System.Net;


namespace ET
{
	[MessageHandler]
	public class C2R_LoginHandler : AMRpcHandler<C2R_Login, R2C_Login>
	{
		protected override async ETTask Run(Session session, C2R_Login request, R2C_Login response, Action reply)
		{
            string account = request.Account;
            string password = request.Password;

            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
            {
                response.Error = ErrorCode.ERR_AccountOrPasswordError;
                reply();
                return;
            }

            var accountList = await session.DomainScene().GetComponent<DBComponent>().Query<AccountInfo>(d => d.Account == account && d.Password == password);
            if (accountList.Count <= 0)
            {
                response.Error = ErrorCode.ERR_AccountOrPasswordError;
                reply();
                return;
            }

            // 随机分配一个Gate
            StartSceneConfig config = RealmGateAddressHelper.GetGate(session.DomainZone());
			//Log.Debug($"gate address: {MongoHelper.ToJson(config)}");
			
			// 向gate请求一个key,客户端可以拿着这个key连接gate
			G2R_GetLoginKey g2RGetLoginKey = (G2R_GetLoginKey) await ActorMessageSenderComponent.Instance.Call(
				config.SceneId, new R2G_GetLoginKey() {Account = request.Account});

			response.Address = config.OuterIPPort.ToString();
			response.Key = g2RGetLoginKey.Key;
			response.GateId = g2RGetLoginKey.GateId;
			reply();
		}
	}
}
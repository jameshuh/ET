using ProtoBuf;
using System.Collections.Generic;

namespace DCET
{
// 客户端由于Lua模式需要自行配置父接口的字段（如RpcId、ActorId等），服务器则不需要。
	[Message(OuterOpcode.SettingProto)]
	[ProtoContract]
	public partial class SettingProto
	{
		[ProtoMember(1, IsRequired = true)]
		public List<string> Values { get; set; } = new List<string>();

		[ProtoMember(2, IsRequired = true)]
		public int SettingsMark { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Hello { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public long Test { get; set; }

	}

	[Message(OuterOpcode.C2M_TestRequest)]
	[ProtoContract]
	public partial class C2M_TestRequest: IActorLocationRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public long ActorId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string request { get; set; }

	}

	[Message(OuterOpcode.M2C_TestResponse)]
	[ProtoContract]
	public partial class M2C_TestResponse: IActorLocationResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public string Message { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public string response { get; set; }

	}

	[Message(OuterOpcode.Actor_TransferRequest)]
	[ProtoContract]
	public partial class Actor_TransferRequest: IActorLocationRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public long ActorId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int MapIndex { get; set; }

	}

	[Message(OuterOpcode.Actor_TransferResponse)]
	[ProtoContract]
	public partial class Actor_TransferResponse: IActorLocationResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public string Message { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.C2G_EnterMap)]
	[ProtoContract]
	public partial class C2G_EnterMap: IRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.G2C_EnterMap)]
	[ProtoContract]
	public partial class G2C_EnterMap: IResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public string Message { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

// 自己的unit id
		[ProtoMember(4, IsRequired = true)]
		public long UnitId { get; set; }

// 所有的unit
		[ProtoMember(5, IsRequired = true)]
		public List<UnitInfo> Units { get; set; } = new List<UnitInfo>();

	}

	[Message(OuterOpcode.UnitInfo)]
	[ProtoContract]
	public partial class UnitInfo
	{
		[ProtoMember(1, IsRequired = true)]
		public long UnitId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public float X { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public float Y { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public float Z { get; set; }

	}

	[Message(OuterOpcode.M2C_CreateUnits)]
	[ProtoContract]
	public partial class M2C_CreateUnits: IActorMessage
	{
		[ProtoMember(1, IsRequired = true)]
		public long ActorId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public List<UnitInfo> Units { get; set; } = new List<UnitInfo>();

	}

	[Message(OuterOpcode.Frame_ClickMap)]
	[ProtoContract]
	public partial class Frame_ClickMap: IActorLocationMessage
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public long ActorId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public float X { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public float Y { get; set; }

		[ProtoMember(5, IsRequired = true)]
		public float Z { get; set; }

	}

	[Message(OuterOpcode.M2C_PathfindingResult)]
	[ProtoContract]
	public partial class M2C_PathfindingResult: IActorMessage
	{
		[ProtoMember(1, IsRequired = true)]
		public long ActorId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public long Id { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public float X { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public float Y { get; set; }

		[ProtoMember(5, IsRequired = true)]
		public float Z { get; set; }

		[ProtoMember(6, IsRequired = true)]
		public List<float> Xs { get; set; } = new List<float>();

		[ProtoMember(7, IsRequired = true)]
		public List<float> Ys { get; set; } = new List<float>();

		[ProtoMember(8, IsRequired = true)]
		public List<float> Zs { get; set; } = new List<float>();

	}

	[Message(OuterOpcode.C2R_Ping)]
	[ProtoContract]
	public partial class C2R_Ping: IRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.R2C_Ping)]
	[ProtoContract]
	public partial class R2C_Ping: IResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public string Message { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.G2C_Test)]
	[ProtoContract]
	public partial class G2C_Test: IMessage
	{
	}

	[Message(OuterOpcode.C2M_Reload)]
	[ProtoContract]
	public partial class C2M_Reload: IRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public string Account { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Password { get; set; }

	}

	[Message(OuterOpcode.M2C_Reload)]
	[ProtoContract]
	public partial class M2C_Reload: IResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public string Message { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.C2R_Login)]
	[ProtoContract]
	public partial class C2R_Login: IRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public string Account { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Password { get; set; }

	}

	[Message(OuterOpcode.R2C_Login)]
	[ProtoContract]
	public partial class R2C_Login: IResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public string Message { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public string Address { get; set; }

		[ProtoMember(5, IsRequired = true)]
		public long Key { get; set; }

		[ProtoMember(6, IsRequired = true)]
		public long GateId { get; set; }

	}

	[Message(OuterOpcode.C2G_LoginGate)]
	[ProtoContract]
	public partial class C2G_LoginGate: IRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public long Key { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public long GateId { get; set; }

	}

	[Message(OuterOpcode.G2C_LoginGate)]
	[ProtoContract]
	public partial class G2C_LoginGate: IResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public string Message { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public long PlayerId { get; set; }

	}

	[Message(OuterOpcode.G2C_TestHotfixMessage)]
	[ProtoContract]
	public partial class G2C_TestHotfixMessage: IMessage
	{
		[ProtoMember(1, IsRequired = true)]
		public string Info { get; set; }

	}

	[Message(OuterOpcode.C2M_TestActorRequest)]
	[ProtoContract]
	public partial class C2M_TestActorRequest: IActorLocationRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public long ActorId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Info { get; set; }

	}

	[Message(OuterOpcode.M2C_TestActorResponse)]
	[ProtoContract]
	public partial class M2C_TestActorResponse: IActorLocationResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public string Message { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public string Info { get; set; }

	}

	[Message(OuterOpcode.PlayerInfo)]
	[ProtoContract]
	public partial class PlayerInfo: IMessage
	{
		[ProtoMember(1, IsRequired = true)]
		public long RpcId { get; set; }

	}

	[Message(OuterOpcode.C2G_PlayerInfo)]
	[ProtoContract]
	public partial class C2G_PlayerInfo: IRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.G2C_PlayerInfo)]
	[ProtoContract]
	public partial class G2C_PlayerInfo: IResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public string Message { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public PlayerInfo PlayerInfo { get; set; }

		[ProtoMember(5, IsRequired = true)]
		public List<PlayerInfo> PlayerInfos { get; set; } = new List<PlayerInfo>();

		[ProtoMember(6, IsRequired = true)]
		public List<string> TestRepeatedString { get; set; } = new List<string>();

		[ProtoMember(7, IsRequired = true)]
		public List<int> TestRepeatedInt32 { get; set; } = new List<int>();

		[ProtoMember(8, IsRequired = true)]
		public List<long> TestRepeatedInt64 { get; set; } = new List<long>();

	}

}

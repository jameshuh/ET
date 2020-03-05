using ProtoBuf;
using System.Collections.Generic;
namespace DCET
{
	[Message(OuterOpcode.C2M_TestRequest)]
	[ProtoContract]
	public partial class C2M_TestRequest: IActorLocationRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public string request;

		[ProtoMember(2, IsRequired = true)]
		public long ActorId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_TestResponse)]
	[ProtoContract]
	public partial class M2C_TestResponse: IActorLocationResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public string response;

		[ProtoMember(2, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Message { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.Actor_TransferRequest)]
	[ProtoContract]
	public partial class Actor_TransferRequest: IActorLocationRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public int MapIndex;

		[ProtoMember(2, IsRequired = true)]
		public long ActorId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

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
// 自己的unit id
		[ProtoMember(1, IsRequired = true)]
		public long UnitId;

// 所有的unit
		[ProtoMember(2, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.UnitInfo)]
	[ProtoContract]
	public partial class UnitInfo
	{
		[ProtoMember(1, IsRequired = true)]
		public long UnitId;

		[ProtoMember(2, IsRequired = true)]
		public float X;

		[ProtoMember(3, IsRequired = true)]
		public float Y;

		[ProtoMember(4, IsRequired = true)]
		public float Z;

	}

	[Message(OuterOpcode.M2C_CreateUnits)]
	[ProtoContract]
	public partial class M2C_CreateUnits: IActorMessage
	{
		[ProtoMember(1, IsRequired = true)]
		public List<UnitInfo> Units = new List<UnitInfo>();

		[ProtoMember(2, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.Frame_ClickMap)]
	[ProtoContract]
	public partial class Frame_ClickMap: IActorLocationMessage
	{
		[ProtoMember(1, IsRequired = true)]
		public float X;

		[ProtoMember(2, IsRequired = true)]
		public float Y;

		[ProtoMember(3, IsRequired = true)]
		public float Z;

		[ProtoMember(4, IsRequired = true)]
		public long ActorId { get; set; }

		[ProtoMember(5, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_PathfindingResult)]
	[ProtoContract]
	public partial class M2C_PathfindingResult: IActorMessage
	{
		[ProtoMember(1, IsRequired = true)]
		public long Id;

		[ProtoMember(2, IsRequired = true)]
		public float X;

		[ProtoMember(3, IsRequired = true)]
		public float Y;

		[ProtoMember(4, IsRequired = true)]
		public float Z;

		[ProtoMember(5, IsRequired = true)]
		public List<float> Xs = new List<float>();

		[ProtoMember(6, IsRequired = true)]
		public List<float> Ys = new List<float>();

		[ProtoMember(7, IsRequired = true)]
		public List<float> Zs = new List<float>();

		[ProtoMember(8, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(9, IsRequired = true)]
		public long ActorId { get; set; }

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
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Message { get; set; }

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
		public string Account;

		[ProtoMember(2, IsRequired = true)]
		public string Password;

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_Reload)]
	[ProtoContract]
	public partial class M2C_Reload: IResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.C2R_Login)]
	[ProtoContract]
	public partial class C2R_Login: IRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public string Account;

		[ProtoMember(2, IsRequired = true)]
		public string Password;

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.R2C_Login)]
	[ProtoContract]
	public partial class R2C_Login: IResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public string Address;

		[ProtoMember(2, IsRequired = true)]
		public long Key;

		[ProtoMember(3, IsRequired = true)]
		public long GateId;

		[ProtoMember(4, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(5, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(6, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.C2G_LoginGate)]
	[ProtoContract]
	public partial class C2G_LoginGate: IRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public long Key;

		[ProtoMember(2, IsRequired = true)]
		public long GateId;

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.G2C_LoginGate)]
	[ProtoContract]
	public partial class G2C_LoginGate: IResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public long PlayerId;

		[ProtoMember(2, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.G2C_TestHotfixMessage)]
	[ProtoContract]
	public partial class G2C_TestHotfixMessage: IMessage
	{
		[ProtoMember(1, IsRequired = true)]
		public string Info;

	}

	[Message(OuterOpcode.C2M_TestActorRequest)]
	[ProtoContract]
	public partial class C2M_TestActorRequest: IActorLocationRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public string Info;

		[ProtoMember(2, IsRequired = true)]
		public long ActorId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_TestActorResponse)]
	[ProtoContract]
	public partial class M2C_TestActorResponse: IActorLocationResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public string Info;

		[ProtoMember(2, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Message { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.PlayerInfo)]
	[ProtoContract]
	public partial class PlayerInfo: IMessage
	{
		[ProtoMember(1, IsRequired = true)]
		public long RpcId;

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
		public PlayerInfo PlayerInfo;

		[ProtoMember(2, IsRequired = true)]
		public List<PlayerInfo> PlayerInfos = new List<PlayerInfo>();

		[ProtoMember(3, IsRequired = true)]
		public List<string> TestRepeatedString = new List<string>();

		[ProtoMember(4, IsRequired = true)]
		public List<int> TestRepeatedInt32 = new List<int>();

		[ProtoMember(5, IsRequired = true)]
		public List<long> TestRepeatedInt64 = new List<long>();

		[ProtoMember(6, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(7, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(8, IsRequired = true)]
		public string Message { get; set; }

	}

}

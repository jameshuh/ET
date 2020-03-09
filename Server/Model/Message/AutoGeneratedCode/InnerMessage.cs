using ProtoBuf;
using System.Collections.Generic;

namespace DCET
{
/// <summary>
/// 传送unit
/// </summary>
	[Message(InnerOpcode.M2M_TrasferUnitRequest)]
	[ProtoContract]
	public partial class M2M_TrasferUnitRequest: IActorRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public Unit Unit { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public long ActorId { get; set; }

	}

	[Message(InnerOpcode.M2M_TrasferUnitResponse)]
	[ProtoContract]
	public partial class M2M_TrasferUnitResponse: IActorResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public long InstanceId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(InnerOpcode.M2A_Reload)]
	[ProtoContract]
	public partial class M2A_Reload: IActorRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public long ActorId { get; set; }

	}

	[Message(InnerOpcode.A2M_Reload)]
	[ProtoContract]
	public partial class A2M_Reload: IActorResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(InnerOpcode.G2G_LockRequest)]
	[ProtoContract]
	public partial class G2G_LockRequest: IActorRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public long Id { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public string Address { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public long ActorId { get; set; }

	}

	[Message(InnerOpcode.G2G_LockResponse)]
	[ProtoContract]
	public partial class G2G_LockResponse: IActorResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(InnerOpcode.G2G_LockReleaseRequest)]
	[ProtoContract]
	public partial class G2G_LockReleaseRequest: IActorRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public long Id { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public string Address { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public long ActorId { get; set; }

	}

	[Message(InnerOpcode.G2G_LockReleaseResponse)]
	[ProtoContract]
	public partial class G2G_LockReleaseResponse: IActorResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(InnerOpcode.R2G_GetLoginKey)]
	[ProtoContract]
	public partial class R2G_GetLoginKey: IActorRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public string Account { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public long ActorId { get; set; }

	}

	[Message(InnerOpcode.G2R_GetLoginKey)]
	[ProtoContract]
	public partial class G2R_GetLoginKey: IActorResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public long Key { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public long GateId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(5, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(InnerOpcode.G2M_CreateUnit)]
	[ProtoContract]
	public partial class G2M_CreateUnit: IActorRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public long PlayerId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public long GateSessionId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public long ActorId { get; set; }

	}

	[Message(InnerOpcode.M2G_CreateUnit)]
	[ProtoContract]
	public partial class M2G_CreateUnit: IActorResponse
	{
// 自己的unit id
		[ProtoMember(1, IsRequired = true)]
		public long UnitId { get; set; }

// 所有的unit
		[ProtoMember(2, IsRequired = true)]
		public List<UnitInfo> Units { get; set; } = new List<UnitInfo>();

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(5, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(InnerOpcode.G2M_SessionDisconnect)]
	[ProtoContract]
	public partial class G2M_SessionDisconnect: IActorLocationMessage
	{
		[ProtoMember(1, IsRequired = true)]
		public long ActorId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int RpcId { get; set; }

	}

}

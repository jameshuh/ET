using ProtoBuf;
using System.Collections.Generic;

namespace DCET
{
	[Message(FrameOpcode.ObjectAddRequest)]
	[ProtoContract]
	public partial class ObjectAddRequest: IActorRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public long Key { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public long InstanceId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public long ActorId { get; set; }

	}

	[Message(FrameOpcode.ObjectAddResponse)]
	[ProtoContract]
	public partial class ObjectAddResponse: IActorResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(FrameOpcode.ObjectLockRequest)]
	[ProtoContract]
	public partial class ObjectLockRequest: IActorRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public long Key { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public long InstanceId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public int Time { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(5, IsRequired = true)]
		public long ActorId { get; set; }

	}

	[Message(FrameOpcode.ObjectLockResponse)]
	[ProtoContract]
	public partial class ObjectLockResponse: IActorResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(FrameOpcode.ObjectUnLockRequest)]
	[ProtoContract]
	public partial class ObjectUnLockRequest: IActorRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public long Key { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public long OldInstanceId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public long InstanceId { get; set; }

		[ProtoMember(4, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(5, IsRequired = true)]
		public long ActorId { get; set; }

	}

	[Message(FrameOpcode.ObjectUnLockResponse)]
	[ProtoContract]
	public partial class ObjectUnLockResponse: IActorResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(FrameOpcode.ObjectRemoveRequest)]
	[ProtoContract]
	public partial class ObjectRemoveRequest: IActorRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public long Key { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public long ActorId { get; set; }

	}

	[Message(FrameOpcode.ObjectRemoveResponse)]
	[ProtoContract]
	public partial class ObjectRemoveResponse: IActorResponse
	{
		[ProtoMember(1, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int Error { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public string Message { get; set; }

	}

	[Message(FrameOpcode.ObjectGetRequest)]
	[ProtoContract]
	public partial class ObjectGetRequest: IActorRequest
	{
		[ProtoMember(1, IsRequired = true)]
		public long Key { get; set; }

		[ProtoMember(2, IsRequired = true)]
		public int RpcId { get; set; }

		[ProtoMember(3, IsRequired = true)]
		public long ActorId { get; set; }

	}

	[Message(FrameOpcode.ObjectGetResponse)]
	[ProtoContract]
	public partial class ObjectGetResponse: IActorResponse
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

}

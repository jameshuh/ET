using System.Collections.Generic;
namespace DCET
{
	[Message(ActorOpcode.ObjectAddRequest)]
	public partial class ObjectAddRequest: IActorRequest
	{
		public int RpcId { get; set; }

		public long ActorId { get; set; }

		public long Key { get; set; }

		public long InstanceId { get; set; }

	}

	[Message(ActorOpcode.ObjectAddResponse)]
	public partial class ObjectAddResponse: IActorResponse
	{
		public int RpcId { get; set; }

		public int Error { get; set; }

		public string Message { get; set; }

	}

	[Message(ActorOpcode.ObjectLockRequest)]
	public partial class ObjectLockRequest: IActorRequest
	{
		public int RpcId { get; set; }

		public long ActorId { get; set; }

		public long Key { get; set; }

		public long InstanceId { get; set; }

		public int Time { get; set; }

	}

	[Message(ActorOpcode.ObjectLockResponse)]
	public partial class ObjectLockResponse: IActorResponse
	{
		public int RpcId { get; set; }

		public int Error { get; set; }

		public string Message { get; set; }

	}

	[Message(ActorOpcode.ObjectUnLockRequest)]
	public partial class ObjectUnLockRequest: IActorRequest
	{
		public int RpcId { get; set; }

		public long ActorId { get; set; }

		public long Key { get; set; }

		public long OldInstanceId { get; set; }

		public long InstanceId { get; set; }

	}

	[Message(ActorOpcode.ObjectUnLockResponse)]
	public partial class ObjectUnLockResponse: IActorResponse
	{
		public int RpcId { get; set; }

		public int Error { get; set; }

		public string Message { get; set; }

	}

	[Message(ActorOpcode.ObjectRemoveRequest)]
	public partial class ObjectRemoveRequest: IActorRequest
	{
		public int RpcId { get; set; }

		public long ActorId { get; set; }

		public long Key { get; set; }

	}

	[Message(ActorOpcode.ObjectRemoveResponse)]
	public partial class ObjectRemoveResponse: IActorResponse
	{
		public int RpcId { get; set; }

		public int Error { get; set; }

		public string Message { get; set; }

	}

	[Message(ActorOpcode.ObjectGetRequest)]
	public partial class ObjectGetRequest: IActorRequest
	{
		public int RpcId { get; set; }

		public long ActorId { get; set; }

		public long Key { get; set; }

	}

	[Message(ActorOpcode.ObjectGetResponse)]
	public partial class ObjectGetResponse: IActorResponse
	{
		public int RpcId { get; set; }

		public int Error { get; set; }

		public string Message { get; set; }

		public long InstanceId { get; set; }

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AuktionsServer
{
	public class CustomSocket : Socket
	{
		public CustomSocket(SafeSocketHandle handle) : base(handle)
		{
		}

		public CustomSocket(SocketInformation socketInformation) : base(socketInformation)
		{
		}

		public CustomSocket(SocketType socketType, ProtocolType protocolType) : base(socketType, protocolType)
		{
		}

		public CustomSocket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) : base(addressFamily, socketType, protocolType)
		{
		}

		public bool StartedAsThread { get; set; } = false;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TakeProgram
{
    class Session
    {
        Socket _socket;
        public Socket socket { get { return _socket; }  set { _socket = value; } }
        public int SessionId { get; set; }
        public void Generator(int num, Socket _socket)
        {
            SessionId = num;
            this.socket = _socket;
        }

        public void Send(ArraySegment<byte> buffer)
        {

        }

        public void Recv()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CommunicationHelper
    {
        private readonly Socket socket;
        private readonly NetworkStream stream;
        private readonly BinaryFormatter formatter;
        public CommunicationHelper(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();

        }

        public void Send<T>( T graph) where T : class
        {
            formatter.Serialize(stream, graph);
        }

        public T Receive<T>() where T:class
        {
            return (T)formatter.Deserialize(stream);
        }

        public void closeSocket()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Dispose();
        }

      
    }

}

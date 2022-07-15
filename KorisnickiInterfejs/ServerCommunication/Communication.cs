using Common;
using KorisnickiInterfejs.Exeptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.ServerCommunication
{
 public   class Communication
    {

        private Socket socket;
        private CommunicationHelper helper;
        private static Communication instanca;
        private Communication()
        {

        }
        public static Communication Instance
        {
            get
            {
                if (instanca == null)
                {
                    instanca = new Communication();
                }
                return instanca;
            }
        }


        public void Connect()
        {
            if(socket==null || !socket.Connected)
            {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 20000);
            helper = new CommunicationHelper(socket);
            }
        }

        public Output SendRequestGetResult<Output>(Operations op, object i = null) where Output : class
        {
            SendRequest(op, i);
            return GetResult<Output>();
        }

        public void SendRequestNoResult(Operations op, object i)
        {
            SendRequest(op, i);
            GetResult();
        }
        private T GetResult<T>() where T : class
        {
            Response response = helper.Receive<Response>();
            if (response.isSuccessful)
            {
                return (T)response.Result;
            }
            else
            {
                throw new SystemOperationException(response.Message);
            }
        }
        private void GetResult()
        {
            Response response = helper.Receive<Response>();
            if (!response.isSuccessful)
            {
                throw new SystemOperationException(response.Message);
            }
        }

        private void SendRequest(Operations operation, object requestObject = null)
        {
            try
            {
                Request r = new Request
                {
                    Operation = operation,
                    RequestObject = requestObject
                };
                helper.Send(r);
            }
            catch (IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }
        internal void CloseConnection()
        {
            if (socket == null) return;
            Request request = new Request
            {
                Operation = Operations.Kraj,
            };
            helper.Send(request);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;
        }
    }

}

using AplicationLogic;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private CommunicationHelper helper;
        public EventHandler OdjavljenKlijent;
        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            helper = new CommunicationHelper(socket);
        }
        private bool kraj = false;
        public void HandlerRequests()
        {
            try
            {
                while (!kraj)
                {
                    Request request = helper.Receive<Request>();
                    Response response = CreateResponse(request);
                    helper.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                CloseSocket();
            }
            
        }
        private Response CreateResponse(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operations.Kraj:
                        kraj = true;
                        break;
                    case Operations.Login:
                        response.Result = Controller.Instance.Login((Apotekar)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Sitem ne moze da prijavi zaposlenog!";
                        }
                        break;

                    case Operations.VratiTipoveLeka:
                        response.Result = Controller.Instance.vratiTipoveLeka();
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Sistem ne moze da ucita tipove lekova";
                        }
                            break;
                    case Operations.DodajLek:
                        Controller.Instance.ZapamtiLek((Lek)request.RequestObject);
                        break;
                    case Operations.SacuvajPorudzbini:
                        Controller.Instance.SacuvajPorudzbinu((Porudzbina)request.RequestObject);
                        break;
                    case Operations.VratiDobavljace:

                        response.Result = Controller.Instance.vratiListuDobavljaca();
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Sistem ne moze da ucita Dobavljace";
                        }
                        break;

                    case Operations.VratiLekove:
                        response.Result = Controller.Instance.VratiListuLekova();
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Sistem ne moze da ucita lekove";
                        }
                        break;
                    case Operations.UcitajLek:
                        response.Result = Controller.Instance.UcitajLek((Lek)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Sistem ne moze da pronadje lek";
                        }
                        break;


                    case Operations.NadjiLekove:
                        response.Result = Controller.Instance.NadjiLekove((Lek)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Sistem ne moze da Nadje lekove";
                        }


                        break;
                    case Operations.IzmeniLek:

                        Controller.Instance.IzmeniLek((Lek)request.RequestObject);
                        break;
                    case Operations.VratiSvePorudzbine:
                        response.Result = Controller.Instance.vratiListuPorudzbina();
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Sistem ne moze da ucita porudzbine";
                        }

                        break;
                       
                    case Operations.ObrisiLek:
                        Controller.Instance.ObrisiLek((Lek)request.RequestObject);
                        break;
                    case Operations.VratiStavke:
                        response.Result = Controller.Instance.vratiListuStavkiPorudzbina((StavkaPorudzbine)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Sistem ne moze da ucita stavke";
                        }
                        break;
                    case Operations.IzmeniPorudzbinu:
                        Controller.Instance.IzmeniPorudzbini((Porudzbina)request.RequestObject);
                        break;
                    case Operations.UcitajPorudzbinu:
                        response.Result = Controller.Instance.UcitajPorudzbinu((Porudzbina)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Sistem ne moze da ucita porudzbinu";
                        }
                        break;

                    case Operations.NadjiPorudzbine:
                        response.Result = Controller.Instance.NadjiPorudzbine((Porudzbina)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.isSuccessful = false;
                            response.Message = "Sistem ne moze da Nadje porudzbinu";
                        }
                        break;
                    case Operations.ObrisiPorudzbinu:
                        Controller.Instance.ObrisiPorudzbinu((Porudzbina)request.RequestObject);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                response.isSuccessful = false;
                response.Message = ex.Message;
            }
            return response;
        }
        private object lockobject = new object();
        internal void CloseSocket()
        {
            lock (lockobject)
            {
                if (socket != null)
                {
                    kraj = true;
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null;
                    OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}

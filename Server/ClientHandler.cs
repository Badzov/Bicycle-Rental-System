using ApplicationLogic;
using Common;
using Common.Exceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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
        public async Task HandleRequests()
        {
            try
            {
                while (!kraj)
                {
                    Request request = await helper.Receive<Request>();
                    Response response = CreateResponse(request);
                    await helper.Send(response);

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

        public Response CreateResponse(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.PrijaviAutomat:
                        Automat automat = JsonSerializer.Deserialize<Automat>(request.JsonData);
                        Automat resultPrijaviAutomat = Controller.Instance.PrijaviAutomat(automat);
                        response.JsonData = JsonSerializer.Serialize(resultPrijaviAutomat);
                        if (resultPrijaviAutomat == null)
                        {
                            response.IsSuccessful = false;
                            response.Message = "Automat ne postoji!";
                        }
                        break;

                    case Operation.UbaciAutomat:
                        automat = JsonSerializer.Deserialize<Automat>(request.JsonData);
                        Controller.Instance.UbaciAutomat(automat);
                        break;

                    case Operation.UbaciAutomatSaLokacijom:
                        AutomatLokacija dto = JsonSerializer.Deserialize<AutomatLokacija>(request.JsonData);
                        Controller.Instance.UbaciAutomatSaLokacijom(dto.Automat, dto.Lokacija);
                        break;

                    case Operation.VratiListuSviLokacija:
                        List<Lokacija> resultVratiListuSviLokacija = Controller.Instance.VratiListuSviLokacija();
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuSviLokacija);
                        break;

                    case Operation.UbaciLokacija:
                        Lokacija lokacija = JsonSerializer.Deserialize<Lokacija>(request.JsonData);
                        Controller.Instance.UbaciLokacija(lokacija);
                        break;

                    case Operation.VratiListuSviMesto:
                        List<Mesto> resultVratiListuSviMesto = Controller.Instance.VratiListuSviMesto();
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuSviMesto);
                        break;

                    case Operation.VratiListuSviPoslovniPartner:
                        List<PoslovniPartner> resultVratiListuSviPoslovniPartner = Controller.Instance.VratiListuSviPoslovniPartner();
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuSviPoslovniPartner);
                        break;

                    case Operation.UbaciPoslovniPartner:
                        PoslovniPartner partner = JsonSerializer.Deserialize<PoslovniPartner>(request.JsonData);
                        Controller.Instance.UbaciPoslovniPartner(partner);
                        break;

                    case Operation.ObrisiPoslovniPartner:
                        partner = JsonSerializer.Deserialize<PoslovniPartner>(request.JsonData);
                        Controller.Instance.ObrisiPoslovniPartner(partner);
                        break;

                    case Operation.PromeniPoslovniPartner:
                        partner = JsonSerializer.Deserialize<PoslovniPartner>(request.JsonData);
                        Controller.Instance.PromeniPoslovniPartner(partner);
                        break;

                    case Operation.VratiListuPoslovniPartner:
                        partner = JsonSerializer.Deserialize<PoslovniPartner>(request.JsonData);
                        List<PoslovniPartner> resultVratiListuPoslovniPartner = Controller.Instance.VratiListuPoslovniPartner(partner);
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuPoslovniPartner);
                        break;

                    case Operation.PretraziPoslovniPartner:
                        partner = JsonSerializer.Deserialize<PoslovniPartner>(request.JsonData);
                        PoslovniPartner resultPretraziPoslovniPartner = Controller.Instance.PretraziPoslovniPartner(partner);
                        response.JsonData = JsonSerializer.Serialize(resultPretraziPoslovniPartner);
                        break;

                    case Operation.KreirajPoslovniPartner:
                        partner = JsonSerializer.Deserialize<PoslovniPartner>(request.JsonData);
                        Controller.Instance.KreirajPoslovniPartner(partner);
                        break;

                    case Operation.UbaciMesto:
                        Mesto mesto = JsonSerializer.Deserialize<Mesto>(request.JsonData);
                        Controller.Instance.UbaciMesto(mesto);
                        break;

                    case Operation.VratiListuSviBicikla:
                        List<Bicikla> resultVratiListuSviBicikla = Controller.Instance.VratiListuSviBicikla();
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuSviBicikla);
                        break;

                    case Operation.PretraziBicikla:
                        Bicikla bicikla = JsonSerializer.Deserialize<Bicikla>(request.JsonData);
                        Bicikla resultPretraziBicikla = Controller.Instance.PretraziBicikla(bicikla);
                        response.JsonData = JsonSerializer.Serialize(resultPretraziBicikla);
                        break;

                    case Operation.KreirajBicikla:
                        bicikla = JsonSerializer.Deserialize<Bicikla>(request.JsonData);
                        Controller.Instance.KreirajBicikla(bicikla);
                        break;

                    case Operation.ObrisiBicikla:
                        bicikla = JsonSerializer.Deserialize<Bicikla>(request.JsonData);
                        Controller.Instance.ObrisiBicikla(bicikla);
                        break;

                    case Operation.UbaciBicikla:
                        bicikla = JsonSerializer.Deserialize<Bicikla>(request.JsonData);
                        Controller.Instance.UbaciBicikla(bicikla);
                        break;

                    case Operation.PromeniBicikla:
                        bicikla = JsonSerializer.Deserialize<Bicikla>(request.JsonData);
                        Controller.Instance.PromeniBicikla(bicikla);
                        break;

                    case Operation.VratiListuBicikla:
                        bicikla = JsonSerializer.Deserialize<Bicikla>(request.JsonData);
                        List<Bicikla> resultVratiListuBicikla = Controller.Instance.VratiListuBicikla(bicikla);
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuBicikla);
                        break;

                    case Operation.VratiListuSviAutomat:
                        List<Automat> resultVratiListuSviAutomat = Controller.Instance.VratiListuSviAutomat();
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuSviAutomat);
                        break;

                    case Operation.VratiListuSviIznajmljivanje:
                        List<Iznajmljivanje> resultVratiListuSviIznajmljivanje = Controller.Instance.VratiListuSviIznajmljivanje();
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuSviIznajmljivanje);
                        break;

                    case Operation.KreirajStavkaIznajmljivanja:
                        StavkaIznajmljivanja stavka = JsonSerializer.Deserialize<StavkaIznajmljivanja>(request.JsonData);
                        Controller.Instance.KreirajStavkaIznajmljivanja(stavka);
                        break;

                    case Operation.ObrisiStavkaIznajmljivanja:
                        stavka = JsonSerializer.Deserialize<StavkaIznajmljivanja>(request.JsonData);
                        Controller.Instance.ObrisiStavkaIznajmljivanja(stavka);
                        break;

                    case Operation.PromeniStavkaIznajmljivanja:
                        stavka = JsonSerializer.Deserialize<StavkaIznajmljivanja>(request.JsonData);
                        Controller.Instance.PromeniStavkaIznajmljivanja(stavka);
                        break;

                    case Operation.UbaciStavkaIznajmljivanja:
                        stavka = JsonSerializer.Deserialize<StavkaIznajmljivanja>(request.JsonData);
                        Controller.Instance.UbaciStavkaIznajmljivanja(stavka);
                        break;

                    case Operation.ObrisiIznajmljivanje:
                        Iznajmljivanje iznajmljivanje = JsonSerializer.Deserialize<Iznajmljivanje>(request.JsonData);
                        Controller.Instance.ObrisiIznajmljivanje(iznajmljivanje);
                        break;

                    case Operation.KreirajIznajmljivanje:
                        iznajmljivanje = JsonSerializer.Deserialize<Iznajmljivanje>(request.JsonData);
                        Controller.Instance.KreirajIznajmljivanje(iznajmljivanje);
                        break;

                    case Operation.UbaciIznajmljivanje:
                        iznajmljivanje = JsonSerializer.Deserialize<Iznajmljivanje>(request.JsonData);
                        Controller.Instance.UbaciIznajmljivanje(iznajmljivanje);
                        break;

                    case Operation.PromeniIznajmljivanje:
                        iznajmljivanje = JsonSerializer.Deserialize<Iznajmljivanje>(request.JsonData);
                        Controller.Instance.PromeniIznajmljivanje(iznajmljivanje);
                        break;

                    case Operation.VratiListuIznajmljivanje:
                        iznajmljivanje = JsonSerializer.Deserialize<Iznajmljivanje>(request.JsonData);
                        List<Iznajmljivanje> resultVratiListuIznajmljivanje = Controller.Instance.VratiListuIznajmljivanje(iznajmljivanje);
                        response.JsonData = JsonSerializer.Serialize(resultVratiListuIznajmljivanje);
                        break;

                    case Operation.Kraj:
                        kraj = true;
                        break;

                    default:
                        break;
                }
            }
            catch (SystemOperationException ex)
            {
                Debug.WriteLine($">>>>>>>>>>> System Operation: {request.Operation} error: {ex.Message}");
                response.IsSuccessful = false;
                response.Message = ex.Message;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>> Unexpected System Error: " + ex.Message);
                response.IsSuccessful = false;
                response.Message = "Sistemska greška!";
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

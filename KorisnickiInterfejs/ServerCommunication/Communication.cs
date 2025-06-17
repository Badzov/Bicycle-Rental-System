using Common;
using Domain;
using Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.DTOs;

namespace KorisnickiInterfejs.ServerCommunication
{
    public class Communication
    {
        private Socket socket;
        private CommunicationHelper helper;
        private static Communication instance;

        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }

        private Communication()
        {

        }

        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            helper = new CommunicationHelper(socket);
        }

        private async Task<T> GetResult<T>()
        {
            Response response = await helper.Receive<Response>();

            if (response.IsSuccessful)
            {
                return response.GetData<T>();
            }

            else
            {
                throw new SystemOperationException(response.Message);
            }
        }

        private async Task GetResult()
        {
            Response response = await helper.Receive<Response>();

            if (!response.IsSuccessful)
            {
                throw new SystemOperationException(response.Message);
            }
        }

        private async Task SendRequest<T>(Operation operation, T requestObject = null) where T : class
        {
            try
            {
                Request request = new Request
                {
                    Operation = operation,
                    JsonData = JsonSerializer.Serialize(requestObject)
                };

                await helper.Send(request);
            }
            catch (IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }

        public async Task Close()
        {
            if (socket == null || helper == null) return;

            await SendRequest<object>(Operation.Kraj);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;
        }

        internal async Task<Automat> PrijaviAutomat(Automat a)
        {
            await SendRequest(Operation.PrijaviAutomat, a);
            return (Automat)await GetResult<Automat>();
        }

        internal async Task UbaciAutomatSaLokacijom(Automat a, Lokacija l = null)
        {
            AutomatLokacijaDTO dto = new AutomatLokacijaDTO
            {
                Automat = a,
                Lokacija = l
            };
            await SendRequest(Operation.UbaciAutomatSaLokacijom, dto);
            await GetResult();
        }

        internal async Task UbaciAutomat(Automat a)
        {
            await SendRequest(Operation.UbaciAutomat, a);
            await GetResult();
        }

        internal async Task<List<Lokacija>> VratiListuSviLokacija()
        {
            await SendRequest<object>(Operation.VratiListuSviLokacija);
            return (List<Lokacija>)await GetResult<List<Lokacija>>();
        }

        internal async Task UbaciLokacija(Lokacija l)
        {
            await SendRequest(Operation.UbaciLokacija, l);
            await GetResult();
        }

        internal async Task<List<Mesto>> VratiListuSviMesto()
        {
            await SendRequest<object>(Operation.VratiListuSviMesto);
            return(List<Mesto>)await GetResult<List<Mesto>>();
        }

        internal async Task<List<PoslovniPartner>> VratiListuSviPoslovniPartner()
        {
            await SendRequest<object>(Operation.VratiListuSviPoslovniPartner);
            return (List<PoslovniPartner>)await GetResult<List<PoslovniPartner>>();
        }

        internal async Task UbaciPoslovniPartner(PoslovniPartner p)
        {
            await SendRequest(Operation.UbaciPoslovniPartner, p);
            await GetResult();
        }

        internal async Task ObrisiPoslovniPartner(PoslovniPartner p)
        {
            await SendRequest(Operation.ObrisiPoslovniPartner, p);
            await GetResult();
        }

        internal async Task PromeniPoslovniPartner(PoslovniPartner p)
        {
            await SendRequest(Operation.PromeniPoslovniPartner, p);
            await GetResult();
        }

        internal async Task<List<PoslovniPartner>> VratiListuPoslovniPartner(PoslovniPartner p)
        {
            await SendRequest<object>(Operation.VratiListuPoslovniPartner, p);
            return (List<PoslovniPartner>)await GetResult<List<PoslovniPartner>>();
        }

        internal async Task<PoslovniPartner> PretraziPoslovniPartner(PoslovniPartner p)
        {
            await SendRequest<object>(Operation.PretraziPoslovniPartner, p);
            return (PoslovniPartner)await GetResult<PoslovniPartner>();
        }

        internal async Task KreirajPoslovniPartner(PoslovniPartner p)
        {
            await SendRequest(Operation.KreirajPoslovniPartner, p);
            await GetResult();
        }

        internal async Task UbaciMesto(Mesto m)
        {
            await SendRequest(Operation.UbaciMesto, m);
            await GetResult();
        }

        internal async Task<List<Bicikla>> VratiListuSviBicikla()
        {
            await SendRequest<object>(Operation.VratiListuSviBicikla);
            return (List<Bicikla>)await GetResult<List<Bicikla>>();
        }

        internal async Task<Bicikla> PretraziBicikla(Bicikla b)
        {
            await SendRequest<object>(Operation.PretraziBicikla, b);
            return (Bicikla)await GetResult<Bicikla>();
        }

        internal async Task KreirajBicikla(Bicikla b)
        {
            await SendRequest(Operation.KreirajBicikla, b);
            await GetResult();
        }

        internal async Task ObrisiBicikla(Bicikla b)
        {
            await SendRequest(Operation.ObrisiBicikla, b);
            await GetResult();
        }

        internal async Task UbaciBicikla(Bicikla b)
        {
            await SendRequest(Operation.UbaciBicikla, b);
            await GetResult();
        }

        internal async Task PromeniBicikla(Bicikla b)
        {
            await SendRequest(Operation.PromeniBicikla, b);
            await GetResult();
        }

        internal async Task<List<Bicikla>> VratiListuBicikla(Bicikla b)
        {
            await SendRequest<object>(Operation.VratiListuBicikla, b);
            return (List<Bicikla>)await GetResult<List<Bicikla>>();
        }

        internal async Task<List<Automat>> VratiListuSviAutomat()
        {
            await SendRequest<object>(Operation.VratiListuSviAutomat);
            return (List<Automat>)await GetResult<List<Automat>>();
        }

        internal async Task<List<Iznajmljivanje>> VratiListuSviIznajmljivanje()
        {
            await SendRequest<object>(Operation.VratiListuSviIznajmljivanje);
            return (List<Iznajmljivanje>)await GetResult<List<Iznajmljivanje>>();
        }

        internal async Task KreirajStavkaIznajmljivanja(StavkaIznajmljivanja s)
        {
            await SendRequest(Operation.KreirajStavkaIznajmljivanja, s);
            await GetResult();
        }

        internal async Task ObrisiStavkaIznajmljivanja(StavkaIznajmljivanja s)
        {
            await SendRequest(Operation.ObrisiStavkaIznajmljivanja, s);
            await GetResult();
        }

        internal async Task PromeniStavkaIznajmljivanja(StavkaIznajmljivanja s)
        {
            await SendRequest(Operation.PromeniStavkaIznajmljivanja, s);
            await GetResult();
        }

        internal async Task UbaciStavkaIznajmljivanja(StavkaIznajmljivanja s)
        {
            await SendRequest(Operation.UbaciStavkaIznajmljivanja, s);
            await GetResult();
        }

        internal async Task ObrisiIznajmljivanje(Iznajmljivanje i)
        {
            await SendRequest(Operation.ObrisiIznajmljivanje, i);
            await GetResult();
        }

        internal async Task KreirajIznajmljivanje(Iznajmljivanje i)
        {
            await SendRequest(Operation.KreirajIznajmljivanje, i);
            await GetResult();
        }

        internal async Task UbaciIznajmljivanje(Iznajmljivanje i)
        {
            await SendRequest(Operation.UbaciIznajmljivanje, i);
            await GetResult();
        }

        internal async Task PromeniIznajmljivanje(Iznajmljivanje i)
        {
            await SendRequest(Operation.PromeniIznajmljivanje, i);
            await GetResult();
        }

        internal async Task<List<Iznajmljivanje>> VratiListuIznajmljivanje(Iznajmljivanje i)
        {
            await SendRequest<object>(Operation.VratiListuIznajmljivanje, i);
            return (List<Iznajmljivanje>)await GetResult<List<Iznajmljivanje>>();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Common
{
    public class CommunicationHelper
    {
        private readonly Socket socket;
        private readonly NetworkStream stream;
        private readonly JsonSerializerOptions jsonOptions;

        public CommunicationHelper(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = false,
                MaxDepth = 128, 
                DefaultBufferSize = 1024 * 1024
            };
        }

        public async Task Send<T>(T obj) where T : class
        {
            await JsonSerializer.SerializeAsync(stream, obj, jsonOptions);
            await stream.FlushAsync();
        }

        public async Task<T> Receive<T>() where T : class
        {
            byte[] buffer = new byte[65136]; 
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            return JsonSerializer.Deserialize<T>(Encoding.UTF8.GetString(buffer, 0, bytesRead), jsonOptions);
        }
    
    }
}

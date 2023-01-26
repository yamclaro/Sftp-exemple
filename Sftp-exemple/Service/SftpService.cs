using Microsoft.Extensions.Logging;
using Sftp_exemple.Domain;

namespace Sftp_exemple.Service
{

    public class SftpService : ISftpService
    {
        private readonly ILogger<SftpService> _logger;
        private readonly SftpConfig _config;

        public SftpService(ILogger<SftpService> logger, SftpConfig sftpConfig)
        {
            _logger = logger;
            _config = sftpConfig;
        }


        public Task UploadFile(string filePath, IEnumerable<byte[]> fileName)
        {
            using var client = new SftpClient(_config.Host, _config.Port, _config.UserName, _config.Password);
            {
                client.Connect();

                if (client.IsConnected)
                {
                    try
                    {
                        foreach (var files in fileName)
                        {
                            client.WriteAllBytes(filePath, files);
                            Console.WriteLine("Upload ok! " + filePath);
                        }

                        return null;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Erro!");
                        return null;
                    }

                }
                return null;
                client.Disconnect();
            }
        }
        // public void UploadFile(string filePath, string fileName)
        // {
        //     using var client = new SftpClient(_config.Host,  _config.Port, _config.UserName, _config.Password);
        //     client.Connect();
        //     using (FileStream filestream = File.OpenRead(filePath))

        //     client.UploadFile(filestream, fileName, null);
        //     client.Disconnect();

        // }

    }
}
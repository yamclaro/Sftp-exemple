using Microsoft.Extensions.Logging.Abstractions;
using Sftp_exemple.Service;
using SFTPService;

namespace sftp;
public class Program
{
    private static async Task Main()
    {
        var config = new SftpConfig
        {
            Host = "ip",
            Port = 100,//porta servidor sftp
            UserName = "nomeusuario",
            Password = "senha"
        };
        var sftpService = new SftpService(new NullLogger<SftpService>(), config);

        var path = "/local gravar arquivo";
        var nomeArquivo = "teste";

        //sftpService.UploadFile(testFile, "/.");
        var file = await File.ReadAllBytesAsync("C://");

        List<byte[]> list = new List<byte[]>();
        list.Add(file);
        var filePath = Path.Combine(list, "teste.txt");

        await sftpService.UploadFile(filePath, filePath);
    }
}

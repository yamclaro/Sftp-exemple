namespace Sftp_exemple.Service
{
    public interface ISftpService
    {
        Task UploadFile(string localFilePath, IEnumerable<byte[]> remoteFilePath);
    }
}
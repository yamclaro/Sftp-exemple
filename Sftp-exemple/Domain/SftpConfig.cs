using System;
using System.Collections;

namespace Sftp_exemple.Domain
{
    public class SftpConfig
    {

        public string Host { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }

    public class Byte
    {
        object Current { get; }

    }

}



namespace BusinessModel
{
    public class DownloadAccess
    {
        public string Kind { get; set; }
        public string VolumeId { get; set; }
        public bool Restricted { get; set; }
        public bool DeviceAllowed { get; set; }
        public bool JustAcquired { get; set; }
        public int MaxDownloadDevices { get; set; }
        public int DownloadsAcquired { get; set; }
        public string Nonce { get; set; }
        public string Source { get; set; }
        public string ReasonCode { get; set; }
        public string Message { get; set; }
        public string Signature { get; set; }
    }
}
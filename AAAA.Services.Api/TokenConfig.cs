namespace AAAA.Services.Api
{
    public class TokenConfig
    {
        public string SecurityKey { get; set; }
        public int Expires { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}

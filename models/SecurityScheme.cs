public class SecurityScheme
{
    public string type { get; set; }
    public string description { get; set; }
    public string name { get; set; }
    public string _in { get; set; }
    public string flow { get; set; }
    public string authorizationUrl { get; set; }
    public string tokenUrl { get; set; }
    public Dictionary<string,string> scopes { get; set; }
}
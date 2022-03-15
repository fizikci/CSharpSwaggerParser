public class Response
{
    public string refers { get; set; }
    public string description { get; set; }
    public Schema schema { get; set; }
    public Dictionary<string, Header> headers { get; set; }
    public dynamic examples { get; set; }
}
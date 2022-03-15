public class Operation
{
    public List<string> tags { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
    public ExternalDoc externalDocs { get; set; }
    public string operationId { get; set; }
    public List<string> consumes { get; set; }
    public List<string> produces { get; set; }
    public List<Parameter> parameters { get; set; }
    public Dictionary<string, Response> responses { get; set; }
    public List<string> schemes { get; set; }
    public string deprecated { get; set; }
    public Dictionary<string, List<string>> security { get; set; }

    public override string ToString()
    {
        return
            "PARAMETERS:\n" +
            String.Join('\n', parameters.OrderBy(p => p.name).Select(p => p.ToString())) + "\n" +
            "RESPONSES:\n" +
            String.Join('\n', responses.OrderBy(r => r.Key).Select(r => r.Key + "\n" + r.Value));
    }

}
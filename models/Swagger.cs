public class Swagger
{
    public string swagger { get; set; }
    public Info info { get; set; }
    public string host { get; set; }
    public string basePath { get; set; }
    public List<string> schemes { get; set; }
    public List<string> consumes { get; set; }
    public List<string> produces { get; set; }
    public Dictionary<string, PathItem> paths { get; set; }
    public Dictionary<string, Schema> definitions { get; set; }
    public Dictionary<string, Parameter> parameters { get; set; }
    public Dictionary<string, Response> responses { get; set; }
    public Dictionary<string, SecurityScheme> securityDefinitions { get; set; }
    public Dictionary<string, List<string>> security { get; set; }
    public List<Tag> tags { get; set; }
    public List<string> externalDocs { get; set; }
}

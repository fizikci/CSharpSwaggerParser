
public class JSONSchema
{
    public string refers { get; set; }
    public string format { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public string _default { get; set; }
    public string multipleOf { get; set; }
    public string maximum { get; set; }
    public string exclusiveMaximum { get; set; }
    public string minimum { get; set; }
    public string exclusiveMinimum { get; set; }
    public string maxLength { get; set; }
    public string minLength { get; set; }
    public string pattern { get; set; }
    public string maxItems { get; set; }
    public string minItems { get; set; }
    public string uniqueItems { get; set; }
    public string maxProperties { get; set; }
    public string minProperties { get; set; }
    public List<string> _enum { get; set; } // if type==string
    public string type { get; set; }
}
public class Parameter : JSONSchema
{
    // fixed fields
    public string name { get; set; }
    public string _in { get; set; } //"query", "header", "path", "formData" or "body"

    // in: body
    public Schema schema { get; set; }

    // in: not body
    public JSONSchema items { get; set; }
    public string required { get; set; }


    public string allowEmptyValue { get; set; }
    public string collectionFormat { get; set; }
}

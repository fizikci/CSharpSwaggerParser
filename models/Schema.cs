public class Schema : JSONSchema
{
    public string discriminator { get; set; }
    public string readOnly { get; set; }
    public XML xml { get; set; }
    public ExternalDoc externalDocs { get; set; }
    public dynamic example { get; set; }
    public Schema items { get; set; } // if type==array
    public Dictionary<string, Property> properties { get; set; } // if type==object
    //public List<string> required { get; set; }

    public Schema additionalProperties { get; set; }
    //public Schema allOf { get; set; }

    public override string ToString()
    {
        if (type == "object")
        {
            if (properties != null)
                return title + "\n" + String.Join("\n", properties.OrderBy(p => p.Key).Select(p => "\t" + p.Key));
            if (items != null)
                return title + "\n" + items;
        }

        return base.ToString();
    }
}

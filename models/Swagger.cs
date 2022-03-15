using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

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

    public static Swagger Parse(string swagger)
    {
        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(new UnderscoredNamingConvention())
            .Build();
        
        var x = deserializer.Deserialize<dynamic>(swagger);

        return setProps(typeof(Swagger), x) as Swagger;
    }

    static dynamic setProps(Type type, dynamic props)
    {
        if (type == typeof(string))
            return props;

        if (type == typeof(bool))
            return props;

        if (type == typeof(int))
            return props;

        if (type.FullName == "System.Object")
            return props;

        dynamic obj = Activator.CreateInstance(type);

        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
            foreach (var v in props)
                obj.Add(setProps(type.GetGenericArguments()[0], v));
        else if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Dictionary<,>))
            foreach (var kv in props)
                obj.Add(kv.Key, setProps(type.GetGenericArguments()[1], kv.Value));
        else if (type.Name.Contains("Dictionary"))
            foreach (var kv in props)
                obj.Add(kv.Key, setProps(kv.Value.GetType(), kv.Value));
        else if (type.Name.Contains("List"))
            foreach (var v in props)
                obj.Add(setProps(v.GetType(), v));
        else
            foreach (var kv in props)
            {
                var propName = kv.Key == "$ref" ? "refers" : kv.Key;
                var propVal = kv.Value;

                var prop = obj.GetType().GetProperty(propName);
                if (prop == null) prop = obj.GetType().GetProperty("_" + propName);
                if (prop == null) continue;

                prop.SetValue(obj, setProps(prop.PropertyType, propVal));
            }

        return obj;
    }
}

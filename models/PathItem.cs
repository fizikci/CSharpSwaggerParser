public class PathItem
{
    public string refers { get; set; }
    public Operation get { get; set; }
    public Operation put { get; set; }
    public Operation post { get; set; }
    public Operation delete { get; set; }
    public Operation options { get; set; }
    public Operation head { get; set; }
    public Operation patch { get; set; }
    public List<Parameter> parameters { get; set; }

    public override string ToString()
    {
        return
            (refers != null ? refers + "\n" : "") +
            (parameters!=null ? string.Join('\n', parameters.Select(p=>p.ToString())) + "\n" : "") + 
            (get != null ? "GET" + "\n" + get + "\n" : "") +
            (put != null ? "PUT" + "\n" + put + "\n" : "") +
            (post != null ? "POST" + "\n" + post + "\n" : "") +
            (delete != null ? "DELETE" + "\n" + delete + "\n" : "") +
            (options != null ? "OPTIONS" + "\n" + options + "\n" : "") +
            (head != null ? "HEAD" + "\n" + head + "\n" : "") +
            (patch != null ? "PATCH" + "\n" + patch + "\n" : "");
    }
}
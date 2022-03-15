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
}
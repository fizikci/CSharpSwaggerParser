using System.Net;

var swaggerUrl = @"http://rackerlabs.github.io/wadl2swagger/openstack/swagger/os-hosts.yaml";
var content = new WebClient().DownloadString(swaggerUrl);

var res = Swagger.Parse(content);


foreach (var path in res.paths)
{
    if (path.Value.get != null) Console.WriteLine("GET " + path.Key);
    if (path.Value.post != null) Console.WriteLine("POST " + path.Key);
    if (path.Value.put != null) Console.WriteLine("PUT " + path.Key);
}



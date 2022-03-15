using System.Diagnostics;
using System.Net;

//ForExample();

CompareTwoVersions(
    @"https://cdn.expediapartnersolutions.com/ean-rapid-site/documentation/rapid_2.4/swagger.yaml",
    @"https://cdn.expediapartnersolutions.com/ean-rapid-site/documentation/rapid_v3/swagger.yaml");


static void CompareTwoVersions(string ver1, string ver2)
{
    var sw1 = Swagger.Parse(ver1);
    var sw2 = Swagger.Parse(ver2);

    File.WriteAllText(@"c:\temp\swagger1.txt", sw1.ToString());
    File.WriteAllText(@"c:\temp\swagger2.txt", sw2.ToString());

    //Process.Start(@"""C:\Program Files\WinMerge\WinMergeU.exe"" c:\logs\swagger1.txt c:\logs\swagger2.txt");
}

static void ForExample()
{
    var res = Swagger.Parse(@"http://rackerlabs.github.io/wadl2swagger/openstack/swagger/os-hosts.yaml");


    foreach (var path in res.paths)
    {
        if (path.Value.get != null) Console.WriteLine("GET " + path.Key);
        if (path.Value.post != null) Console.WriteLine("POST " + path.Key);
        if (path.Value.put != null) Console.WriteLine("PUT " + path.Key);
    }
}


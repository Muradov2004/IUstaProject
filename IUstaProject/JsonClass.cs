using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace IUstaProject;

public static class JsonClass
{
    public static List<Orderer> ReadJsonOrderer()
    {
        string path = AppDomain.CurrentDomain.BaseDirectory[..^25] + @"JsonFiles\OrdererJson.json";
        string StringJson = File.ReadAllText(path);

        return JsonConvert.DeserializeObject<List<Orderer>>(StringJson)!;
    }

    public static void WriteJsonOrderer(Orderer orderer)
    {
        List<Orderer> orderers = ReadJsonOrderer();
        orderers.Add(orderer);
        string StringJson = JsonConvert.SerializeObject(orderers); ;

        string path = AppDomain.CurrentDomain.BaseDirectory[..^25] + @"JsonFiles\OrdererJson.json";
        File.WriteAllText(path, StringJson);
    }

    public static List<Expert> ReadJsonExpert()
    {
        string path = AppDomain.CurrentDomain.BaseDirectory[..^25] + @"JsonFiles\ExpertJson.json";
        string StringJson = File.ReadAllText(path);

        return JsonConvert.DeserializeObject<List<Expert>>(StringJson)!;
    }

    public static void WriteJsonExpert(Expert expert)
    {
        List<Expert> experts = ReadJsonExpert();
        experts.Add(expert);
        string StringJson = JsonConvert.SerializeObject(experts); ;

        string path = AppDomain.CurrentDomain.BaseDirectory[..^25] + @"JsonFiles\ExpertJson.json";
        File.WriteAllText(path, StringJson);
    }

}

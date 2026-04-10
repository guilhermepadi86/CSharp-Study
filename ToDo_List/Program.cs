using System;
using System.IO;
using System.Text.Json;

public class Tarefa
{
    public string tarefa {get; set;}
    public decimal tempoMedio {get; set;}

}

class Program
{
    static void Main()
    {
        string caminhoArquivo = "Tarefas.json";

        var ObjInicial = new Tarefa();

        string jsonLinha = JsonSerializer.Serialize(ObjInicial, new JsonSerializerOptions {WriteIndented = true});

        if (!File.Exists(caminhoArquivo))
        {
            File.WriteAllText(caminhoArquivo, jsonLinha);
        }
    }
}
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

        var ObjInicial = new Tarefa {tarefa = "Tarefa1", tempoMedio = 5};

        string jsonLinha = JsonSerializer.Serialize(ObjInicial, new JsonSerializerOptions {WriteIndented = true});

        if (!File.Exists(caminhoArquivo))
        {
            File.WriteAllText(caminhoArquivo, jsonLinha);
        }

        if (File.Exists(caminhoArquivo))
        {
            string arquivo = File.ReadAllText(caminhoArquivo);
            Tarefa tarefaLida = JsonSerializer.Deserialize<Tarefa>(arquivo);
            Console.WriteLine(tarefaLida);
        }
    }
}
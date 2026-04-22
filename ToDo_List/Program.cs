using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text.Json;
using System.IO;

class Tarefa
{
    public string Task { get; set; }
    public int Time { get; set; }
}

class Program
{
    static void Main()
    {
        int escolha = -1;
        var tarefas = CarregarTarefas();

        do
        {
            atualizarTarefas(tarefas);

            Console.WriteLine("\n===== Lista de Tarefas =====");
            Console.WriteLine("1 - Adicionar Nova Tarefa");
            Console.WriteLine("2 - Excluir Tarefa Existente");
            Console.WriteLine("3 - Alterar Tarefa Existente");
            Console.WriteLine("4 - Visualizar Todas Tarefas");
            Console.WriteLine("0 - Sair");

            if (!int.TryParse(Console.ReadLine(), out escolha))
            {
                Console.WriteLine("Entrada Inválida. Digite um número");
                continue;
            }

            switch (escolha)
            {
                case 1:
                    Console.Clear();
                    adicionarTarefa(tarefas);
                    break;

                case 2:
                    Console.Clear();
                    excluirTarefa(tarefas);
                    break;

                case 3:
                    Console.Clear();
                    alterarTarefa(tarefas);
                    break;

                case 4:
                    Console.Clear();
                    visualizarTarefas(tarefas);
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Finalizando...");
                    break;
            }

        } while (escolha != 0);
    }
    
    static void atualizarTarefas(List<Tarefa> tarefas)
    {
        var ident = new JsonSerializerOptions { WriteIndented = true};
        string tarefasAtualizadas = JsonSerializer.Serialize(tarefas, ident);
        File.WriteAllText("Tarefas.json", tarefasAtualizadas);
    }

    static  List<Tarefa> CarregarTarefas()
    {
        string arquivoJson = File.ReadAllText("Tarefas.json");
        return JsonSerializer.Deserialize<List<Tarefa>>(arquivoJson) ?? new List<Tarefa>();
    }

    static void adicionarTarefa(List<Tarefa> tarefas)
    {
        Console.WriteLine("Digite o nome da tarefa: ");
        string nome = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome inválido. Digite novamente: ");
            nome = Console.ReadLine();
        }

        Console.WriteLine("\nDigite o tempo (em minutos) para realizar a tarefa: ");
        int tempo;
        while (!int.TryParse(Console.ReadLine(), out tempo) || tempo <= 0)
        {
            Console.WriteLine("Entrada Inválida. Digite um número maior que zero");
        }

        tarefas.Add(new Tarefa { Task = nome, Time = tempo });
        Console.WriteLine("\nTarefa Adicionada com Sucesso!");
    }

    static void visualizarTarefas(List<Tarefa> tarefas)
    {
        if (tarefas.Count == 0)
        {
            Console.WriteLine("Ainda não existe nenhuma tarefa na lista");
        }
        else
        {
            Console.WriteLine("==== Tarefas ====");
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1} - Tarefa: {tarefas[i].Task} | Tempo: {tarefas[i].Time}");
            }
        }
    }

    static void excluirTarefa(List<Tarefa> tarefas)
    {
        if (tarefas.Count != 0)
        {
            visualizarTarefas(tarefas);

            Console.WriteLine("\nDigite o número da tarefa que deseja excluir: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > tarefas.Count || choice <= 0)
            {
                Console.WriteLine("Entrada inválida, digite algum valor que exista na lista.");
            }
            tarefas.RemoveAt(choice - 1);
            Console.WriteLine($"Tarefa {choice} removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Não existe nenhuma tarefa para ser excluida");
        }
    }

    static void alterarTarefa(List<Tarefa> tarefas)
    {
        if (tarefas.Count != 0)
        {
            visualizarTarefas(tarefas);

            Console.WriteLine("\nDigite a tarefa que será alterada: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > tarefas.Count || choice <= 0)
            {
                Console.WriteLine("Entrada inválida, digite algum valor que exista na lista.");
            }

            Console.WriteLine("Digite o novo nome da tarefa: ");
            string nome = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Entrada inválida, digite novamente");
                nome = Console.ReadLine();
            }

            Console.WriteLine("Digite o novo tempo da tarefa: ");
            int tempo;
            while (!int.TryParse(Console.ReadLine(), out tempo) || tempo <= 0)
            {
                Console.WriteLine("Entrada inválida. Digite um número maior que zero");
            }

            tarefas[choice - 1].Task = nome;
            tarefas[choice - 1].Time = tempo;

            Console.WriteLine($"Tarefa {choice} alterada com sucesso!");
        }
        else
        {
            Console.WriteLine("Não existe nenhuma tarefa para ser alterada");
        }
    }
}
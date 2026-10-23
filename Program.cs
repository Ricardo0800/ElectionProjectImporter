
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

string caminho = Path.Combine(
    Directory.GetCurrentDirectory(),
    "jsons",
    "candidates.json"
);

string json = File.ReadAllText(caminho);

CandidatesFile dados =
    JsonSerializer.Deserialize<CandidatesFile>(json)
    ?? throw new Exception("Não foi possível ler o JSON.");

using var context = new ElectionDbContext();

// Remove os dados antigos de teste, preservando as tabelas.
context.Topics.ExecuteDelete();
context.Categories.ExecuteDelete();
context.Candidates.ExecuteDelete();

var candidatos = dados.Candidates.Select(c => new Candidate
{
    Name = c.Name,
    Cargo = c.Cargo,

    Categories = c.Categories.Select(cat => new Category
    {
        Name = cat.Name,

        Topics = cat.Topics.Select(t => new Topic
        {
            Name = t.Name
        }).ToList()
    }).ToList()
}).ToList();

context.Candidates.AddRange(candidatos);
context.SaveChanges();

Console.WriteLine($"Candidatos importados: {candidatos.Count}");
Console.WriteLine("Importação concluída!");

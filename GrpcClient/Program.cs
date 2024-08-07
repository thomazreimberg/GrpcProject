using Grpc.Net.Client;
using GrpcProject;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Criando um canal
var channel = GrpcChannel.ForAddress("https://localhost:7170");

// Criando um cliente
var client = new Greeter.GreeterClient(channel);

// Buscando a resposta
var reply = await client.SayHelloAsync(
    new HelloRequest { Name = "Thomaz" });

Console.WriteLine("Retorno do servidor: " + reply.Message);

Console.ReadKey();
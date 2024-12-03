using Projeto2prova.Context;
using System.Collections.Generic;
using System.Linq;
using Projeto2prova.Models;

namespace Projeto2prova.Context
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();

                if (context == null) throw new Exception("Context not found");

                context.Database.EnsureCreated();

                if (!context.Clientes.Any())
                {
                    string basePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Imagens");

                    // Método auxiliar para carregar imagens
                    byte[] LoadImage(string fileName)
                    {
                        string filePath = Path.Combine(basePath, fileName);
                        if (File.Exists(filePath))
                        {
                            return File.ReadAllBytes(filePath);
                        }
                        throw new FileNotFoundException($"Arquivo não encontrado: {filePath}");
                    }

                    // Carregamento das imagens
                    byte[] foto1 = LoadImage("Foto1.jpg");
                    byte[] foto2 = LoadImage("Foto2.jpg");
                    byte[] foto3 = LoadImage("Foto3.jpg");


                    if (!context.Clientes.Any())
                    {

                        context.Clientes.AddRange(new List<Cad_Clientes>
                    {
                        new Cad_Clientes
                        {
                            Nome = "João Silva",
                            cpf = "784.845.784/71",
                            Email = "joao.silva@example.com",
                            DataNascimento = new DateTime(1990, 5, 15),
                            Sexo = "Masculino",
                            Bairro = "Bairro123",
                            Rua = "Rua das Flores",
                            Numero = 123,
                            Cidade = "São Paulo",
                            Estado = "SP",
                            CEP = "01234567",
                            Complemento = "Apto 101",
                            FotoCliente = foto1
                        },
                        new Cad_Clientes
                        {
                            Nome = "Maria Oliveira",
                            cpf = "182.458.834/70",
                            Email = "maria.oliveira@example.com",
                            DataNascimento = new DateTime(1985, 8, 22),
                            Sexo = "Feminino",
                            Bairro = "Bairro EOROEREO",
                            Rua = "Rua dos jardins",
                            Numero = 542,
                            Cidade = "São Paulo",
                            Estado = "SP",
                            CEP = "04567890",
                            Complemento = "Casa",
                            FotoCliente = foto3
                        },
                        new Cad_Clientes
                        {
                            Nome = "Carlos Pereira",
                            cpf = "154.788.000/10",
                            Email = "carlos.pereira@example.com",
                            DataNascimento = new DateTime(1975, 12, 10),
                            Sexo = "Masculino",
                            Bairro = "Bairro AUUUUU",
                            Rua = "Rua das Arvores",
                            Numero = 758,
                            Cidade = "Rio de Janeiro",
                            Estado = "RJ",
                            CEP = "21012345",
                            Complemento = "Cobertura",
                            FotoCliente = foto2
                        }
                    });
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}

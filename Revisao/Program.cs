
using Revisao;

beatrizservice beatriz = new beatrizservice();

beatriz.Id = 1;
beatriz.Apelido = "Bea e Bia";
beatriz.Idade = 17;
beatriz.Sexo = "Feminino";

beatriz.Beatriz.Add("Beatriz");
beatriz.Beatriz.Add("Beatriz Steffany");

beatriz.Habilidade.Add("Ouvir música");
beatriz.Habilidade.Add("Assistir séries");
beatriz.Habilidade.Add("Sair com amigos");

beatriz.ExibirDados();

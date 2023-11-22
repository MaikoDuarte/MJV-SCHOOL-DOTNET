//serializacao da classe
var pessoa = new Pessoa { Nome = "João", Idade = 25};
string jsonPessoa = System.Text.Json.JsonSerializer.Serialize(pessoa);
Console.WriteLine(jsonPessoa);

//desserializacao da classe
string jsonPessoaInput = @"{""Nome"":""Maria"",""Idade"":30}";
Pessoa pessoaDesserializada = System.Text.Json.JsonSerializer.Deserialize<Pessoa>(jsonPessoaInput);
Console.WriteLine($"{pessoaDesserializada.Nome}, {pessoaDesserializada.Idade}");

//Serializacao de um record
var carro = new Carro("Hb20", 2020);
string jsonCarro = System.Text.Json.JsonSerializer.Serialize(carro);
Console.WriteLine(jsonCarro);

//Desserializacao de um record
string jsonCarroInput = @"{""Modelo"":""Honda Civic"", ""Ano"":2018}";
Carro carroDesserializado = System.Text.Json.JsonSerializer.Deserialize<Carro>(jsonCarro);
Console.WriteLine(carroDesserializado);


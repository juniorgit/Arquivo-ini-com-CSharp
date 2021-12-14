### Sobre o projeto
Esse projeto mostra como ler e gravar os antigos arquivo .ini com C#. Usando seções, chaves e valores. <br/>
_How to read and write old .ini files with C#. Using sections, keys and values._

# Arquivo de exemplo de configuração .ini (arquivo.ini)
```ini
[Cliente]
Idade=44
Nome=Flavio

[Adicional]
Data=13/12/1990 00:00:00
Limite=1234,56
```

## Como gravar um arquivo de configuração
```C#
const string SECAO_CLIENTE = "Cliente";
const string SECAO_ADICIONAL = "Adicional";

// using faz gravar de forma automática (se não quiser usar o using, basta chamar o método .Salvar()
using (ConfigIni ini = new ConfigIni(arquivo))
{
    ini.SetString(SECAO_CLIENTE, "Nome", "Flavio");
    ini.SetInt(SECAO_CLIENTE, "Idade", 44);
    ini.SetDecimal(SECAO_ADICIONAL, "Limite", (decimal)1234.56);
    ini.SetDateTime(SECAO_ADICIONAL, "Data", new DateTime(1990, 12, 13));
}
```

## Como ler um arquivo de configuração
```C#
const string SECAO_CLIENTE = "Cliente";
const string SECAO_ADICIONAL = "Adicional";

ConfigIni ini = new ConfigIni(arquivo);

Console.WriteLine("Nome: " + ini.GetString(SECAO_CLIENTE, "NoMe"));
Console.WriteLine("Idade: " + ini.GetInt(SECAO_CLIENTE, "idade"));
Console.WriteLine("Limite: " + ini.GetDecimal(SECAO_ADICIONAL, "limite", 999));
Console.WriteLine("Nasc: " + ini.GetDateTime(SECAO_ADICIONAL, "Data", DateTime.Now));
```

## Métodos de leitura 
```C#
// funções para ler informações do arquivo .ini em diversos formatos
public string GetString(string secao, string chave, string padrao = "");

// Retorna o valor em formato inteiro. 
public int GetInt(string secao, string chave, int padrao = 0);

// Retorna o valor em formato bool. 
public bool GetBool(string secao, string chave, bool padrao = false);

// Retorna o valor em formato decimal. 
public decimal GetDecimal(string secao, string chave, decimal padrao = 0);

// Retorna o valor em formato DateTime. 
public DateTime GetDateTime(string secao, string chave, DateTime padrao);

// Retorna o valor em formato string da seção [Config]. 
public string GetStringConfig(string chave, string padrao = "");

// Retorna o valor em formato inteiro da seção [Config].
public int GetIntConfig(string chave, int padrao = 0);

// Retorna o valor em formato bool da seção [Config].
public bool GetBoolConfig(string chave, bool padrao = false);

// Retorna o valor em formato decimal da seção [Config].
public decimal GetDecimalConfig(string chave, decimal padrao = 0);

// Retorna o valor em formato DateTime da seção [Config].
public DateTime GetDateTimeConfig(string chave, DateTime padrao);
```

## Métodos de gravação
```C#
// Adiciona ou altera um valor ao arquivo de configuração. Se a seção não existir será criada. Se a chave não existir será criada.
public void SetString(string secao, string chave, string valor);

// Adiciona ou altera um valor ao arquivo de configuração.
public void SetInt(string secao, string chave, int valor);

// Adiciona ou altera um valor ao arquivo de configuração.
public void SetBool(string secao, string chave, bool valor);

// Adiciona ou altera um valor ao arquivo de configuração.
public void SetDecimal(string secao, string chave, decimal valor);

// Adiciona ou altera um valor ao arquivo de configuração.
public void SetDateTime(string secao, string chave, DateTime valor);

// Adiciona ou altera um valor ao arquivo de configuração.
public void SetDate(string secao, string chave, DateTime valor);

// Adiciona ou altera um valor ao arquivo de configuração. A seção será [Config].
public void SetStringConfig(string chave, string valor);

// Adiciona ou altera um valor ao arquivo de configuração. A seção será [Config].
public void SetIntConfig(string chave, int valor);

// Adiciona ou altera um valor ao arquivo de configuração. A seção será [Config].
public void SetBoolConfig(string chave, bool valor);

// Adiciona ou altera um valor ao arquivo de configuração. A seção será [Config].
public void SetDecimalConfig(string chave, decimal valor);

// Adiciona ou altera um valor ao arquivo de configuração. A seção será [Config].
public void SetDateTimeConfig(string chave, DateTime valor);

// Adiciona ou altera um valor ao arquivo de configuração. A seção será [Config].
public void SetDateConfig(string chave, DateTime valor);
```

## Métodos para seções inteiras
```C#
// Retorna uma lista com todas as seções existentes no arquivo 
public List<string> GetSecoes();

// Remove uma seção inteira do arquivo de configuração e suas respectivas chave=valor
public bool ExcluirSecao(string secao);
```

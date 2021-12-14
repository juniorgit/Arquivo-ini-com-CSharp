using System;

class Program
{
    static string SECAO_CLIENTE = "Cliente";
    static string SECAO_ADICIONAL = "Adicional";

    private static void GravarArquivoConfiguracao(string arquivo)
    {
        using (ConfigIni ini = new ConfigIni(arquivo))
        {
            ini.SetString(SECAO_CLIENTE, "Nome", "Flavio");
            ini.SetInt(SECAO_CLIENTE, "Idade", 44);
            ini.SetDecimal(SECAO_ADICIONAL, "Limite", (decimal)1234.56);
            ini.SetDateTime(SECAO_ADICIONAL, "Data", new DateTime(1990, 12, 13));
        }

        Console.WriteLine("Dados gravados em " + arquivo + "\nPressione ENTER para efetuar a leitura");
    }

    private static void LerArquivoConfiguracao(string arquivo)
    {
        ConfigIni ini = new ConfigIni(arquivo);

        Console.WriteLine("Nome: " + ini.GetString(SECAO_CLIENTE, "NoMe"));
        Console.WriteLine("Idade: " + ini.GetInt(SECAO_CLIENTE, "idade"));
        Console.WriteLine("Limite: " + ini.GetDecimal(SECAO_ADICIONAL, "limite", 999));
        Console.WriteLine("Nasc: " + ini.GetDateTime(SECAO_ADICIONAL, "Data", DateTime.Now));
    }

    static void Main(string[] args)
    {
        string arquivo = @"c:\temp\Arquivo.ini";

        GravarArquivoConfiguracao(arquivo);
        Console.ReadLine();

        LerArquivoConfiguracao(arquivo);
        Console.ReadLine();
    }
}
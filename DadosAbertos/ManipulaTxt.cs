using System;
using System.IO;

// Mudar o user -> joao.brito
var path = @"C:\Users\joao.brito\Desktop\estabelecimento9.CSV";
var newPath = @"C:\Users\joao.brito\Desktop\DadosFormatados\estabelecimento9\editado";
var contador = 1;

try
{
    using (StreamReader sr = new StreamReader(path))
    {
        StreamWriter sw = new StreamWriter(newPath + contador.ToString() + ".csv");
        
            for (int count = 0; count < 5; count++)
            {
                // if (count != 0) Para arquivos que já venham com o cabeçalho
                // {
                sw.WriteLine("cnpj_basico;cnpj_ordem;cnpj_dv;id_matriz_filial;nome_fantasia;situacao_cadastral;data_situacao;motivo_situacao;cidade_ex;pais;inicio_atividade;cnae_principal;cnae_secundaria;logradouro;numero;complemento;bairro;cep;uf;municipio;;ddd1;tel1;ddd2;tel2;ddd_fax;fax;email;situacao_especial;data_especial");
                for (int i = 0; i < 1_000_000; i++)
                {
                    var texto = sr.ReadLine();
                    sw.WriteLine(texto);
                }
                sw.Close();
                contador++;
                sw = new StreamWriter(newPath + contador.ToString() + ".csv");
                // }
                // else
                // {
                //     for (int i = 0; i < 1_000_000; i++)
                //     {
                //         var texto = sr.ReadLine();
                //         sw.WriteLine(texto);
                //     }
                //     sw.Close();
                //     contador++;
                //     sw = new StreamWriter(newPath + contador.ToString() + ".csv");
                // }
            }

    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// ⬇ Nesse formato com AppendText o programa fica mais lento
//copia uma linha, fecha o arquivo, abre outra e repete o processo

//try {
//    using (StreamReader sr = new StreamReader(path)) {
//        for (int count = 0; count < 100; count++) {
//            for (int i = 0; i < 10000; i++) {
//                var texto = sr.ReadLine();
//                using (StreamWriter sw = File.AppendText(newPath)) {
//                    sw.WriteLine(texto);
//                }
//            }
//        }
//    }
//} catch (Exception ex) {
//    Console.WriteLine(ex.Message);
//}

using System;
using System.IO;

// Mudar o user -> joao.brito
var path = @"C:\Users\joao.brito\Desktop\socios4.SOCIOCSV";
var newPath = @"C:\Users\joao.brito\Desktop\DadosFormatados\socios4\editado";
var contador = 1;

try
{
    using (StreamReader sr = new StreamReader(path))
    {
        StreamWriter sw = new StreamWriter(newPath + contador.ToString() + ".csv");
        for (int count = 0; count < 3; count++)
        {
            // if (count != 0) Para arquivos que já venham com o cabeçalho
            // {
                sw.WriteLine("cnpj;tipo_socio;nome_socio;cnpj_cpf_socio;cod_qualificacao;data_entrada;cod_pais_ext;cpf_repres;nome_repres;cod_qualif_repres;faixa_etaria");
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
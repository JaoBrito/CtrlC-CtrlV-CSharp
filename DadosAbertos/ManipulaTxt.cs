using System;
using System.IO;

var path = @"C:\Users\user\Desktop\original.EMPRECSV";
var newPath = @"C:\Users\user\Desktop\DadosFormatados\editado";
var contador = 1;

try
{
    using (StreamReader sr = new StreamReader(path))
    {
        StreamWriter sw = new StreamWriter(newPath + contador.ToString() + ".csv");
        for (int count = 0; count < 13; count++)
        {
             if(count != 0){
             sw.WriteLine("cnpj_basico;razao_social;natureza_jur;qual_resp;capital_social;porta_empresa;ent_fed");
            for (int i = 0; i < 1000000; i++)
            {
                var texto = sr.ReadLine();
                sw.WriteLine(texto);
            }
        sw.Close();
        contador++;
        sw = new StreamWriter(newPath + contador.ToString() + ".csv");   
           } else {
                for (int i = 0; i < 1000000; i++)
            {
                var texto = sr.ReadLine();
                sw.WriteLine(texto);
            }
        sw.Close();
        contador++;
        sw = new StreamWriter(newPath + contador.ToString() + ".csv");
            }
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
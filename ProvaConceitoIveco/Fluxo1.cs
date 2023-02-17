using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaConceitoIveco
{
    internal class Fluxo1
    {
        IWebDriver Driver;
        Util u = new Util();
        public void Cenários1()
        {


            Object Nometeste = "";
            StreamWriter valor = new StreamWriter("C:\\Users\\Auditeste0367\\Desktop\\IVECO\\ProvaConceitoIveco\\Log\\x.txt");

            DateTime inicioteste = DateTime.Now;
            String PathExcel= "C:\\Users\\Auditeste0367\\Desktop\\IVECO\\ProvaConceitoIveco\\Planilhas\\Massa.xlsx";
            String PathDriver = Directory.GetCurrentDirectory();

            Microsoft.Office.Interop.Excel.Application InstanciaExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook Planilha = InstanciaExcel.Workbooks.Open(PathExcel);
            Microsoft.Office.Interop.Excel._Worksheet Sheet = (Microsoft.Office.Interop.Excel._Worksheet)Planilha.Sheets[1];
            Microsoft.Office.Interop.Excel.Range range = Sheet.UsedRange;

            for (int x=2;x<100;x++)
            {

                try
                {
                    inicioteste = DateTime.Now;

                    Nometeste = range.Cells[x, 1].Text;
                    Object Ambiente = range.Cells[x, 2].Text;
                    Object Menu = range.Cells[x, 3].Text;
                    Object Nome = range.Cells[x, 4].Text;
                    Object Sobrenome = range.Cells[x, 5].Text;
                    Object Empresa = range.Cells[x, 6].Text;
                    Object Telefone = range.Cells[x, 7].Text;
                    Object Email = range.Cells[x, 8].Text;
                    Object Endereço = range.Cells[x, 9].Text;
                    Object Cep = range.Cells[x, 10].Text;
                    Object Cidade = range.Cells[x, 11].Text;
                    Object Comentarios = range.Cells[x, 12].Text;


                    if (Nometeste.Equals("")) { break; }
                    valor = new StreamWriter("C:\\Users\\Auditeste0367\\Desktop\\IVECO\\ProvaConceitoIveco\\Log\\" + Nometeste.ToString() + "_Log.txt", true, Encoding.ASCII);

                    valor.WriteLine("Executando :"+ Nometeste.ToString());
                    valor.WriteLine("Ambiente   :"+ Ambiente.ToString());
                    valor.WriteLine("Menu       :"+ Menu);
                    valor.WriteLine("Nome       :"+ Nome);
                    valor.WriteLine("Sobrenome  :"+ Sobrenome);
                    valor.WriteLine("Empresa    :"+ Empresa);
                    valor.WriteLine("Telefone   :"+ Telefone);
                    valor.WriteLine("Email      :"+ Email);
                    valor.WriteLine("Endereço   :"+ Endereço);
                    valor.WriteLine("Cep        :"+ Cep);
                    valor.WriteLine("Cidade     :"+ Cidade);
                    valor.WriteLine("Comentarios:"+Comentarios);

                    Driver = new ChromeDriver(PathDriver);
                    Driver.Navigate().GoToUrl(Ambiente.ToString());
                    Driver.Manage().Window.Maximize();
                    System.Threading.Thread.Sleep(1000);

                    valor.WriteLine("Abrindo Driver: OK" );

                    Driver.FindElement(By.Id("CybotCookiebotDialogBodyButtonAccept")).Click();
                    System.Threading.Thread.Sleep(1000);

                    valor.WriteLine("Aceitando Cookies: OK");

                    //Financeiro
                    if (Menu.Equals("Financiamento"))
                    {

                        valor.WriteLine("Preenchendo Financiamento: OK");

                        Driver.FindElement(By.XPath("/html/body/div[2]/form/div[3]/div[2]/div[1]/div/div[1]/div/div/h4/a/span")).Click();
                        System.Threading.Thread.Sleep(3000);

                        //Nome
                        Driver.FindElement(By.XPath("/html/body/div[1]/form/div[3]/span/div/div/div/div[2]/div[1]/div/aside/div[1]/div/div/div[2]/div[1]/input")).SendKeys(Nome.ToString());

                        //Sobrenome
                        Driver.FindElement(By.XPath("/html/body/div[1]/form/div[3]/span/div/div/div/div[2]/div[1]/div/aside/div[1]/div/div/div[2]/div[2]/input")).SendKeys(Sobrenome.ToString());

                        //Empresa
                        Driver.FindElement(By.XPath("/html/body/div[1]/form/div[3]/span/div/div/div/div[2]/div[1]/div/aside/div[1]/div/div/div[2]/div[3]/input")).SendKeys(Empresa.ToString());

                        //Telefone
                        Driver.FindElement(By.XPath("/html/body/div[1]/form/div[3]/span/div/div/div/div[2]/div[1]/div/aside/div[1]/div/div/div[2]/div[4]/input")).SendKeys(Telefone.ToString());

                        //email
                        Driver.FindElement(By.XPath("/html/body/div[1]/form/div[3]/span/div/div/div/div[2]/div[1]/div/aside/div[1]/div/div/div[2]/div[5]/input")).SendKeys(Email.ToString());

                        //Endereço
                        Driver.FindElement(By.XPath("/html/body/div[1]/form/div[3]/span/div/div/div/div[2]/div[1]/div/aside/div[1]/div/div/div[2]/div[6]/input")).SendKeys(Endereço.ToString());

                        //Cep
                        Driver.FindElement(By.XPath("/html/body/div[1]/form/div[3]/span/div/div/div/div[2]/div[1]/div/aside/div[1]/div/div/div[2]/div[7]/input")).SendKeys(Cep.ToString());

                        //Cidade
                        Driver.FindElement(By.XPath("/html/body/div[1]/form/div[3]/span/div/div/div/div[2]/div[1]/div/aside/div[1]/div/div/div[2]/div[8]/input")).SendKeys(Cidade.ToString());

                        //Cometários
                        Driver.FindElement(By.XPath("/html/body/div[1]/form/div[3]/span/div/div/div/div[2]/div[1]/div/aside/div[1]/div/div/div[2]/div[9]/textarea")).SendKeys(Comentarios.ToString());

                        //Check
                        Driver.FindElement(By.XPath("/html/body/div[1]/form/div[3]/span/div/div/div/div[2]/div[1]/div/aside/div[1]/div/div/div[2]/div[10]/div/label/input")).Click();

                        //Enviar
                        //Driver.FindElement(By.XPath("/html/body/div[1]/form/div[3]/span/div/div/div/div[2]/div[1]/div/aside/div[1]/div/div/div[2]/div[13]/a")).Click();


                        valor.WriteLine("Enviando Financiamento: OK");

                    }

                    if (Menu.Equals("Cotacao")) {


                        valor.WriteLine("Abrindo Pedido de Cotação: OK");

                        Driver.Navigate().GoToUrl("https://iveco.com.br/querocomprar/?_ga=2.117884367.778070865.1676495197-600842244.1676495197");
                        System.Threading.Thread.Sleep(5000);


                        valor.WriteLine("Preenchendo Cotação: OK");


                        //CNPJ
                        Driver.FindElement(By.Id("cpf_cnpj")).SendKeys("65445000123");

                        //nome
                        Driver.FindElement(By.Id("nome")).SendKeys("Auditeste");

                        //celular
                        Driver.FindElement(By.Id("celular")).SendKeys("11 987656543");

                        //Email
                        Driver.FindElement(By.Id("email")).SendKeys("teste@teste.com.br");

                        //estado
                        Driver.FindElement(By.Id("estado")).SendKeys("SAO PAULO");
                        System.Threading.Thread.Sleep(5000);

                        //cidade
                        Driver.FindElement(By.Id("cidade")).SendKeys("SALES");

                        //produto_interesse
                        Driver.FindElement(By.Id("produto_interesse")).SendKeys(Keys.Down + Keys.Down + Keys.Tab);

                        //previsao_compra
                        Driver.FindElement(By.Id("previsao_compra")).SendKeys("IMEDIATA");

                        //ENVIAR
                        Driver.FindElement(By.Name("envia-form")).Click();


                        valor.WriteLine("Enviando Cotação: OK");


                    }//Cotação


                    range.Cells[x, 13].Value = "OK";

                    valor.WriteLine("Resultado: OK");


                }
                catch (Exception e) {

                    IList<IWebElement> erros = Driver.FindElements(By.Id("cpf_cnpj-error"));
                    if (erros.Count() > 0) {
                        range.Cells[x, 13].Value = erros[0].Text;

                        valor.WriteLine("Error:" + erros[0].Text) ;

                    }
                }

                DateTime fimteste = DateTime.Now;

                TimeSpan tempo = fimteste - inicioteste;
                u.print(Driver, Nometeste.ToString());
                range.Cells[x, 14].Value = tempo.ToString();
                
                valor.WriteLine("Tempo de Execução:"+ tempo);

                Planilha.Save();
                Driver.Quit();

                valor.WriteLine("======================================================================================");
                valor.Close();

            }//end for





        }
    }
}

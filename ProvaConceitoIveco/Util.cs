using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaConceitoIveco
{
    internal class Util
    {
        public void print(IWebDriver driver, String nome)
        {

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\Auditeste0367\\Desktop\\IVECO\\ProvaConceitoIveco\\Evidencias\\" + nome + ".Jpeg", ScreenshotImageFormat.Jpeg);

        }



        public void CriaTXT()
        {
                //Abrir o arquivo
                StreamWriter valor = new StreamWriter("C:\\Users\\Auditeste0367\\Desktop\\IVECO\\ProvaConceitoIveco\\Log\\Log.txt", true, Encoding.ASCII);

                valor.Write("Working");

                //Fecha o arquivo
                valor.Close();
        }




    }

    }


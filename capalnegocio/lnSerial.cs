using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Management;

namespace capalnegocio
{
    public class lnSerial
    {
        public string cpuInfo = "";
        public string macaddress;
        public string strMotherBoardID = string.Empty;

        private TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider(); // Algorithmo TripleDES
        private MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider(); // objeto md5
        private string myKey = "MyKey2012"; // Clave secreta(puede alterarse)

        public static string GenerarSerial(string inputString)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i <= hash.Length - 1; i++)
                stringBuilder.Append(hash[i].ToString("X2"));
            return stringBuilder.ToString();
        }

        public string GetMacAddress()
        {
            string qstring = "SELECT * FROM Win32_NetworkAdapterConfiguration where IPEnabled = true";
            foreach (ManagementObject mo in new System.Management.ManagementObjectSearcher(qstring).Get())
            {
                macaddress = mo["MacAddress"].ToString();
                if (macaddress != null)
                    return macaddress;
            }
            return "";
        }

        public string GetMotherBoardID()
        {
            SelectQuery query = new SelectQuery("Win32_BaseBoard");
            ManagementObjectSearcher search = new ManagementObjectSearcher(query);
            foreach (ManagementObject info in search.Get())
            {
                strMotherBoardID = info["SerialNumber"].ToString();
            }
            return strMotherBoardID;
        }

        public string GetCpuID()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return cpuInfo;
        }


        // Funcion para el Encriptado de Cadenas de Texto

        public string Encriptar(string texto)
        {

            lnSerial encript = new lnSerial();
            if ((texto.Trim() == ""))
            {
               return Encriptar(texto);
            }
            else
            {
                des.Key = hashmd5.ComputeHash(new UnicodeEncoding().GetBytes(myKey));
                des.Mode = CipherMode.ECB;
                ICryptoTransform encrypt = des.CreateEncryptor();
                byte[] buff = UnicodeEncoding.ASCII.GetBytes(texto);
               return Encriptar(Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length)));
            }

          
        }

        // Funcion para el Desencriptado de Cadenas de Texto
        public string Desencriptar(string texto)
        {
            if (texto.Trim() == "")
                return Desencriptar(texto);
            else
            {
                des.Key = hashmd5.ComputeHash((new UnicodeEncoding()).GetBytes(myKey));
                des.Mode = CipherMode.ECB;
                ICryptoTransform desencrypta = des.CreateDecryptor();
                byte[] buff = Convert.FromBase64String(texto);
                return Desencriptar(UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length)));
            }
           
        }

    }
}

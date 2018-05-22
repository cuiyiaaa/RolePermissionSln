using System.Security.Cryptography;
using System.Text;

namespace Cy.RolePermission.Common
{
    /// <summary>
    /// 加密类
    /// </summary>
    public class Encryption
    {
        /// <summary>
        ///将字符串加密为MD5
        /// </summary>
        /// <param name="str">加密的字符串</param>
        /// <returns></returns>
        public static string GetMd5String(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            byte[] md5fBuffer = md5.ComputeHash(buffer);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < md5fBuffer.Length; i++)
            {
                sb.Append(md5fBuffer[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}

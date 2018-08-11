using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Crypt
{
    public class ClassCrypt
    {

        //static public void EncryptFile(string inputFile, string outputFile, string @password)
        //{

        //    try
        //    {
        //        //string password = @"myKey123"; // Your Key Here

        //        UnicodeEncoding UE = new UnicodeEncoding();
        //        byte[] key = UE.GetBytes(password);
        //        FileStream fsCrypt = new FileStream(outputFile, FileMode.Create);

        //        RijndaelManaged RMCrypto = new RijndaelManaged();



        //        CryptoStream cs = new CryptoStream(fsCrypt,
        //            RMCrypto.CreateEncryptor(key, key),
        //            CryptoStreamMode.Write);

        //        FileStream fsIn = new FileStream(inputFile, FileMode.Open);

        //        int data;
        //        while ((data = fsIn.ReadByte()) != -1)
        //            cs.WriteByte((byte)data);


        //        fsIn.Close();
        //        cs.Close();
        //        fsCrypt.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Fail to encrypt", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        /////<summary>
        ///// Steve Lydford - 12/05/2008.
        /////
        ///// Decrypts a file using Rijndael algorithm.
        /////</summary>
        /////<param name="inputFile"></param>
        /////<param name="outputFile"></param>
        //static public void DecryptFile(string inputFile, string outputFile, string @password)
        //{

        //    {
        //        //string password = @"myKey123"; // Your Key Here

        //        UnicodeEncoding UE = new UnicodeEncoding();
        //        byte[] key = UE.GetBytes(password);

        //        FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

        //        RijndaelManaged RMCrypto = new RijndaelManaged();

        //        CryptoStream cs = new CryptoStream(fsCrypt,
        //            RMCrypto.CreateDecryptor(key, key),
        //            CryptoStreamMode.Read);

        //        FileStream fsOut = new FileStream(outputFile, FileMode.Create);

        //        int data;
        //        while ((data = cs.ReadByte()) != -1)
        //            fsOut.WriteByte((byte)data);

        //        fsOut.Close();
        //        cs.Close();
        //        fsCrypt.Close();

        //    }
        //}
        static public void EncryptFileSalt(string inputFile, string outputFile, string @password)
        {

            try
            {
                //string password = @"myKey123"; // Your Key Here
                byte[] salt = { 12, 3, 4, 5, 12, 89, 17, 233 };
                int keyLength = 16;

                byte[] key;

                using (var pbkdf = new Rfc2898DeriveBytes(password, salt))
                {
                    key = pbkdf.GetBytes(keyLength);
                }

                using (FileStream fsCrypt = new FileStream(outputFile, FileMode.Create))
                {

                    RijndaelManaged RMCrypto = new RijndaelManaged();



                    using (CryptoStream cs = new CryptoStream(fsCrypt,
                        RMCrypto.CreateEncryptor(key, key),
                        CryptoStreamMode.Write))
                    {

                        using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                        {

                            int data;
                            while ((data = fsIn.ReadByte()) != -1)
                                cs.WriteByte((byte)data);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail to encrypt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
          
            
            }
        }
        ///<summary>
        /// Steve Lydford - 12/05/2008.
        ///
        /// Decrypts a file using Rijndael algorithm.
        ///</summary>
        ///<param name="inputFile"></param>
        ///<param name="outputFile"></param>
        static public void DecryptFileSalt(string inputFile, string outputFile, string @password)
        {

            {
                //string password = @"myKey123"; // Your Key Here
                byte[] salt = { 12, 3, 4, 5, 12, 89, 17, 233 };
                int keyLength = 16;

                byte[] key;

                using (var pbkdf = new Rfc2898DeriveBytes(password, salt))
                {
                    key = pbkdf.GetBytes(keyLength);
                }


                using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
                {

                    RijndaelManaged RMCrypto = new RijndaelManaged();

                    using (CryptoStream cs = new CryptoStream(fsCrypt,
                        RMCrypto.CreateDecryptor(key, key),
                        CryptoStreamMode.Read))
                    {

                        using (FileStream fsOut = new FileStream(outputFile, FileMode.Create))
                        {

                            int data;
                            while ((data = cs.ReadByte()) != -1)
                                fsOut.WriteByte((byte)data);
                        }
                    }
                }

            }
        }
    }
}

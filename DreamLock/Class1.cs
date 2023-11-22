using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using System.IO;
using HashLib;
using System.Security.Policy;



namespace DreamLock
{
    public class hashingClass
    {
        IDigest digest;
        public string CalculateMDHashofFile(string filePath, int hashType)
        {

            if (hashType == 2)
            {
                digest = new MD2Digest();

            }
            else if (hashType == 4)
            {
                digest = new MD4Digest();

            }
            else if (hashType == 5)
            {
                digest = new MD5Digest();

            }
            byte[] buffer = new byte[4096];
            int bytesRead;
            using (var stream = File.OpenRead(filePath))

            {
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    digest.BlockUpdate(buffer, 0, bytesRead);
                }
            }

            byte[] hashBytes = new byte[digest.GetDigestSize()];
            digest.DoFinal(hashBytes, 0);

            return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
        }
        public string CalculateSHAHashofFile(string filePath, int hashType)
        {
            using (var stream = File.OpenRead(filePath))
            {
                if (hashType == 1)
                {
                    using (var sha1 = SHA1.Create())
                    {
                        byte[] hash = sha1.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
                else if (hashType == 256)
                {
                    using (var sha256 = SHA256.Create())
                    {
                        byte[] hash = sha256.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
                else if (hashType == 384)
                {
                    using (var sha384 = SHA384.Create())
                    {
                        byte[] hash = sha384.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
                else if (hashType == 512)
                {
                    using (var sha512 = SHA512.Create())
                    {
                        byte[] hash = sha512.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
                else if (hashType == 224)
                {
                    IHash hasher = HashFactory.Crypto.CreateSHA224();
                    HashResult r = hasher.ComputeStream(stream);
                    return r.ToString().Replace("-", "").ToLowerInvariant();
                }
            }
                return null;
        }

        public string CalculateWhirlPoolofFile(string filePath)
        {
            using (var stream = File.OpenRead(filePath))
            {
                IHash hasher = HashFactory.Crypto.CreateWhirlpool();
                HashResult r = hasher.ComputeStream(stream);
                return r.ToString().Replace("-", "").ToLowerInvariant();
            }
            return null;

        }
        public string CalculateRIPEMDofFile(string filePath, int hashType)
        {
            if (hashType == 128)
            {
                using (var stream = File.OpenRead(filePath))
                { 
                IHash hasher = HashFactory.Crypto.CreateRIPEMD128();
                HashResult r = hasher.ComputeStream(stream);
                return r.ToString().Replace("-", "").ToLowerInvariant();
                }
            }
            else if (hashType == 160)
            {
                using (var stream = File.OpenRead(filePath))
                {
                    IHash hasher = HashFactory.Crypto.CreateRIPEMD160();
                    HashResult r = hasher.ComputeStream(stream);
                    return r.ToString().Replace("-", "").ToLowerInvariant();
                }
            }
            else if (hashType == 256)
            {
                using (var stream = File.OpenRead(filePath))
                {
                    IHash hasher = HashFactory.Crypto.CreateRIPEMD256();
                    HashResult r = hasher.ComputeStream(stream);
                    return r.ToString().Replace("-", "").ToLowerInvariant();
                }
            }
            else if (hashType == 320)
            {
                using (var stream = File.OpenRead(filePath))
                {
                    IHash hasher = HashFactory.Crypto.CreateRIPEMD320();
                    HashResult r = hasher.ComputeStream(stream);
                    return r.ToString().Replace("-", "").ToLowerInvariant();
                }
            }
            return null;

        }
    }
}

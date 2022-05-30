
using System.IO.Compression;
using System.Numerics;
using System.Text;

namespace Signum.NET
{
    public static class SignumExtensions
    {


        /// <summary>
        /// Signum Epoch DateTime UTC
        /// </summary>
        private static readonly DateTime SignumEpoch = new(2014, 8, 11, 2, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Convert Signum Node Time (seconds) to UTC time based on SignumEpoch
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static DateTime FromSignumEpochToUtc(this int seconds)
        {
            return SignumEpoch + TimeSpan.FromSeconds(seconds);
        }



        /// <summary>
        /// Gets Block reward based on block Height
        /// </summary>
        /// <param name="blockHeight"></param>
        /// <returns></returns>
        public static long GetBlockReward(this int blockHeight)
        {


            if (blockHeight == 0)
            {
                return 0;
            }
            if (blockHeight >= 972000)
            {
                // Minimum incentive, lower than 0.6 % per year
                return 10000000000;
            }
            int month = blockHeight / 10800;

            var bigInt = BigInteger.Multiply(BigInteger.Parse("100000000"),BigInteger.Divide(BigInteger.Multiply(BigInteger.Parse("10000"), BigInteger.Pow(BigInteger.Parse("95"), month)), BigInteger.Pow(BigInteger.Parse("100"), month)));

            return (long)bigInt;

        }


        /// <summary>
        /// GZip Compression 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Compress(this byte[] data)
        {
            using var compressedStream = new MemoryStream();
            using var zipStream = new GZipStream(compressedStream, CompressionMode.Compress);
            zipStream.Write(data, 0, data.Length);
            zipStream.Close();
            return compressedStream.ToArray();
        }

        /// <summary>
        /// GZip Decompression
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Decompress(this byte[] data)
        {
            using var compressedStream = new MemoryStream(data);
            using var zipStream = new GZipStream(compressedStream, CompressionMode.Decompress);
            using var resultStream = new MemoryStream();
            zipStream.CopyTo(resultStream);
            return resultStream.ToArray();
        }

        /// <summary>
        /// Truncate a string to a specifice length and add Elipsis on the end
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <param name="addEllipsis"></param>
        /// <returns></returns>
        public static string Truncate(this string value,
            int maxLength,
            bool addEllipsis = false)
        {
            // Check for valid string before attempting to truncate
            if (string.IsNullOrEmpty(value)) return value;

            // Proceed with truncating
            string? result;
            if (value.Length > maxLength)
            {
                result = value[..maxLength];
                if (addEllipsis) result += "...";
            }
            else
            {
                result = value;
            }

            return result;
        }

        /// <summary>
        /// Truncate a string to a specifice length and add Elipsis on the end
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <param name="addEllipsis"></param>
        /// <returns></returns>
        public static string RSTrim(this string value)
        {
            // Check for valid string before attempting to truncate
            if (string.IsNullOrEmpty(value)) return value;
            if (value.Length != 22) return value;

            // Proceed with truncating
            var result = value[..6];
            result += "...";
            result += value.Substring(17, 5);


            return result;
        }


        public static string EncodeRS(this ulong value)
        {
            return ReedSolomon.Encode(value);
        }

        public static ulong DecodeRS(this string value)
        {
            return ReedSolomon.Decode(value);
        }


    }




}

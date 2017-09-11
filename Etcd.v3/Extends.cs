namespace Etcd.v3
{
    public static class Extends
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Google.Protobuf.ByteString WithPrefix(this Google.Protobuf.ByteString str)
        {
            var end = str.ToByteArray();

            for (int i = end.Length - 1; i >= 0; i--)
            {
                if (end[i] < 0xff)
                {
                    end[i] = (byte)(end[i] + 1);
                    return Google.Protobuf.ByteString.CopyFrom(end);
                }
            }
            return Google.Protobuf.ByteString.CopyFrom(end);
        }
    }
}

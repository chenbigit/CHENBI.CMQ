using System;

namespace CHENBI.CMQ
{
    /// <summary>
    /// �쳣
    /// </summary>
    public class CMQClientException : Exception
    {
        public CMQClientException(string message) : base(message)
        {
        }
    }

}
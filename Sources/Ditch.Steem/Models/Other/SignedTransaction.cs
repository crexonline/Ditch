﻿using Newtonsoft.Json;

namespace Ditch.Steem.Models.Other
{
    /// <summary>
    /// signed_transaction
    /// libraries\protocol\include\steemit\protocol\transaction.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class SignedTransaction : Transaction
    {
        private object[][] _operations;

        [JsonProperty("operations")]
        public object[][] Operations
        {
            get
            {
                if (_operations != null)
                    return _operations;

                if (BaseOperations == null)
                    return new object[0][];

                var buf = new object[BaseOperations.Length][];
                for (var i = 0; i < BaseOperations.Length; i++)
                {
                    var op = BaseOperations[i];
                    buf[i] = new object[] { op.TypeName, op };
                }
                return buf;
            }
            set => _operations = value; //TODO: need cast from objects to some operations
        }

        /// <summary>
        /// API name: signatures
        /// 
        /// </summary>
        /// <returns>API type: signature_type (typedef fc::array&lt;unsigned char, 65> compact_signature;)</returns>
        [JsonProperty("signatures")]
        public string[] Signatures { get; set; }
    }
}

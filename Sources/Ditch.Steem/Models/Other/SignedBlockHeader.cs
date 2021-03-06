﻿using Newtonsoft.Json;

namespace Ditch.Steem.Models.Other
{
    /// <summary>
    /// signed_block_header
    /// steem-0.19.1\libraries\protocol\include\steemit\protocol\block_header.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class SignedBlockHeader : BlockHeader
    {
        // bdType : signature_type
        [JsonProperty("witness_signature")]
        public object WitnessSignature { get; set; }
    }
}
﻿using Org.BouncyCastle.Math.EC;
using PolymorphicPseudonymisation.Utilities;

namespace PolymorphicPseudonymisation.Entity
{
    public class Pseudonym : Entity
    {
        private readonly int version;
        private readonly ECPoint point;

        internal Pseudonym(int version, ECPoint point)
        {
            this.version = version;
            this.point = point;
        }

        public override string Standard => $"{version:D8}{Base16Util.Encode(point.GetEncoded(false))}";
        public override string Short => $"{version:D}|{Base16Util.Encode(point.GetEncoded(true))}";
    }
}
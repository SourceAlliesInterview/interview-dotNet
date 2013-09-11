using System;
using System.ComponentModel;

namespace MoqDemo.Demo.Party
{
    /// <summary>
    /// Concrete person or business
    /// </summary>
    public class Party: IParty
    {
        /// <summary>
        /// Type of Party
        /// </summary>
        public enum PartyTypeEnum
        {
            [Description("S-Corporation")]
            SCorp,
            [Description("Individual")]
            Individual,
            [Description("C-Corporation")]
            CCorp,
            [Description("Sole Proprietor")]
            SoleProprietor
        };

        /// <summary>
        /// Unique identifier for the Party
        /// </summary>
        public int TaxIdentifier { get; set; }

        /// <summary>
        /// Name of the Party or Business
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Party Type
        /// </summary>
        public PartyTypeEnum PartyType { get; set; }


        //public override bool Equals(System.Object obj) {}
    }
}

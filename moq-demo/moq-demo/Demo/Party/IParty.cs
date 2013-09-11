using System;

namespace MoqDemo.Demo.Party
{
    /// <summary>
    /// A person or business
    /// </summary>
    public interface IParty
    {

        /// <summary>
        /// Unique identifier for the Party
        /// </summary>
        int TaxIdentifier { get; set; }

        /// <summary>
        /// Name of the Party or Business
        /// </summary>
        String Name { get; set; }

        /// <summary>
        /// Type of party
        /// </summary>
        Party.PartyTypeEnum PartyType { get; set; }
        
    }
}

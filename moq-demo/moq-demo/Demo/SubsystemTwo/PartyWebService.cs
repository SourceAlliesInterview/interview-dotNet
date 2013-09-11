using System;
using MoqDemo.Demo.Party;

namespace MoqDemo.Demo.SubsystemTwo
{
    /// <summary>
    /// Accesses Party information via a RESTful web service
    /// </summary>
    public class PartyWebService : IPartyWebService
    {
        /// <summary>
        /// Get a party using it's unique tax identifier
        /// </summary>
        /// <param name="taxIdentifier">tax identifier</param>
        /// <returns></returns>
        public IParty GetPartyByTaxIdentifier(int taxIdentifier)
        {
            throw new Exception("[ERR 600] :: Unable to connect to Party Web Service");
        }
    }
}

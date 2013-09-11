using MoqDemo.Demo.Party;

namespace MoqDemo.Demo.SubsystemTwo
{
    public interface IPartyWebService
    {
        /// <summary>
        /// Get a party using it's unique tax identifier
        /// </summary>
        /// <param name="taxIdentifier">tax identifier</param>
        /// <returns>an IParty</returns>
        IParty GetPartyByTaxIdentifier(int taxIdentifier);

    }
}

using System;
using MoqDemo.Demo.Party;

namespace MoqDemo.Demo.SubsystemOne
{
    /// <summary>
    /// Calculate the credit score of a Party
    /// </summary>
    public class CreditScoreSubsystem : ICreditScoreSubsystem
    {
        /// <summary>
        /// Use a party's tax identifer to make a call into a 3rd party credit score calculation service to determine a Party's credit score
        /// </summary>
        /// <param name="party">person or a business</param>
        /// <returns>a credit score</returns>
        public int CalculateCreditScore(IParty party)
        {
            throw new Exception("[ERR 800] :: Unable to connect to 3rd party credit score calculation service");
        }
    }
}

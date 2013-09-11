using MoqDemo.Demo.SubsystemOne;
using MoqDemo.Demo.SubsystemTwo;

namespace MoqDemo.Demo.Decision
{
    /// <summary>
    /// Process responsible for decisioning a loan
    /// </summary>
    public interface IDecisionEngine
    {
        //
        // dependencies requied to decision the loan
        //
        ICreditScoreSubsystem CreditScoreSubsystem { get; set; }
        IPartyWebService PartyWebService { get; set; }

        /// <summary>
        /// Run though business logic to determine if we grant a loan
        /// </summary>
        /// <remarks>
        /// Between 700 & 850 = Very good or excellent credit score
        /// Between 680 & 699 = Good credit score  The Average American Credit Score = 682        
        /// Between 620 & 679 = Average or OK score.
        /// Between 580 & 619 = Low credit score
        /// Between 500 & 579 = Poor credit score
        /// Between 300 & 499 = Bad credit score
        /// </remarks>
        bool IsApproved(int partyTaxIdentifier, decimal loanRequestAmount);
    }
}

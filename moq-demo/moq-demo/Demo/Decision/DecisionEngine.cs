using MoqDemo.Demo.Party;
using MoqDemo.Demo.SubsystemOne;
using MoqDemo.Demo.SubsystemTwo;

namespace MoqDemo.Demo.Decision
{
    /// <summary>
    /// Decisions a loan request
    /// </summary>
    public class DecisionEngine: IDecisionEngine
    {
        public ICreditScoreSubsystem CreditScoreSubsystem { get; set; }
        public IPartyWebService PartyWebService { get; set; }

        // ReSharper disable MemberCanBePrivate.Global

        // C-Corp Rules
        public const int CcorpCreditThreshold = 620;
        public const int CcorpLoanThreshold = 50000;

        // S-Corp Rules
        public const int ScorpCreditThreshold = 680;
        public const int ScorpLoanThreshold = 20000;

        // Sole Proprietor Rules
        public const int SolePropCreditThreshold = 700;
        public const int SolePropLoanThreshold = 7500;

        // Individual Rules
        public const int IndivCreditThreshold = 750;
        public const int IndivLoanThreshold = 5000;

        // ReSharper restore MemberCanBePrivate.Global
        
        
        /// <summary>
        /// Run though business logic to determine if we grant a loan
        /// </summary>
        /// <remarks>
        /// Between 700 & 850 = Very good or excellent credit score
        /// Between 680 & 699 = Good credit score   
        /// Between 620 & 679 = Average or OK score.
        /// Between 580 & 619 = Low credit score
        /// Between 500 & 579 = Poor credit score
        /// Between 300 & 499 = Bad credit score
        /// </remarks>
        /// <param name="partyTaxIdentifier">unique identifier for the tax entity</param>
        /// <param name="loanRequestAmount">loan dollars requested </param>
        /// <returns>true if approved</returns>
        public bool IsApproved(int partyTaxIdentifier, decimal loanRequestAmount)
        {
            IParty party = PartyWebService.GetPartyByTaxIdentifier(partyTaxIdentifier);

            int creditScore = CreditScoreSubsystem.CalculateCreditScore(party);

            switch(party.PartyType)
            {
                case (Party.Party.PartyTypeEnum.CCorp):
                    if (creditScore >= CcorpCreditThreshold && loanRequestAmount < CcorpLoanThreshold)
                        return true;
                    break;
                case (Party.Party.PartyTypeEnum.SCorp):
                    if (creditScore >= ScorpCreditThreshold && loanRequestAmount < ScorpLoanThreshold)
                        return true;
                    break;
                case (Party.Party.PartyTypeEnum.SoleProprietor):
                    if (creditScore >= SolePropCreditThreshold && loanRequestAmount < SolePropLoanThreshold)
                        return true;
                    break;
                case (Party.Party.PartyTypeEnum.Individual):
                    if (creditScore >= IndivCreditThreshold && loanRequestAmount < IndivLoanThreshold)
                        return true;
                    break;
            }

            return false;

        }
    }
}

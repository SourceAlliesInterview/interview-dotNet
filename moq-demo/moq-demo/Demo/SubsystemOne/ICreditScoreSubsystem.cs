using MoqDemo.Demo.Party;

namespace MoqDemo.Demo.SubsystemOne
{
    /// <summary>
    /// Subsystem interface to the credit score calculation engine
    /// </summary>
    public interface ICreditScoreSubsystem
    {
        /// <summary>
        /// Use a party's tax identifer to make a call into a 3rd party credit score calculation engine to determine a Party's credit score
        /// </summary>
        /// <param name="party">person or a business</param>
        /// <returns>a credit score</returns>
        int CalculateCreditScore(IParty party);
    }
}

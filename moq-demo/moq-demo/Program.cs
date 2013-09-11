using System;
using MoqDemo.Demo.Decision;
using MoqDemo.Demo.SubsystemOne;
using MoqDemo.Demo.SubsystemTwo;

namespace MoqDemo
{
    /// <summary>
    /// Runs the decision engine
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            IDecisionEngine decisionEngine = new DecisionEngine();
            decisionEngine.CreditScoreSubsystem = new CreditScoreSubsystem();
            decisionEngine.PartyWebService = new PartyWebService();


            bool approved = decisionEngine.IsApproved(111223333, 40000M);


            Console.WriteLine("Party [111223333]" + ((approved)?" was":" was not") + " approved.");
            var name = Console.ReadLine();
        }
    }
}

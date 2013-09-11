using System;
using System.Reflection;
using MoqDemo.Demo.Decision;
using MoqDemo.Demo.SubsystemOne;
using MoqDemo.Demo.SubsystemTwo;
using NUnit.Framework;

namespace MoqDemoTest

{
    [TestFixture]
    public class DecisionEngineTest
    {

        public const int TaxidCcorpExcellent = 111223333;
        public const int TaxidScorpExcellent = 111556666;
        public const int TaxidSolepExcellent = 111889999;
        public const int TaxidIndivExcellent = 111000000;

        public const int TaxidCcorpFair = 444223333;
        public const int TaxidScorpFair = 444556666;
        public const int TaxidSolepFair = 444889999;
        public const int TaxidIndivFair = 444000000;


        [Test]
        public void DecideLoanForCorp()
        {
            IDecisionEngine decisionEngine = new DecisionEngine();
            decisionEngine.CreditScoreSubsystem = new CreditScoreSubsystem();
            decisionEngine.PartyWebService = new PartyWebService();


            bool approved = decisionEngine.IsApproved(TaxidCcorpExcellent, 40000M);

            Assert.IsTrue(approved, "Expected a 40k loan to be approved for this C-Corp");

        }

        #region Demo Notes
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         * 
         * 
         * public override bool Equals(System.Object obj) {}
         * 
         * 
         * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
        #endregion


        #region Helper Code
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
        #endregion

    }
}

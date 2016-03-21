using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Verif_Mail;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LongueurPartieLocal()
        {
            string Test = "ntarobalongueuravantarobasslongueuravasselongueuravantarobasselongueuravantarobasselongueuravantarobasse@test.com";
            string b = Lib.Verification_Email(Test);
            Assert.AreNotEqual(b, "");
        }
        [TestMethod]
        public void LongueurPartieDomaine()
        {
            int i = 0;
            char[] Test = new char[270];
            while(i < Test.Length)
            {
                Test[i] = 'a';
                if (i == 4)
                    Test[i] = '@';
                i++;
            }
            Test[270 - 3] = '.';
                

            string b = Lib.Verification_Email(Convert.ToString(Test));
            Assert.AreNotEqual(b, "");
        }
        [TestMethod]
        public void DeuxArobase()
        {
            string Test = "a@a@aa.fr";
            string b = Lib.Verification_Email(Test);
            Assert.AreNotEqual(b, "");
        }
        [TestMethod]
        public void DeuxPointAlasuite()
        {
            string Test = "aa@aa..fr";
            string b = Lib.Verification_Email(Test);
            Assert.AreNotEqual(b, "");
        }
        [TestMethod]
        public void DeuxTiretAlasuite()
        {
            string Test = "aa@aa--test.fr";
            string b = Lib.Verification_Email(Test);
            Assert.AreNotEqual(b, "");
        }
        [TestMethod]
        public void PointAlasuiteArobase()
        {
            string Test = "aa@.aa.fr";
            string b = Lib.Verification_Email(Test);
            Assert.AreNotEqual(b, "");
        }
        [TestMethod]
        public void TiretAlasuiteArobase()
        {
            string Test = "aa@-aa.fr";
            string b = Lib.Verification_Email(Test);
            Assert.AreNotEqual(b, "");
        }
        [TestMethod]
        public void EspaceLocal()
        {
            string Test = "a a@aa.fr";
            string b = Lib.Verification_Email(Test);
            Assert.AreNotEqual(b, "");
        }
        [TestMethod]
        public void LocalCaractereSpeciauxalasuite()
        {
            string Test = "a_.a@aa.fr";
            string b = Lib.Verification_Email(Test);
            Assert.AreNotEqual(b, "");
        }
        [TestMethod]
        public void LocalCaractereSpeciauxalasuite2()
        {
            string Test = "a-.a@aa.fr";
            string b = Lib.Verification_Email(Test);
            Assert.AreNotEqual(b, "");
        }
        [TestMethod]
        public void EspaceDomaine()
        {
            string Test = "aa@a a.fr";
            string b = Lib.Verification_Email(Test);
            Assert.AreNotEqual(b, "");
        }
        [TestMethod]
        public void LangUnChar()
        {
            string Test = "aa@aa.r";
            string b = Lib.Verification_Email(Test);
            Assert.AreNotEqual(b, "");
        }



        [TestMethod]
        public void AdresseLaPlusLongueAuMondeAvecToutCaractereSpeciauxAutorise()
        {
            string Test = "hello-webmaster-info-services-peter_crazy.but-oh-so-ubber-cool-en@lovertester-abcdefghijklmnopqrstuvwxyz-please-try-to.send-me-an-email-if-you-can-possibly-begin-to-remember-this-coz.this-is-the-longest-email-address-known-to-man-but-to-be-honest.this-is-such-a-stupidly-long-sub-domain-it-could-go-on-forever.pacraig.com";
            string b = Lib.Verification_Email(Test);
            Assert.AreEqual(b, "");
        }
    }
}

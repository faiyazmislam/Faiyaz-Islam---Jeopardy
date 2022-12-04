using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jeopardy___Unit_Testing
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void PlayerTest()
        {
            Player player1;
            Assert.AreSame(null, player1);

            int id = 1;
            string name = "Jenny";
            player1 = new Player(id, name);
            Assert.AreNotSame(null, player1);
            Assert.AreEqual(1, player1.Id);
            Assert.AreEqual("Jenny", player1.Name);
        }
    }
}

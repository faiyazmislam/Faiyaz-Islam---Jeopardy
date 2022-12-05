using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _3309___Term_Project___Jeopardy;
using System.Collections.Generic;

namespace Jeopardy___Unit_Testing
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void TestPlayer()
        {
            //Test Player object when initiated
            int id = 1;
            string name = "Jenny";
            Player player1 = new Player(id, name);
            Assert.AreNotEqual(null, player1);
            Assert.AreEqual(1, player1.Id);
            Assert.AreEqual("Jenny", player1.Name);
            Assert.AreEqual(0, player1.PlayerScore);
            Assert.AreEqual(null, player1.ChosenCategory);
            Assert.AreEqual(0, player1.ChosenPoint);

            //Test if the data are updated
            player1.Id = 2;
            player1.Name = "Faiyaz";
            player1.PlayerScore = 300;
            player1.ChosenCategory = "Music";
            player1.ChosenPoint = 300;
            Assert.AreEqual(2, player1.Id);
            Assert.AreEqual("Faiyaz", player1.Name);
            Assert.AreEqual(300, player1.PlayerScore);
            Assert.AreEqual("Music", player1.ChosenCategory);
            Assert.AreEqual(300, player1.ChosenPoint);
            //updated data are not previous data (when initiated)
            Assert.AreNotEqual(1, player1.Id);
            Assert.AreNotEqual("Jenny", player1.Name);
            Assert.AreNotEqual(0, player1.PlayerScore);
            Assert.AreNotEqual(null, player1.ChosenCategory);
            Assert.AreNotEqual(0, player1.ChosenPoint);

            //Test if the data are updated - part 2
            player1.Id = 3;
            player1.Name = "Chris";
            player1.PlayerScore = 400;
            player1.ChosenCategory = "Animal";
            player1.ChosenPoint = 100;
            Assert.AreEqual(3, player1.Id);
            Assert.AreEqual("Chris", player1.Name);
            Assert.AreEqual(400, player1.PlayerScore);
            Assert.AreEqual("Animal", player1.ChosenCategory);
            Assert.AreEqual(100, player1.ChosenPoint);
            //updated data are not previous data 
            Assert.AreNotEqual(2, player1.Id);
            Assert.AreNotEqual("Faiyaz", player1.Name);
            Assert.AreNotEqual(300, player1.PlayerScore);
            Assert.AreNotEqual("Music", player1.ChosenCategory);
            Assert.AreNotEqual(300, player1.ChosenPoint);

            //Test Player object when initiated (part 2) and updated
            Player thePlayer = new Player(90, "Jelly");
            Assert.AreNotEqual(null, thePlayer);
            Assert.AreEqual(90, thePlayer.Id);
            Assert.AreEqual("Jelly", thePlayer.Name);
            Assert.AreEqual(0, thePlayer.PlayerScore);
            Assert.AreEqual(null, thePlayer.ChosenCategory);
            Assert.AreEqual(0, thePlayer.ChosenPoint);

            thePlayer.PlayerScore = 700;
            thePlayer.ChosenCategory = "Temple";
            thePlayer.ChosenPoint = 500;
            Assert.AreEqual(700, thePlayer.PlayerScore);
            Assert.AreEqual("Temple", thePlayer.ChosenCategory);
            Assert.AreEqual(500, thePlayer.ChosenPoint);

            //Test 2 Player objects
            Assert.AreNotSame(player1, thePlayer);
            player1 = thePlayer;
            Assert.AreSame(player1, thePlayer);
            Assert.AreEqual(player1.Id, thePlayer.Id);
            Assert.AreEqual(player1.Name, player1.Name);
            Assert.AreEqual(player1.PlayerScore, player1.PlayerScore);
            Assert.AreEqual(player1.ChosenCategory, player1.ChosenCategory);
            Assert.AreEqual(player1.ChosenPoint, player1.ChosenPoint);

            Assert.AreNotEqual("Chris", player1.Name);  //player1.Name != previous data
            Assert.AreEqual("Jelly", player1.Name);     //player1.Name = thePlayer.Name (Jelly)

            //Test - null
            player1 = null;
            Assert.AreEqual(null, player1);
            Assert.AreNotEqual(null, thePlayer);
        }
    }
}

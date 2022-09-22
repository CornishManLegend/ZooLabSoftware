using ZooLabLibrary.Console;

namespace ZooLab.Test
{
    public class ZooLabTest
    {
        [Fact]
        public void ShouldBeAbleToRunZooCorp()
        {
            ZooCorp zooCorp = new ZooCorp();
            zooCorp.Run(new DefaultConsole());
        }

        [Fact]
        public void ShouldBeAbleToRunZooCorpWithConsoleMock()
        {
            MockConsole mockConsole = new MockConsole();
            ZooCorp zooCorp = new ZooCorp();
            zooCorp.Run(mockConsole);

            List<string> expectedOutput = new List<string>()
            {
                "New zoo located in Texas added to Zoo Corporation",
                "New zoo located in Holliwood added to Zoo Corporation",
                "New Enclosure added: Enclosure1 to zoo in Texas",
                "New Enclosure added: Enclosure1 to zoo in Holliwood",
                "New Enclosure added: Enclosure2 to zoo in Texas",
                "New Enclosure added: Enclosure2 to zoo in Holliwood",
                "New Enclosure added: Enclosure3 to zoo in Texas",
                "New Enclosure added: Enclosure3 to zoo in Holliwood",
                "New Enclosure added: Enclosure4 to zoo in Texas",
                "New Enclosure added: Enclosure4 to zoo in Holliwood",
                "New Enclosure added: Enclosure5 to zoo in Texas",
                "New Enclosure added: Enclosure5 to zoo in Holliwood",
                "New Enclosure added: Enclosure6 to zoo in Texas",
                "New Enclosure added: Enclosure6 to zoo in Holliwood",
                "New Enclosure added: Enclosure7 to zoo in Texas",
                "New Enclosure added: Enclosure7 to zoo in Holliwood",
                "New Enclosure added: Enclosure8 to zoo in Texas",
                "New Enclosure added: Enclosure8 to zoo in Holliwood",
                "New Enclosure added: Enclosure9 to zoo in Texas",
                "New Enclosure added: Enclosure9 to zoo in Holliwood",
                "New Enclosure added: Enclosure10 to zoo in Texas",
                "New Enclosure added: Enclosure10 to zoo in Holliwood",
                "New Parrot 1 added to enclosure Enclosure1 in zoo Texas",
                "New Penguin 2 added to enclosure Enclosure2 in zoo Texas",
                "New Bison 3 added to enclosure Enclosure3 in zoo Texas",
                "New Elephant 4 added to enclosure Enclosure1 in zoo Texas",
                "New Lion 5 added to enclosure Enclosure4 in zoo Texas",
                "New Snake 6 added to enclosure Enclosure5 in zoo Texas",
                "New Turtle 7 added to enclosure Enclosure1 in zoo Texas",
                "New Parrot 1 added to enclosure Enclosure1 in zoo Holliwood",
                "New Penguin 2 added to enclosure Enclosure2 in zoo Holliwood",
                "New Bison 3 added to enclosure Enclosure3 in zoo Holliwood",
                "New Elephant 4 added to enclosure Enclosure1 in zoo Holliwood",
                "New Lion 5 added to enclosure Enclosure4 in zoo Holliwood",
                "New Snake 6 added to enclosure Enclosure5 in zoo Holliwood",
                "New Turtle 7 added to enclosure Enclosure1 in zoo Holliwood",
                "New Employee added: Ben Gunn in zoo Texas",
                "New Employee added: Jim Hawkins in zoo Texas",
                "New Employee added: John Trelawney in zoo Texas",
                "New Employee added: David Livesey in zoo Texas",
                "New Employee added: Billy Bones in zoo Holliwood",
                "New Employee added: John Silver in zoo Holliwood",
                "New Employee added: David Pew in zoo Holliwood",
                "New Employee added: Job Anderson in zoo Holliwood",
                "The Parrot 1 in zoo Texas was fed by zooKeeper John Trelawney",
                "The Elephant 4 in zoo Texas was fed by zooKeeper David Livesey",
                "The Turtle 7 in zoo Texas was fed by zooKeeper John Trelawney",
                "The Penguin 2 in zoo Texas was fed by zooKeeper David Livesey",
                "The Bison 3 in zoo Texas was fed by zooKeeper John Trelawney",
                "The Lion 5 in zoo Texas was fed by zooKeeper David Livesey",
                "The Snake 6 in zoo Texas was fed by zooKeeper John Trelawney",
                "The Parrot 1 in zoo Texas was healed by Veterinarian Ben Gunn",
                "The Elephant 4 in zoo Texas was healed by Veterinarian Jim Hawkins",
                "The Turtle 7 in zoo Texas was healed by Veterinarian Ben Gunn",
                "The Penguin 2 in zoo Texas was healed by Veterinarian Jim Hawkins",
                "The Bison 3 in zoo Texas was healed by Veterinarian Ben Gunn",
                "The Lion 5 in zoo Texas was healed by Veterinarian Jim Hawkins",
                "The Snake 6 in zoo Texas was healed by Veterinarian Ben Gunn",
                "The Parrot 1 in zoo Holliwood was fed by zooKeeper David Pew",
                "The Elephant 4 in zoo Holliwood was fed by zooKeeper Job Anderson",
                "The Turtle 7 in zoo Holliwood was fed by zooKeeper David Pew",
                "The Penguin 2 in zoo Holliwood was fed by zooKeeper Job Anderson",
                "The Bison 3 in zoo Holliwood was fed by zooKeeper David Pew",
                "The Lion 5 in zoo Holliwood was fed by zooKeeper Job Anderson",
                "The Snake 6 in zoo Holliwood was fed by zooKeeper David Pew",
                "The Parrot 1 in zoo Holliwood was healed by Veterinarian Billy Bones",
                "The Elephant 4 in zoo Holliwood was healed by Veterinarian John Silver",
                "The Turtle 7 in zoo Holliwood was healed by Veterinarian Billy Bones",
                "The Penguin 2 in zoo Holliwood was healed by Veterinarian John Silver",
                "The Bison 3 in zoo Holliwood was healed by Veterinarian Billy Bones",
                "The Lion 5 in zoo Holliwood was healed by Veterinarian John Silver",
                "The Snake 6 in zoo Holliwood was healed by Veterinarian Billy Bones",
            };
            Assert.Equal(expectedOutput.Count, mockConsole.Output.Count);
        }
    }
}

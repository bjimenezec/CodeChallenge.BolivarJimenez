using Challenge.BolivarJimenez.Helpers;

namespace Challenge.BolivarJimenez.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBasicInput()
        {
            //Arrange
            string input = "8 88777444666#";
            string expected = "TURIO";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void TestNoSendKey()
        {
            //Arrange
            string input = "8 88777444666";
            string expected = "TURIO";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestDeleteCharacterWithAsterisk()
        {
            //Arrange
            string input = "8 88777444666*664#";
            string expected = "TURIMG";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestSendKeyWithHash()
        {
            //Arrange
            string input = "8 88777444666*664#";
            string expected = "TURIMG";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestConsecutiveAsterisks()
        {
            //Arrange
            string input = "8 88777444666*664*#";
            string expected = "TURIM";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestEmptyInput()
        {
            //Arrange
            string input = " #";
            string expected = "";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestOnlyAsteriskInput()
        {
            //Arrange
            string input = "*#";
            string expected = "";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestOnlyHashInput()
        {
            //Arrange
            string input = "#";
            string expected = "";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestInvalidCharacters()
        {
            //Arrange
            string input = "8 8877@44666*664#";
            string expected = "TUQHMG";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestMultipleSpacesBetweenDigits()
        {
            //Arrange
            string input = "8   88777444666#";
            string expected = "TURIO";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestValidInput_Sample_01()
        {
            //Arrange
            string input = "33#";
            string expected = "E";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestValidInput_Sample_02()
        {
            //Arrange
            string input = "227*#";            
            string expected = "B";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestValidInput_Sample_03()
        {
            //Arrange
            string input = "4433555 555666#";
            string expected = "HELLO";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestValidInput_Sample_04()
        {
            //Arrange
            string input = "8 88777444666*664#";
            string expected = "TURIMG";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestValidInput_Sample_05()
        {
            //Arrange
            string input = "222 2 22#";
            string expected = "CAB";

            //Act
            string result = Helper.OldPhonePad(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
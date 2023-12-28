namespace ChallengeApp.Test
{
    internal class TypeTests
    {
        [Test]
        public void UsersNotSameLogin()
        {
            //arrange
            var user1 = GetUser("Marta");
            var user2 = GetUser("Łukasz");

            //act

            //assert
            Assert.AreNotEqual(user1, user2);
        }
        [Test]
        public void UsersSameLogin()
        {
            //arrange
            var user1 = GetUser("Marta");
            var user2 = GetUser("Łukasz");

            //act

            //assert
            Assert.That(user2.Login, Is.Not.EqualTo(user1.Login));
        }

        [Test]
        public void UsersNotSameNumbers()
        {
            //arrange
            int number1 = 10;
            int number2 = 20;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void UsersSameNumbers()
        {
            //arrange
            int user1 = 11;
            int user2 = 11;

            //act

            //assert
            Assert.AreEqual(user1, user2);
        }

        private Employee GetUser(string login)
        {
            return new Employee(login);
        }

    }
}

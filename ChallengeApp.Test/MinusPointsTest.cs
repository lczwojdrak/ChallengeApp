using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class Tests2
    {
        [Test]
        public void CollectMinusPoints()
        {
            var user = new Employee("Adam", "asddsa321", 32);
            user.AddScore(5);
            user.AddScore(10);
            user.AddScore(11);
            user.AddScore(22);
            user.AddScore(-20);

            var result = user.Result;

            Assert.AreEqual(28, result);
        }

        [Test]
        public void CollectMinusPoints2()
        {
            var user = new Employee("£ukasz", "asddsa321", 36);
            user.AddScore(5);
            user.AddScore(10);
            user.AddScore(11);
            user.AddScore(22);
            user.AddScore(-25);

            var result = user.Result;

            Assert.AreEqual(25, result);
        }
    }

}
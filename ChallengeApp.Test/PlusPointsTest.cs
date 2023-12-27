using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void CollectPlusPoints()
        {
            var user = new Employee("Adam", "asddsa321", 32);
            user.AddScore(5);
            user.AddScore(10);
            user.AddScore(11);
            user.AddScore(22);

            var result = user.Result;

            Assert.AreEqual(48, result);
        }

        [Test]
        public void CollectPlusPoints2()
        {
            var user = new Employee("£ukasz", "asddsa321", 36);
            user.AddScore(5);
            user.AddScore(10);
            user.AddScore(11);
            user.AddScore(22);

            var result = user.Result;

            Assert.AreEqual(46, result);
        }
    }

}
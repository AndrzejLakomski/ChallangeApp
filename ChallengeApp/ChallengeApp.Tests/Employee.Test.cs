namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectScores_ThenResturnSum()
        {
            //arrange
            var employee = new Employee("Alojzy", " G¹bka", 40);
            employee.AddPoint(5);
            employee.AddPoint(6);
            employee.AddPoint(-12);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void WhenEmployee2CollectScores_ThenResturnSum()
        {
            //arrange
            var employee2 = new Employee("Paulo", "Loczek", 22);
            employee2.AddPoint(5);
            employee2.AddPoint(6);
            employee2.AddPoint(-11);

            //act
            var result = employee2.Result;

            //assert
            Assert.AreEqual(0, result);
        }
    }
}
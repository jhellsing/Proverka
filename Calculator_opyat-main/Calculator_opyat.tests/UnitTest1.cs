namespace Calculator_opyat.tests
{
    public class Tests : Class1
    {
        [Test]
        public void Sum_test()
        {
            Class1 class1 = new Class1();
            first = 3;
            second = 2;
            double xex = 5;
            sum();
            Assert.AreEqual(answ, xex);
        }
        [Test]
        public void Min_test()
        {
            Class1 class1 = new Class1();
            first = 3;
            second = 2;
            double xex = 1;
            min();
            Assert.AreEqual(answ, xex);
        }

        [Test]
        public void Del_test()
        {
            Class1 class1 = new Class1();
            first = 3;
            second = 2;
            double xex = 1.5;
            del();
            Assert.AreEqual(answ, xex);
        }

        [Test]
        public void Umn_test()
        {
            Class1 class1 = new Class1();
            first = 3;
            second = 2;
            double xex = 6;
            umn();
            Assert.AreEqual(answ, xex);
        }

        [Test]
        public void Step_test()
        {
            Class1 class1 = new Class1();
            first = 3;
            second = 2;
            double xex = 9;
            step();
            Assert.AreEqual(answ, xex);
        }

    }
}
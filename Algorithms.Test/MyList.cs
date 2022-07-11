namespace Algorithms.Test
{
    public class MyList
    {
        [Fact(DisplayName = "Should create a list of integers and add one element")]
        public void Test1()
        {
            var list = new MyList<int>();
            list.Add(1);
            Assert.Equal(1, list.Count);
        }

        [Fact(DisplayName = "Should create a list of integers with five elements and return a string of the elements")]
        public void Test2()
        {
            var list = new MyList<int>();
            list.Add(1).Add(2).Add(3).Add(4).Add(5);
            Assert.Equal("1, 2, 3, 4, 5", list.ToString());
        }

        [Fact(DisplayName = "Should create a list of integers and add ten elements")]
        public void Test3()
        {
            //new List<int>().Where
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            Assert.Equal(10, list.Count);
        }

        [Fact(DisplayName = "Should create a list of integers, add five elements and remove one element by index")]
        public void Test4()
        {
            var list = new MyList<int>();
            list.Add(1).Add(2).Add(3).Add(4).Add(5);
            list.RemoveAt(3);
            Assert.Equal("1, 2, 3, 5", list.ToString());
        }

        [Fact(DisplayName = "Should create a list of integers, add five elements and insert one element by index")]
        public void Test5()
        {
            var list = new MyList<int>();
            list.Add(1).Add(2).Add(3).Add(4).Add(5);
            list.Insert(3, 10);
            Assert.Equal("1, 2, 3, 10, 4, 5", list.ToString());
        }

        [Fact(DisplayName = "Should create a list of integers, add five elements and insert one element by index")]
        public void Test6()
        {
            var list = new MyList<int>();
            list.Add(1).Add(2).Add(3).Add(4).Add(5);
            Assert.Equal(4, list.IndexOf(5));
        }

        [Fact(DisplayName = "Should create a list of integers, add five elements and return an element by index")]
        public void Test7()
        {
            var list = new MyList<int>();
            list.Add(1).Add(2).Add(3).Add(4).Add(5);
            Assert.Equal(5, list[4]);
        }
    }
}

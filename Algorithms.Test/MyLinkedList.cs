namespace Algorithms.Test
{
    public  class MyLinkedList
    {
        [Fact(DisplayName = "Should create a list of integers and add the first element")]
        public void Test1()
        {
            //new LinkedList<int>().Add
            var list = new MyLinkedList<int>();
            list.AddFirst(1);
            Assert.Equal(1, list.Count);
        }

        [Fact(DisplayName = "Should create a list of integers with five elements and return a string of the elements")]
        public void Test2()
        {
            var list = new MyLinkedList<int>();
            list.Add(1).Add(2).Add(3).Add(4).Add(5);
            Assert.Equal("1, 2, 3, 4, 5", list.ToString());
        }

        [Fact(DisplayName = "Should create a list of integers and remove the first element")]
        public void Test3()
        {
            //new LinkedList<int>().Add
            var list = new MyLinkedList<int>();
            list.Add(1).Add(2).Add(3).Add(4).Add(5);
            list.RemoveFirst();
            Assert.Equal(4, list.Count);
            Assert.Equal("2, 3, 4, 5", list.ToString());
        }

        [Fact(DisplayName = "Should create a list of integers and remove the last element")]
        public void Test4()
        {
            //new LinkedList<int>().remo
            new List<int>().Where()
            var list = new MyLinkedList<int>();
            list.Add(1).Add(2).Add(3).Add(4).Add(5);
            list.RemoveLast();
            Assert.Equal(4, list.Count);
            Assert.Equal("1, 2, 3, 4", list.ToString());
        }

        [Fact(DisplayName = "Should create a list of integers and remove an especific element")]
        public void Test5()
        {
            var listaTeste = new LinkedList<int>();
            listaTeste.AddLast(1);
            var obj = listaTeste.Single(o => o == 3);
            var list = new MyLinkedList<int>();
            list.Add(1).Add(2).Add(3).Add(4).Add(5);
            list.Remove(list.Single(o => o == 3));
            Assert.Equal(4, list.Count);
            Assert.Equal("1, 2, 3, 4", list.ToString());
        }
    }
}

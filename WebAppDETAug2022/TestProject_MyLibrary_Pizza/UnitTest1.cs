using MyLibrary_Pizza;
using Xunit;

namespace TestProject_MyLibrary_Pizza
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetAllPizzas()
        {
            int expected = 2;
            int actual = PizzaService.GetAll().Count;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_AddPizza()
        {
            Pizza p = new Pizza { Id=5, Name="Corn", Size = PizzaSize.Large, IsGlutenFree=true , Price=455};

            PizzaService.Add(p);
            Pizza verify = PizzaService.Get(5);
            Assert.Equal(3,PizzaService.GetAll().Count);
            Assert.Equal(p.Id,verify.Id);
        }
    }
}
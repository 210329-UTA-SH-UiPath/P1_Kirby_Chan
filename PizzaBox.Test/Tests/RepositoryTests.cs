using System.Collections.Generic;
using PizzaBox.Domain;
using PizzaBox.Domain.Models;
using PizzaBox.Data.Repositories;
using PizzaBox.Domain.Abstractions;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class RepositoryTests
    {
        ICrustRepository crustrepository = Dependencies.CreateCrustRepository();
        ICustomerRepository customerrepository = Dependencies.CreateCustomerRepository();
        IOrderRepository orderrepository = Dependencies.CreateOrderRepository();
        IPizzaRepository pizzarepository = Dependencies.CreatePizzaRepository();
        IPresetPizzaRepository presetpizzarepository = Dependencies.CreatePresetPizzaRepository();
        ISizeRepository sizerepository = Dependencies.CreateSizeRepository();
        IStoreRepository storerepository = Dependencies.CreateStoreRepository();
        IToppingRepository toppingrepository = Dependencies.CreateToppingRepository();

        [Fact]
        public void Test_GetAllStores()
        {
            List<Store> sut = storerepository.GetAllStores();

            int actual = sut.Count;
            Assert.Equal(actual, 6);
        }
        [Fact]
        public void Test_GetStore()
        {
            Store sut = storerepository.GetStoreById(1);

            string actual = "Cool";
            Assert.Equal(actual, sut.Name);
        }
        [Fact]
        public void Test_GetAllPresetPizzas()
        {
            List<PresetPizza> sut = presetpizzarepository.GetAllPresetPizzas();

            int actual = sut.Count;
            Assert.NotNull(actual);
        }
        [Fact]
        public void Test_GetAllCrusts()
        {
            List<Crust> sut = crustrepository.GetAllCrusts();

            int actual = sut.Count;
            Assert.Equal(actual, 4);
        }
        [Fact]
        public void Test_GetAllSizes()
        {
            List<Size> sut = sizerepository.GetAllSizes();

            int actual = sut.Count;
            Assert.Equal(actual, 5);
        }
        [Fact]
        public void Test_GetAllToppings()
        {
            List<Topping> sut = toppingrepository.GetAllToppings();

            int actual = sut.Count;
            Assert.Equal(actual, 9);
        }
        [Fact]
        public void Test_GetCustomerByName()
        {
            Customer sut = customerrepository.GetCustomerByName("Kirby");

            int actual = sut.ID;
            Assert.Equal(actual, 1);
        }
        [Fact]
        public void Test_GetStoreById()
        {
            Store sut = storerepository.GetStoreById(2);
            string actual = sut.Name;

            Assert.Equal(actual, "Mystery");

        }
        [Fact]
        public void Test_GetPresetPizzaById()
        {
            PresetPizza sut = presetpizzarepository.GetPresetPizzaById(2);
            Assert.Equal(sut.Name, "Meaty");
        }
        [Fact]
        public void Test_GetCrustById()
        {
            Crust sut = crustrepository.GetCrustById(3);
            string actual = sut.Name;

            Assert.Equal(actual, "Cheese");
        }
        [Fact]
        public void Test_GetSizeById()
        {
            List<Size> sut = sizerepository.GetAllSizes();

            Assert.NotNull(sut);
        }
        [Fact]
        public void Test_GetToppingById()
        {
            Topping sut = toppingrepository.GetToppingById(3);
            int actual = sut.ID;

            Assert.Equal(actual, 3);
        }
    }
}
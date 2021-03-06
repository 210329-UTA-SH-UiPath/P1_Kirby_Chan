using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PizzaBox.Client.Models;

namespace PizzaBox.Client
{
    public class MenuClient
    {
        string url = "https://localhost:44373/api/";
        public IEnumerable<Store> GetAllStores()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url+"store/");
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result;// this holds the output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Store[]>();
                readTask.Wait();

                var stores = readTask.Result;
                return stores;
            }
            else
                return null;
        }
        public IEnumerable<PresetPizza> GetAllPresetPizzas()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url+"presetpizza/");
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result;// this holds the output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<PresetPizza[]>();
                readTask.Wait();

                var presetPizzas = readTask.Result;
                return presetPizzas;
            }
            else
                return null;
        }
        public IEnumerable<Crust> GetAllCrusts()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url+"crust/");
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result;// this holds the output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Crust[]>();
                readTask.Wait();

                var crusts = readTask.Result;
                return crusts;
            }
            else
                return null;
        }
        public IEnumerable<Size> GetAllSizes()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url+"size/");
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result;// this holds the output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Size[]>();
                readTask.Wait();

                var sizes = readTask.Result;
                return sizes;
            }
            else
                return null;
        }
        public IEnumerable<Topping> GetAllToppings()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url+"topping/");
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result;// this holds the output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Topping[]>();
                readTask.Wait();

                var toppings = readTask.Result;
                return toppings;
            }
            else
                return null;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBox.Client.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace PizzaBox.Client
{
    public class OrderClient : Controller
    {

        string url = "https://localhost:44373/api/";
        public Customer GetCustomerByName(string name)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url + "customer/" + name);
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result;// this holds the output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Customer>();
                readTask.Wait();

                var customer = readTask.Result;
                return customer;
            }
            else
                return null;
        }

        public async void AddOrder(Order order)
        {
            var json = JsonConvert.SerializeObject(order);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            var response = await client.PostAsync(url + "Order/", data);
            var result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }

        public async void AddPizza(Pizza pizza)
        {
            var json = JsonConvert.SerializeObject(pizza);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            var response = await client.PostAsync(url + "Pizza/", data);
            var result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }

        public IEnumerable<Order> GetOrdersByCustomerId(int id)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url + "Order/customer/" + id);
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result;

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Order[]>();
                readTask.Wait();

                var orders = readTask.Result;
                return orders;
            }
            return null;
        }
    }
}

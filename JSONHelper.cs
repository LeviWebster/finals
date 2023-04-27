using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace finals
{

    internal class JSONHelper
    {
        //creating HttpClient
        static readonly HttpClient client = new HttpClient();

        //creating a function that grabs data for a Star Wars planet based on user inputted IDs
       public static async Task <Planet> GetPlanet(int ID)
        {
           Planet myDeserializedClass = new Planet();
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                using HttpResponseMessage response = await client.GetAsync("http://swapi.dev/api/planets/" +ID+ "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                myDeserializedClass = JsonConvert.DeserializeObject<Planet> (responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return myDeserializedClass;
        }

        //creating a function that grabs data for a Star Wars character based on user inputted IDs
        public static async Task<Person> GetPerson(int ID)
        {
            Person  myDeserializedClass = new Person();
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                using HttpResponseMessage response = await client.GetAsync("http://swapi.dev/api/people/" +ID+ "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                myDeserializedClass = JsonConvert.DeserializeObject<Person>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return myDeserializedClass;
        }

        //ceating a method that grabs a list of all the species that later gets put into a loop of 
        //different species objects
        public static async Task<AllSpecies> GetAllSpecies()
        {
            AllSpecies CompleteSpecies = new AllSpecies();
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                using HttpResponseMessage response = await client.GetAsync("http://swapi.dev/api/species");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                CompleteSpecies = JsonConvert.DeserializeObject<AllSpecies>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return CompleteSpecies;
        }

        //creating a function that grabs data for a Star Wars Starship based on user inputted IDs
        //the API has many blank IDs, so this function is liable to the error from the other side
        public static async Task<Starships> GetStarship(int ID)
        {
            Starships myDeserializedClass = new Starships();
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                using HttpResponseMessage response = await client.GetAsync("http://swapi.dev/api/starships/" +ID+ "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                myDeserializedClass = JsonConvert.DeserializeObject<Starships>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return myDeserializedClass;
        }
    }
}

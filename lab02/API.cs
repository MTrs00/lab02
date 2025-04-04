using lab02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("GUI")]

namespace lab02
{
    public class APITest
    {
        public HttpClient client;
        private peopleInSpace people;
        public async Task getData()
        {
            client = new HttpClient();
            //string call = " http://api.open-notify.org/iss-now.json ";
            string call = " http://api.open-notify.org/astros.json ";
            string response = await client.GetStringAsync(call);
            people = JsonSerializer.Deserialize<peopleInSpace>(response);
            Console.WriteLine(people.ToString());

        }

        public peopleInSpace ReturnPeopleInSpace()
        {
            return people;
        }
    }
}

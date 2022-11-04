using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DateTime
{
    public class Api
    {
        public static async Task LerApiAsync()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://timeapi.io/api/Time/current/zone?timeZone=America/Sao_Paulo");
            var content = await response.Content.ReadAsStringAsync();

            // Console.WriteLine(content);
            var teste = JsonConvert.DeserializeObject<DataHora>(content);
            Console.WriteLine(teste.Month.ToString() + " " + teste.Time.ToString());
            SetDateTime.Set(teste.Year, teste.Month, teste.Day, teste.Hour, teste.Minute, teste.Seconds);

        }
    }

    public partial class DataHora
    {
        public long Year { get; set; }
        public long Month { get; set; }
        public long Day { get; set; }
        public long Hour { get; set; }
        public long Minute { get; set; }
        public long Seconds { get; set; }
        public long MilliSeconds { get; set; }
        public DateTimeOffset DateTimeDateTime { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
        public string? TimeZone { get; set; }
        public string? DayOfWeek { get; set; }
        public bool DstActive { get; set; }


    }
}

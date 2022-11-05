using Newtonsoft.Json;

namespace DateTime
{
    public class Api
    {
        public static async Task LerApiAsync()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://timeapi.io/api/Time/current/zone?timeZone=America/Sao_Paulo");
            var content = await response.Content.ReadAsStringAsync();

            DataHora? dataHora = JsonConvert.DeserializeObject<DataHora>(content);
            SetDateTime.Set(dataHora.Year, dataHora.Month, dataHora.Day, dataHora.Hour, dataHora.Minute, dataHora.Seconds);
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

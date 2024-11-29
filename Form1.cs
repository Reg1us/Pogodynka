using Newtonsoft.Json;

namespace WeatherApp4GH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //stwórz nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //œci¹gnij dane z serwera
            //u¿ywamy .Result wiêc program poczeka w tym miejscu na odpowiedŸ serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //przeczytaj faktyczn¹ treœæ odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wyœwietl json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuj json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wyœwietl temperaturê w polu tekstowym
            temperatureTextBox.Text = apiResponse.current.temperature_2m.ToString();
            //dodaj spacjê
            temperatureTextBox.Text += " ";
            //dopisz jednostki
            temperatureTextBox.Text += apiResponse.current_units.temperature_2m;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //stwórz nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //œci¹gnij dane z serwera
            //u¿ywamy .Result wiêc program poczeka w tym miejscu na odpowiedŸ serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //przeczytaj faktyczn¹ treœæ odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wyœwietl json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuj json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wyœwietl wilgotnoœæ w polu tekstowym
            textBox1.Text = apiResponse.current.relative_humidity_2m.ToString();
            //dodaj spacjê
            textBox1.Text += " ";
            //dopisz jednostki
            textBox1.Text += apiResponse.current_units.relative_humidity_2m;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //stwórz nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //œci¹gnij dane z serwera
            //u¿ywamy .Result wiêc program poczeka w tym miejscu na odpowiedŸ serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //przeczytaj faktyczn¹ treœæ odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wyœwietl json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuj json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wyœwietl kod pogody w polu tekstowym
            textBox2.Text = GetWeatherDescription(apiResponse.current.weather_code);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //stwórz nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //œci¹gnij dane z serwera
            //u¿ywamy .Result wiêc program poczeka w tym miejscu na odpowiedŸ serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //przeczytaj faktyczn¹ treœæ odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wyœwietl json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuj json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wyœwietl prêdkoœæ wiatru w polu tekstowym
            textBox3.Text = apiResponse.current.wind_speed_10m.ToString();
            //dodaj spacjê
            textBox3.Text += " ";
            //dopisz jednostki
            textBox3.Text += apiResponse.current_units.wind_speed_10m;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //stwórz nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //œci¹gnij dane z serwera
            //u¿ywamy .Result wiêc program poczeka w tym miejscu na odpowiedŸ serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //przeczytaj faktyczn¹ treœæ odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wyœwietl json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuj json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wyœwietl kierunek wiatru w polu tekstowym
            textBox4.Text = GetWindDirectionDescription(apiResponse.current.wind_direction_10m);
        }

        private string GetWeatherDescription(int weatherCode)
        {
            return weatherCode switch
            {
                0 => "Pogodnie",
                1 => "G³ównie pogodnie",
                2 => "Czêœciowo pochmurno",
                3 => "Pochmurno",
                45 => "Mg³a",
                48 => "Mg³a osadzaj¹ca szadŸ",
                51 => "M¿awka: lekka",
                53 => "M¿awka: umiarkowana",
                55 => "M¿awka: gêsta",
                56 => "M¿awka: lekka, marzn¹ca",
                57 => "M¿awka: gêsta, marzn¹ca",
                61 => "Deszcz: lekki",
                63 => "Deszcz: umiarkowany",
                65 => "Deszcz: intensywny",
                66 => "Deszcz: lekki, marzn¹cy",
                67 => "Deszcz: intensywny, marzn¹cy",
                71 => "Œnieg: lekki",
                73 => "Œnieg: umiarkowany",
                75 => "Œnieg: intensywny",
                77 => "Œnieg ziarnisty",
                80 => "Przelotne opady deszczu: lekkie",
                81 => "Przelotne opady deszczu: umiarkowane",
                82 => "Przelotne opady deszczu: intensywne",
                85 => "Przelotne opady œniegu: lekkie",
                86 => "Przelotne opady œniegu: intensywne",
                95 => "Burza: lekka lub umiarkowana",
                96 => "Burza z gradem: lekka",
                99 => "Burza z gradem: intensywna",
                _ => "Nieznany kod pogodowy"
            };
        }

        private string GetWindDirectionDescription(int windDirection)
        {
            int roundedDirection = (int)Math.Round(windDirection / 90.0) * 90;
            return roundedDirection switch
            {
                0 => "Pó³noc",
                90 => "Wschód",
                180 => "Po³udnie",
                270 => "Zachód",
                360 => "Pó³noc",
                _ => "Nieznany kierunek"
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

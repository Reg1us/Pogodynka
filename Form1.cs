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
            //stw�rz nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //�ci�gnij dane z serwera
            //u�ywamy .Result wi�c program poczeka w tym miejscu na odpowied� serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //przeczytaj faktyczn� tre�� odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wy�wietl json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuj json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wy�wietl temperatur� w polu tekstowym
            temperatureTextBox.Text = apiResponse.current.temperature_2m.ToString();
            //dodaj spacj�
            temperatureTextBox.Text += " ";
            //dopisz jednostki
            temperatureTextBox.Text += apiResponse.current_units.temperature_2m;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //stw�rz nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //�ci�gnij dane z serwera
            //u�ywamy .Result wi�c program poczeka w tym miejscu na odpowied� serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //przeczytaj faktyczn� tre�� odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wy�wietl json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuj json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wy�wietl wilgotno�� w polu tekstowym
            textBox1.Text = apiResponse.current.relative_humidity_2m.ToString();
            //dodaj spacj�
            textBox1.Text += " ";
            //dopisz jednostki
            textBox1.Text += apiResponse.current_units.relative_humidity_2m;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //stw�rz nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //�ci�gnij dane z serwera
            //u�ywamy .Result wi�c program poczeka w tym miejscu na odpowied� serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //przeczytaj faktyczn� tre�� odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wy�wietl json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuj json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wy�wietl kod pogody w polu tekstowym
            textBox2.Text = GetWeatherDescription(apiResponse.current.weather_code);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //stw�rz nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //�ci�gnij dane z serwera
            //u�ywamy .Result wi�c program poczeka w tym miejscu na odpowied� serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //przeczytaj faktyczn� tre�� odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wy�wietl json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuj json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wy�wietl pr�dko�� wiatru w polu tekstowym
            textBox3.Text = apiResponse.current.wind_speed_10m.ToString();
            //dodaj spacj�
            textBox3.Text += " ";
            //dopisz jednostki
            textBox3.Text += apiResponse.current_units.wind_speed_10m;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //stw�rz nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //�ci�gnij dane z serwera
            //u�ywamy .Result wi�c program poczeka w tym miejscu na odpowied� serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //przeczytaj faktyczn� tre�� odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wy�wietl json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuj json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wy�wietl kierunek wiatru w polu tekstowym
            textBox4.Text = GetWindDirectionDescription(apiResponse.current.wind_direction_10m);
        }

        private string GetWeatherDescription(int weatherCode)
        {
            return weatherCode switch
            {
                0 => "Pogodnie",
                1 => "G��wnie pogodnie",
                2 => "Cz�ciowo pochmurno",
                3 => "Pochmurno",
                45 => "Mg�a",
                48 => "Mg�a osadzaj�ca szad�",
                51 => "M�awka: lekka",
                53 => "M�awka: umiarkowana",
                55 => "M�awka: g�sta",
                56 => "M�awka: lekka, marzn�ca",
                57 => "M�awka: g�sta, marzn�ca",
                61 => "Deszcz: lekki",
                63 => "Deszcz: umiarkowany",
                65 => "Deszcz: intensywny",
                66 => "Deszcz: lekki, marzn�cy",
                67 => "Deszcz: intensywny, marzn�cy",
                71 => "�nieg: lekki",
                73 => "�nieg: umiarkowany",
                75 => "�nieg: intensywny",
                77 => "�nieg ziarnisty",
                80 => "Przelotne opady deszczu: lekkie",
                81 => "Przelotne opady deszczu: umiarkowane",
                82 => "Przelotne opady deszczu: intensywne",
                85 => "Przelotne opady �niegu: lekkie",
                86 => "Przelotne opady �niegu: intensywne",
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
                0 => "P�noc",
                90 => "Wsch�d",
                180 => "Po�udnie",
                270 => "Zach�d",
                360 => "P�noc",
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

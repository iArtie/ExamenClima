using Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Infraestructure.Transparencia;
using Infraestructure.OpenWeatherClient;
using Common;
using System.IO;

namespace WeadelClimaxd
{
    public partial class FrmClima : Form
    {
        public WeatherMain.ForeCastInfo wfc2;
        public OpenWeatherClient opw;
        public double x, y;
        public static string filename = "laweaclima.json", filename2 = "Current.json";
        string owajson, owajson2;
        long dt;
        //long dt = DateTimeOffset.Now.ToUnixTimeSeconds();
        public FrmClima()
        {
            opw = new OpenWeatherClient();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //BackColor = Color.Azure;
            
            //TransparencyKey = Color.Azure;
            InitializeComponent();

        }
        public Stream DataStream
        {
            get => File.Open($"{filename}.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }

        string APIKey = "498e4fc3fddeb027b3363fcfc0b77921";
        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            flpContent.Hide();
            wfc2 = null;
            flpContent.Controls.Clear();
            
            try
            {
                getWeather();
                flpContent.Show();
                txtClima.Text = String.Empty;
                //using (FileStream fileStream = new FileStream(filename, FileMode.Append, FileAccess.Write))
                //{
                //    binaryWriter = new BinaryWriter(fileStream);
                //    binaryWriter.Write(id);
                //    binaryWriter.Write(t.Nombre);
                //    binaryWriter.Write(t.Valor);
                //    binaryWriter.Write(t.VidaUtil);
                //    binaryWriter.Write(t.ValorResidual);
                //    binaryWriter.Write(t.Descripcion);
                //    binaryWriter.Write(t.Codigo);
                //    binaryWriter.Write(t.Estado);

                //}
                //File.WriteAllText
                //using (FileStream fs = File.Create(filename))
                //{
                //   fs.Write(owajson);
                //    // Add some information to the file.
                //    //fs.Write(info, 0, info.Length);
                //}
                //System.IO.FileStream Create(string filename);

            }
            catch
            {
                flpContent.Show();
                if (txtClima.Text == String.Empty)
                {
                    MessageBox.Show("Escriba una ciudad");
                }else if (labelWn.Text == "N/A" )
                {
                    MessageBox.Show("No se pudo encontrar la ciudad");
                    txtClima.Text = String.Empty;
                }
                
                
            }
        }

        public static string GetClimaJsonFromFile()
        {
            string climaJsonFromFile;
            using (var reader = new StreamReader(filename))
                climaJsonFromFile = reader.ReadToEnd();
            return climaJsonFromFile;
        }
        public static string GetClimaJsonFromFile2()
        {
            string climaJsonFromFile;
            using (var reader = new StreamReader(filename2))
                climaJsonFromFile = reader.ReadToEnd();
            return climaJsonFromFile;
        }
        public void getWeatherFromJson()
        {
            root Info = JsonConvert.DeserializeObject<root>(GetClimaJsonFromFile2());
            string sunset = ConvertDateTime(Info.sys.sunset).ToShortTimeString();
            string sunrise = ConvertDateTime(Info.sys.sunrise).ToShortTimeString();
            double temp = Info.main.temp;
            double unu = temp - 273.15;
            unu = (int)unu;
            picWeather.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
            labelCd.Text = Info.weather[0].main;
            laberDt.Text = Info.weather[0].description;
            labelSun.Text = sunset.ToString();
            labelSn.Text = sunrise.ToString();
            labelWn.Text = Info.wind.speed.ToString();
            labelPress.Text = Info.main.pressure.ToString();
            labelTemp.Text = unu.ToString() + "°";
            x = Info.coord.lat;
            y = Info.coord.lon;
            dt = Info.dt;
            WeatherMain.ForeCastInfo wJson = JsonConvert.DeserializeObject<WeatherMain.ForeCastInfo>(GetClimaJsonFromFile());
            InfoDetail mini;
            for (int i = 0; i < 9; i++)
            {
                double tempxd;
                int tempint;
                string hoursstring;
                tempxd = wJson.hourly[i].temp - 273.15;
                hoursstring = ConvertDateTime(wJson.hourly[i].dt).ToShortTimeString();
                tempint = (int)tempxd;
                mini = new InfoDetail();
                mini.lblHours.Text = hoursstring;
                mini.lblCondi.Text = wJson.hourly[i].weather[0].main;
                mini.lblDetails.Text = wJson.hourly[i].weather[0].description;
                mini.lblWin.Text = wJson.hourly[i].wind_speed.ToString();
                mini.lblPress.Text = wJson.hourly[i].pressure.ToString();
                mini.lblTemp.Text = tempint.ToString() + "°";
                mini.picWeather.ImageLocation = $"{AppSettings.ApiIcon}" + wJson.hourly[i].weather[0].icon + ".png";
                flpContent.Controls.Add(mini);
            }
        }
        public class WindowExtension
        {
            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
          
            

       

        }
        public void getWeather()
        {
            try
            {
                using (WebClient web = new WebClient())
                {

                    string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtClima.Text, APIKey);
                    var json = web.DownloadString(url);
                   
                    root Info = JsonConvert.DeserializeObject<root>(json);
                    string sunset = ConvertDateTime(Info.sys.sunset).ToShortTimeString();
                    string sunrise = ConvertDateTime(Info.sys.sunrise).ToShortTimeString();
                    double temp = Info.main.temp;
                    double unu = temp - 273.15;
                    unu = (int)unu;
                    picWeather.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    labelCd.Text = Info.weather[0].main;
                    laberDt.Text = Info.weather[0].description;
                    labelSun.Text = sunset.ToString();
                    labelSn.Text = sunrise.ToString();
                    labelWn.Text = Info.wind.speed.ToString();
                    labelPress.Text = Info.main.pressure.ToString();
                    labelTemp.Text = unu.ToString() + "°";
                    x = Info.coord.lat;
                    y = Info.coord.lon;
                    dt = Info.dt;
                    owajson2 = JsonConvert.SerializeObject(Info,Formatting.Indented);
                    File.WriteAllText(filename2, owajson2);
                    //StreamWriter guardado = new StreamWriter();
                    //foreach (object linea in owajson)
                    //{
                    //    guardado.WriteLine(linea);
                    //}
                    //guardado.Close();
                }
                
                Task.Run(Request).Wait();
                InfoDetail mini;
                for (int i = 0; i < 9; i++)
                {
                    double temp;
                    int tempint;
                    string hoursstring;
                    temp = wfc2.hourly[i].temp - 273.15;
                    hoursstring = ConvertDateTime(wfc2.hourly[i].dt).ToShortTimeString();
                    tempint = (int)temp;
                    mini = new InfoDetail();
                    mini.lblHours.Text = hoursstring;
                    mini.lblCondi.Text = wfc2.hourly[i].weather[0].main;
                    mini.lblDetails.Text = wfc2.hourly[i].weather[0].description;
                    mini.lblWin.Text = wfc2.hourly[i].wind_speed.ToString();
                    mini.lblPress.Text = wfc2.hourly[i].pressure.ToString();
                    mini.lblTemp.Text = tempint.ToString() + "°";
                    mini.picWeather.ImageLocation = $"{AppSettings.ApiIcon}" + wfc2.hourly[i].weather[0].icon + ".png";
                    flpContent.Controls.Add(mini);
                }
                owajson = JsonConvert.SerializeObject(wfc2, Formatting.Indented);
                File.WriteAllText(filename, owajson);
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("No se pudo encontrar la ciudad");
            }
        }

       
            private void FrmClima_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void TxtClima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                BtnBuscar_Click(sender,e);
            }
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puede agregar numeros");
            }
        }
        DateTime ConvertDateTime(long Milisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();

            day = day.AddSeconds(Milisec).ToLocalTime();

            return day;
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public async Task Request()
        {
            wfc2 = await opw.GetWeatherByGeo(x, y, dt);
        }
        private void FrmClima_Load(object sender, EventArgs e)
        {

            (new LayeredWindowHelper(this)).BackColor = Color.FromArgb(128, Win7Style.GetThemeColor());
            getWeatherFromJson();


            Win7Style.EnableBlurBehindWindow(this.Handle);
            Win10Style.EnableBlur(this.Handle);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
          private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
                                      
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtClima_Enter(object sender, EventArgs e)
        {
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }

      

    }



using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace CurrencyConverter
{
    public partial class MainWindow : Window
    {
        int fromVal = 0;
        int toVal = 0;

        public MainWindow()
        {
            InitializeComponent();
            GetValue();
        }

        Root val = new Root();

        public class Root
        {
            public Rate rates { get; set; }
            public long timestamp;
            public string license;
        }

        public class Rate
        {
            public double AED { get; set; }
            public double AFN { get; set; }
            public double ALL { get; set; }
            public double AMD { get; set; }
            public double ANG { get; set; }
            public double AOA { get; set; }
            public double ARS { get; set; }
            public double AUD { get; set; }
            public double AWG { get; set; }
            public double AZN { get; set; }
            public double BAM { get; set; }
            public double BBD { get; set; }
            public double BDT { get; set; }
            public double BGN { get; set; }
            public double BHD { get; set; }
            public double BIF { get; set; }
            public double BMD { get; set; }
            public double BND { get; set; }
            public double BOB { get; set; }
            public double BRL { get; set; }
            public double BSD { get; set; }
            public double BTC { get; set; }
            public double BTN { get; set; }
            public double BWP { get; set; }
            public double BYN { get; set; }
            public double BYR { get; set; }
            public double BZD { get; set; }
            public double CAD { get; set; }
            public double CDF { get; set; }
            public double CHF { get; set; }
            public double CLF { get; set; }
            public double CLP { get; set; }
            public double CNH { get; set; }
            public double CNY { get; set; }
            public double COP { get; set; }
            public double CRC { get; set; }
            public double CUC { get; set; }
            public double CUP { get; set; }
            public double CVE { get; set; }
            public double CZK { get; set; }
            public double DJF { get; set; }
            public double DKK { get; set; }
            public double DOP { get; set; }
            public double DZD { get; set; }
            public double EEK { get; set; }
            public double EGP { get; set; }
            public double ERN { get; set; }
            public double ETB { get; set; }
            public double EUR { get; set; }
            public double FJD { get; set; }
            public double FKP { get; set; }
            public double GBP { get; set; }
            public double GEL { get; set; }
            public double GGP { get; set; }
            public double GHS { get; set; }
            public double GIP { get; set; }
            public double GMD { get; set; }
            public double GNF { get; set; }
            public double GTQ { get; set; }
            public double GYD { get; set; }
            public double HKD { get; set; }
            public double HNL { get; set; }
            public double HRK { get; set; }
            public double HTG { get; set; }
            public double HUF { get; set; }
            public double IDR { get; set; }
            public double ILS { get; set; }
            public double IMP { get; set; }
            public double INR { get; set; }
            public double IQD { get; set; }
            public double IRR { get; set; }
            public double ISK { get; set; }
            public double JEP { get; set; }
            public double JMD { get; set; }
            public double JOD { get; set; }
            public double JPY { get; set; }
            public double KES { get; set; }
            public double KGS { get; set; }
            public double KHR { get; set; }
            public double KMF { get; set; }
            public double KPW { get; set; }
            public double KRW { get; set; }
            public double KWD { get; set; }
            public double KYD { get; set; }
            public double KZT { get; set; }
            public double LAK { get; set; }
            public double LBP { get; set; }
            public double LKR { get; set; }
            public double LRD { get; set; }
            public double LSL { get; set; }
            public double LYD { get; set; }
            public double MAD { get; set; }
            public double MDL { get; set; }
            public double MGA { get; set; }
            public double MKD { get; set; }
            public double MMK { get; set; }
            public double MNT { get; set; }
            public double MOP { get; set; }
            public double MRO { get; set; }
            public double MRU { get; set; }
            public double MTL { get; set; }
            public double MUR { get; set; }
            public double MVR { get; set; }
            public double MWK { get; set; }
            public double MXN { get; set; }
            public double MYR { get; set; }
            public double MZN { get; set; }
            public double NAD { get; set; }
            public double NGN { get; set; }
            public double NIO { get; set; }
            public double NOK { get; set; }
            public double NPR { get; set; }
            public double NZD { get; set; }
            public double OMR { get; set; }
            public double PAB { get; set; }
            public double PEN { get; set; }
            public double PGK { get; set; }
            public double PHP { get; set; }
            public double PKR { get; set; }
            public double PLN { get; set; }
            public double PYG { get; set; }
            public double QAR { get; set; }
            public double RON { get; set; }
            public double RSD { get; set; }
            public double RUB { get; set; }
            public double RWF { get; set; }
            public double SAR { get; set; }
            public double SBD { get; set; }
            public double SCR { get; set; }
            public double SDG { get; set; }
            public double SEK { get; set; }
            public double SGD { get; set; }
            public double SHP { get; set; }
            public double SLL { get; set; }
            public double SOS { get; set; }
            public double SRD { get; set; }
            public double SSP { get; set; }
            public double STD { get; set; }
            public double STN { get; set; }
            public double SVC { get; set; }
            public double SYP { get; set; }
            public double SZL { get; set; }
            public double THB { get; set; }
            public double TJS { get; set; }
            public double TMT { get; set; }
            public double TND { get; set; }
            public double TOP { get; set; }
            public double TRY { get; set; }
            public double TTD { get; set; }
            public double TWD { get; set; }
            public double TZS { get; set; }
            public double UAH { get; set; }
            public double UGX { get; set; }
            public double USD { get; set; }
            public double UYU { get; set; }
            public double UZS { get; set; }
            public double VES { get; set; }
            public double VND { get; set; }
            public double VUV { get; set; }
            public double WST { get; set; }
            public double XAF { get; set; }
            public double XAG { get; set; }
            public double XAU { get; set; }
            public double XCD { get; set; }
            public double XDR { get; set; }
            public double XOF { get; set; }
            public double XPD { get; set; }
            public double XPF { get; set; }
            public double XPT { get; set; }
            public double YER { get; set; }
            public double ZAR { get; set; }
            public double ZMK { get; set; }
            public double ZMW { get; set; }
        }

        public static async Task<Root> GetData<T>(string url)
        {
            var myRoot = new Root();
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMinutes(1);
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var ResponseString = await response.Content.ReadAsStringAsync();
                        var ResponseObject = JsonConvert.DeserializeObject<Root>(ResponseString);

                        //MessageBox.Show("Timestamp: " + ResponseObject.timestamp, "Info: ", MessageBoxButton.OK, MessageBoxImage.Information);

                        return ResponseObject;
                    }
                }

                return myRoot;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return myRoot;
            }
        }

        private async void GetValue()
        {
            val = await GetData<Root>("https://openexchangerates.org/api/latest.json?app_id=58224db5b7b74ab8a5f04580474a797a");
            BindCurrency(); 
        }

        private void BindCurrency()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Text");
            dt.Columns.Add("Value");

            {
                dt.Rows.Add("--SELECT--", 0);
                dt.Rows.Add("AED", val.rates.AED);
                dt.Rows.Add("AFN", val.rates.AFN);
                dt.Rows.Add("ALL", val.rates.ALL);
                dt.Rows.Add("AMD", val.rates.AMD);
                dt.Rows.Add("ANG", val.rates.ANG);
                dt.Rows.Add("AOA", val.rates.AOA);
                dt.Rows.Add("ARS", val.rates.ARS);
                dt.Rows.Add("AUD", val.rates.AUD);
                dt.Rows.Add("AWG", val.rates.AWG);
                dt.Rows.Add("AZN", val.rates.AZN);
                dt.Rows.Add("BAM", val.rates.BAM);
                dt.Rows.Add("BBD", val.rates.BBD);
                dt.Rows.Add("BDT", val.rates.BDT);
                dt.Rows.Add("BGN", val.rates.BGN);
                dt.Rows.Add("BHD", val.rates.BHD);
                dt.Rows.Add("BIF", val.rates.BIF);
                dt.Rows.Add("BMD", val.rates.BMD);
                dt.Rows.Add("BND", val.rates.BND);
                dt.Rows.Add("BOB", val.rates.BOB);
                dt.Rows.Add("BRL", val.rates.BRL);
                dt.Rows.Add("BSD", val.rates.BSD);
                dt.Rows.Add("BTC", val.rates.BTC);
                dt.Rows.Add("BTN", val.rates.BTN);
                dt.Rows.Add("BWP", val.rates.BWP);
                dt.Rows.Add("BYN", val.rates.BYN);
                dt.Rows.Add("BYR", val.rates.BYR);
                dt.Rows.Add("BZD", val.rates.BZD);
                dt.Rows.Add("CAD", val.rates.CAD);
                dt.Rows.Add("CDF", val.rates.CDF);
                dt.Rows.Add("CHF", val.rates.CHF);
                dt.Rows.Add("CLF", val.rates.CLF);
                dt.Rows.Add("CLP", val.rates.CLP);
                dt.Rows.Add("CNH", val.rates.CNH);
                dt.Rows.Add("CNY", val.rates.CNY);
                dt.Rows.Add("COP", val.rates.COP);
                dt.Rows.Add("CRC", val.rates.CRC);
                dt.Rows.Add("CUC", val.rates.CUC);
                dt.Rows.Add("CUP", val.rates.CUP);
                dt.Rows.Add("CVE", val.rates.CVE);
                dt.Rows.Add("CZK", val.rates.CZK);
                dt.Rows.Add("DJF", val.rates.DJF);
                dt.Rows.Add("DKK", val.rates.DKK);
                dt.Rows.Add("DOP", val.rates.DOP);
                dt.Rows.Add("DZD", val.rates.DZD);
                dt.Rows.Add("EEK", val.rates.EEK);
                dt.Rows.Add("EGP", val.rates.EGP);
                dt.Rows.Add("ERN", val.rates.ERN);
                dt.Rows.Add("ETB", val.rates.ETB);
                dt.Rows.Add("EUR", val.rates.EUR);
                dt.Rows.Add("FJD", val.rates.FJD);
                dt.Rows.Add("FKP", val.rates.FKP);
                dt.Rows.Add("GBP", val.rates.GBP);
                dt.Rows.Add("GEL", val.rates.GEL);
                dt.Rows.Add("GGP", val.rates.GGP);
                dt.Rows.Add("GHS", val.rates.GHS);
                dt.Rows.Add("GIP", val.rates.GIP);
                dt.Rows.Add("GMD", val.rates.GMD);
                dt.Rows.Add("GNF", val.rates.GNF);
                dt.Rows.Add("GTQ", val.rates.GTQ);
                dt.Rows.Add("GYD", val.rates.GYD);
                dt.Rows.Add("HKD", val.rates.HKD);
                dt.Rows.Add("HNL", val.rates.HNL);
                dt.Rows.Add("HRK", val.rates.HRK);
                dt.Rows.Add("HTG", val.rates.HTG);
                dt.Rows.Add("HUF", val.rates.HUF);
                dt.Rows.Add("IDR", val.rates.IDR);
                dt.Rows.Add("ILS", val.rates.ILS);
                dt.Rows.Add("IMP", val.rates.IMP);
                dt.Rows.Add("INR", val.rates.INR);
                dt.Rows.Add("IQD", val.rates.IQD);
                dt.Rows.Add("IRR", val.rates.IRR);
                dt.Rows.Add("ISK", val.rates.ISK);
                dt.Rows.Add("JEP", val.rates.JEP);
                dt.Rows.Add("JMD", val.rates.JMD);
                dt.Rows.Add("JOD", val.rates.JOD);
                dt.Rows.Add("JPY", val.rates.JPY);
                dt.Rows.Add("KES", val.rates.KES);
                dt.Rows.Add("KGS", val.rates.KGS);
                dt.Rows.Add("KHR", val.rates.KHR);
                dt.Rows.Add("KMF", val.rates.KMF);
                dt.Rows.Add("KPW", val.rates.KPW);
                dt.Rows.Add("KRW", val.rates.KRW);
                dt.Rows.Add("KWD", val.rates.KWD);
                dt.Rows.Add("KYD", val.rates.KYD);
                dt.Rows.Add("KZT", val.rates.KZT);
                dt.Rows.Add("LAK", val.rates.LAK);
                dt.Rows.Add("LBP", val.rates.LBP);
                dt.Rows.Add("LKR", val.rates.LKR);
                dt.Rows.Add("LRD", val.rates.LRD);
                dt.Rows.Add("LSL", val.rates.LSL);
                dt.Rows.Add("LYD", val.rates.LYD);
                dt.Rows.Add("MAD", val.rates.MAD);
                dt.Rows.Add("MDL", val.rates.MDL);
                dt.Rows.Add("MGA", val.rates.MGA);
                dt.Rows.Add("MKD", val.rates.MKD);
                dt.Rows.Add("MMK", val.rates.MMK);
                dt.Rows.Add("MNT", val.rates.MNT);
                dt.Rows.Add("MOP", val.rates.MOP);
                dt.Rows.Add("MRO", val.rates.MRO);
                dt.Rows.Add("MRU", val.rates.MRU);
                dt.Rows.Add("MTL", val.rates.MTL);
                dt.Rows.Add("MUR", val.rates.MUR);
                dt.Rows.Add("MVR", val.rates.MVR);
                dt.Rows.Add("MWK", val.rates.MWK);
                dt.Rows.Add("MXN", val.rates.MXN);
                dt.Rows.Add("MYR", val.rates.MYR);
                dt.Rows.Add("MZN", val.rates.MZN);
                dt.Rows.Add("NAD", val.rates.NAD);
                dt.Rows.Add("NGN", val.rates.NGN);
                dt.Rows.Add("NIO", val.rates.NIO);
                dt.Rows.Add("NOK", val.rates.NOK);
                dt.Rows.Add("NPR", val.rates.NPR);
                dt.Rows.Add("NZD", val.rates.NZD);
                dt.Rows.Add("OMR", val.rates.OMR);
                dt.Rows.Add("PAB", val.rates.PAB);
                dt.Rows.Add("PEN", val.rates.PEN);
                dt.Rows.Add("PGK", val.rates.PGK);
                dt.Rows.Add("PHP", val.rates.PHP);
                dt.Rows.Add("PKR", val.rates.PKR);
                dt.Rows.Add("PLN", val.rates.PLN);
                dt.Rows.Add("PYG", val.rates.PYG);
                dt.Rows.Add("QAR", val.rates.QAR);
                dt.Rows.Add("RON", val.rates.RON);
                dt.Rows.Add("RSD", val.rates.RSD);
                dt.Rows.Add("RUB", val.rates.RUB);
                dt.Rows.Add("RWF", val.rates.RWF);
                dt.Rows.Add("SAR", val.rates.SAR);
                dt.Rows.Add("SBD", val.rates.SBD);
                dt.Rows.Add("SCR", val.rates.SCR);
                dt.Rows.Add("SDG", val.rates.SDG);
                dt.Rows.Add("SEK", val.rates.SEK);
                dt.Rows.Add("SGD", val.rates.SGD);
                dt.Rows.Add("SHP", val.rates.SHP);
                dt.Rows.Add("SLL", val.rates.SLL);
                dt.Rows.Add("SOS", val.rates.SOS);
                dt.Rows.Add("SRD", val.rates.SRD);
                dt.Rows.Add("SSP", val.rates.SSP);
                dt.Rows.Add("STD", val.rates.STD);
                dt.Rows.Add("STN", val.rates.STN);
                dt.Rows.Add("SVC", val.rates.SVC);
                dt.Rows.Add("SYP", val.rates.SYP);
                dt.Rows.Add("SZL", val.rates.SZL);
                dt.Rows.Add("THB", val.rates.THB);
                dt.Rows.Add("TJS", val.rates.TJS);
                dt.Rows.Add("TMT", val.rates.TMT);
                dt.Rows.Add("TND", val.rates.TND);
                dt.Rows.Add("TOP", val.rates.TOP);
                dt.Rows.Add("TRY", val.rates.TRY);
                dt.Rows.Add("TTD", val.rates.TTD);
                dt.Rows.Add("TWD", val.rates.TWD);
                dt.Rows.Add("TZS", val.rates.TZS);
                dt.Rows.Add("UAH", val.rates.UAH);
                dt.Rows.Add("UGX", val.rates.UGX);
                dt.Rows.Add("USD", val.rates.USD);
                dt.Rows.Add("UYU", val.rates.UYU);
                dt.Rows.Add("UZS", val.rates.UZS);
                dt.Rows.Add("VES", val.rates.VES);
                dt.Rows.Add("VND", val.rates.VND);
                dt.Rows.Add("VUV", val.rates.VUV);
                dt.Rows.Add("WST", val.rates.WST);
                dt.Rows.Add("XAF", val.rates.XAF);
                dt.Rows.Add("XAG", val.rates.XAG);
                dt.Rows.Add("XAU", val.rates.XAU);
                dt.Rows.Add("XCD", val.rates.XCD);
                dt.Rows.Add("XDR", val.rates.XDR);
                dt.Rows.Add("XOF", val.rates.XOF);
                dt.Rows.Add("XPD", val.rates.XPD);
                dt.Rows.Add("XPF", val.rates.XPF);
                dt.Rows.Add("XPT", val.rates.XPT);
                dt.Rows.Add("YER", val.rates.YER);
                dt.Rows.Add("ZAR", val.rates.ZAR);
                dt.Rows.Add("ZMK", val.rates.ZMK);
                dt.Rows.Add("ZMW", val.rates.ZMW);
            }

            FromCurrency.ItemsSource = dt.DefaultView;
            FromCurrency.DisplayMemberPath = "Text";
            FromCurrency.SelectedValuePath = "Value";
            FromCurrency.SelectedIndex = 0;

            ToCurrency.ItemsSource = dt.DefaultView;
            ToCurrency.DisplayMemberPath = "Text";
            ToCurrency.SelectedValuePath = "Value";
            ToCurrency.SelectedIndex = 0;
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            double ConvertedValue;

            if (FromAmount.Text == null || FromAmount.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Currency", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                FromAmount.Focus();
                return;
            }
            else if (FromCurrency.SelectedValue == null || FromCurrency.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Currency From", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                FromCurrency.Focus();
                return;
            }
            else if (ToCurrency.SelectedValue == null || ToCurrency.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Currency To", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                ToCurrency.Focus();
                return;
            }

            if (FromCurrency.Text == ToCurrency.Text)
            {
                ConvertedValue = double.Parse(FromAmount.Text);
                ToAmount.Content = ToCurrency.Text + " " + ConvertedValue.ToString("N3");
            }
            else
            {
                ConvertedValue = (double.Parse(ToCurrency.SelectedValue.ToString()) * double.Parse(FromAmount.Text)) / double.Parse(FromCurrency.SelectedValue.ToString());
                ToAmount.Content = ToCurrency.Text + " " + ConvertedValue.ToString("N3");
                fromVal = FromCurrency.SelectedIndex;
                toVal = ToCurrency.SelectedIndex;
            }
        }
        
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            FromAmount.Text = string.Empty;
            if (FromCurrency.Items.Count > 0)
                FromCurrency.SelectedIndex = 0;
            if (ToCurrency.Items.Count > 0)
                ToCurrency.SelectedIndex = 0;
            ToAmount.Content = "";
            FromAmount.Focus();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private async void Refresh_Values(object sender, RoutedEventArgs e)
        {
            val = await GetData<Root>("https://openexchangerates.org/api/latest.json?app_id=58224db5b7b74ab8a5f04580474a797a");
            BindCurrency();
            ToCurrency.SelectedIndex = toVal;
            FromCurrency.SelectedIndex = fromVal;
            Convert_Click(sender, e);
        }
    }
}

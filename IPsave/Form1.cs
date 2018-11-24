using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IPsave
{
    public partial class Form1 : Form
    {
        private Regex IP = new Regex(@"(\d{1,3})\.(\d{1,3})\.(\d{1,3})\.(\d{1,3})(\/\d+)?");

        private int ConvertToBase10(string value)
        {
            var rawData = value.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
            int dump = 0;

            for (int i = 0, r = rawData.Count() - 1; i < rawData.Count(); i++, r--)
            {
                dump += rawData[i] * (int)Math.Pow(2, r);
            }

            return dump;
        }

        private string IpFromBinary(string data)
        {
            var rawArr = data.Split('.').Select(x => ConvertToBase10(x));
            return string.Join(".", rawArr);
        }

        private string IpToBinary(string data)
        {
            var rawArr = data.Split('.').Select(x =>
            {
                var output = Convert.ToString(int.Parse(x), 2);
                int lim = 8 - output.Length;
                for (int i = 0; i < lim; i++)
                {
                    output = "0" + output;
                }
                return output;
            });
            return string.Join(".", rawArr);
        }

        private string And(string a, string b)
        {
            if (a.Length != b.Length)
            {
                MessageBox.Show("Something is wrong fa");
                return "Error!";
            }

            string dump = "";

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '.')
                {
                    dump += ".";
                    continue;
                }
                int first = int.Parse(a[i].ToString());
                int second = int.Parse(b[i].ToString());
                dump += (first * second).ToString();
            }

            return dump;
        }

        public Form1() => InitializeComponent();

        private void CalculateSubnetBinary()
        {
            var g = IP.Match(textBox1.Text).Groups;

            int prefix = int.Parse(g[5].Value.Trim('/'));

            //Get subnet in binary form
            var subnetBinaryArray = Enumerable.Repeat(1, prefix).ToList();
            var lim = 32 - subnetBinaryArray.Count;
            for (int i = 0; i < lim; i++)
            {
                subnetBinaryArray.Add(0);
            }
            string subnetBianry = string.Join("", subnetBinaryArray);

            //Split subnet
            for (int i = 8; i < subnetBianry.Length; i += 9)
            {
                subnetBianry = subnetBianry.Insert(i, ".");
            }

            subnetBinaryTxt.Text = subnetBianry;
        }

        private void CalculateSubnet() => CalculateSubnetBinary();

        private void GenerateSubnet_ConvertToBinary()
        {
            try
            {
                CalculateSubnet();
                subnetTxt.Text = IpFromBinary(subnetBinaryTxt.Text);
                ipAddTxt.Text = IpToBinary(textBox1.Text.Split('/')[0]);
            }
            catch 
            {
                MessageBox.Show("Check your input...");
            }
           
        }

        private void DisplayAandB() => aAndB.Text = And(ipAddTxt.Text, subnetBinaryTxt.Text);

        private void DisplayNetworkAddress() => textBox6.Text = IpFromBinary(aAndB.Text);

        private void DisplayNetworkAndBroadcastAddress()
        {
            int hostsNum = subnetBinaryTxt.Text.Count(x => x == '0');

            var IPAddRaw = ipAddTxt.Text.ToCharArray();
            for (int i = IPAddRaw.Length - hostsNum; i < IPAddRaw.Length; i++)
            {
                if (IPAddRaw[i] == '.') continue;
                IPAddRaw[i] = '1';
            }

            string output = string.Join(".", new string(IPAddRaw));
            textBox7.Text = IpFromBinary(output);

            DisplayNetworkAddress();
        }

        private void DisplayAllExpressedData()
        {
            try
            {
                GenerateSubnet_ConvertToBinary();
                DisplayAandB();
                DisplayNetworkAndBroadcastAddress();
            }
            catch 
            {
                MessageBox.Show("Check your input...");
            }
            
        }

        private void Button1_Click(object sender, EventArgs e) => GenerateSubnet_ConvertToBinary();

        private void Button2_Click(object sender, EventArgs e) => DisplayAllExpressedData();

        private void Button3_Click(object sender, EventArgs e) => DisplayAandB();

        private void Button5_Click(object sender, EventArgs e) => DisplayNetworkAndBroadcastAddress();
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBang
{
    public partial class FizzBuzz : Form
    {
        public FizzBuzz()
        {
            InitializeComponent();
        }

        public void FizzBuzzGo()
        {
            Boolean Fizz = false;
            Boolean Buzz = false;
            for (int count = 1; count <= 100; count ++)
            {
                Fizz = count % 3 == 0;
                Buzz = count % 5 == 0;
                if (Fizz && Buzz)
                {
                    Console.WriteLine("Fizz Buzz");
                    listBox1.Items.Add("Fizz Buzz");
                }
                else if (Fizz)
                {
                    Console.WriteLine("Fizz");
                    listBox1.Items.Add("Fizz");
                }
                else if (Buzz)
                {
                    Console.WriteLine("Buzz");
                    listBox1.Items.Add("Buzz");
                }
                else
                {
                    Console.WriteLine(count);
                    listBox1.Items.Add(count);
                }
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            FizzBuzzGo();
        }
    }
}

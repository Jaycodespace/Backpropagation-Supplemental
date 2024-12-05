using Backprop;
using System.Windows.Forms;

namespace Backpropagation_Supplemental
{
    public partial class Form1 : Form
    {
        NeuralNet nn;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // CREATE BPNN BUTTON
            nn = new NeuralNet(4, 4, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TRAIN NEURAL NETWORK BUTTON


            double[,] inputs = {
                { 0, 0, 0, 0 }, { 0, 0, 0, 1 },
                { 0, 0, 1, 0 }, { 0, 0, 1, 1 },
                { 0, 1, 0, 0 }, { 0, 1, 0, 1 },
                { 0, 1, 1, 0 }, { 0, 1, 1, 1 },
                { 1, 0, 0, 0 }, { 1, 0, 0, 1 },
                { 1, 0, 1, 0 }, { 1, 0, 1, 1 },
                { 1, 1, 0, 0 }, { 1, 1, 0, 1 },
                { 1, 1, 1, 0 }, { 1, 1, 1, 1 }
            };

            double[] outputs = {
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 1 
            };

            for (int epoch = 0; epoch < 1000; epoch++) 
            {
                for (int i = 0; i < inputs.GetLength(0); i++)
                {
                    for (int j = 0; j < 4; j++) 
                    {
                        nn.setInputs(j, inputs[i, j]);
                    }
                    nn.setDesiredOutput(0, outputs[i]); 
                    nn.learn();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           //TEST BUTTON
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox4.Text));
            nn.setInputs(3, Convert.ToDouble(textBox5.Text));
            nn.run();

           
            textBox3.Text = "" + nn.getOuputData(0);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace Opetpredano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     public class Vehicle
        {
            public string Model { get; set; }
            public int Year { get; set; }
            public int Wheels { get; set; }
            public  string Category { get; set; }

            public Vehicle(string model, int year, int wheels)
            {
                this.Model = model;
                this.Year = year;
                this.Wheels = wheels;

            }
        }

    }
    }
}

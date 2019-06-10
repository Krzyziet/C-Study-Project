using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNWD_Click(object sender, EventArgs e)
        {
            int a = Decimal.ToInt32(numericFirst.Value);
            int b = Decimal.ToInt32(numericSecond.Value);
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            MessageBox.Show("Wynik = " + a);
        }
        private void fibResult_Click_1(object sender, EventArgs e)
        {
            int n = Decimal.ToInt32(nFib.Value);
            String outString = "0 ";
            long t1 = 0, t2 = 1;
            int i = 1;
            //for (int i = 1; i <= n; ++i)
            if (n == 0)
            {
                MessageBox.Show("Wynik = 0");
            }
            else if (n == 1)
            {
                MessageBox.Show("Wynik = 1");
            }
            else if (n == 2)
            {
                MessageBox.Show("Wynik = 1");
            }
            else
            {
                while (i <= n)
                {
                    long sum = t1 + t2; //1 = 0 + 1 || 2=1+1 || 3 = 1 + 2  || 5 = 3 + 2
                    outString += t2;
                    outString += " ";
                    t1 = t2; //0 = 1 || 1=1  || 1 = 2 || 2 = 3
                    t2 = sum; // 1=1 || 1 = 2 || 2 = 3 || 3 = 5
                    i++;
                }
                MessageBox.Show("Wynik = " + outString);
            }
        }

        private void FibRekButton_Click(object sender, EventArgs e)
        {
            int n = Decimal.ToInt32(nFibReku.Value);
            long[] tablica = new long[n + 1]; //stworzenie tablicy do przechowywania porownywanych n'tych liczb
            long obiektfib(int wyraz)    // metoda obiektfib(z parametrem wyraz)
            {
                if (wyraz < 2) // "granica rekurencji" w tym miejscu pod wyraz-1 podrzucamy wartość
                {
                    if (tablica[wyraz] == 0)  // sprawdzamy czy komorka jest pusta
                    {
                        if (wyraz == 0) //sprawdzamy czy wyraz nie jest 0 
                        {
                            tablica[wyraz] = 0;
                            return 0; // jesli tak zwracamy 0
                        }
                        if (wyraz == 1) //sprawdzam czy wyraz nie jest 1 
                        {
                            tablica[wyraz] = 1;
                            return 1; // jesli tak zwracamy 1
                        }
                    }
                    return tablica[wyraz]; //zwracamy wartosc 2 wyrazu
                }
                if (tablica[wyraz] != 0)  // sprawdzamy czy komorka jest pusta
                {
                    return tablica[wyraz]; // jesli komorka nie jest pusta to zwracamy te wartosc
                }
                else
                    tablica[wyraz] = tablica[wyraz - 1] + tablica[wyraz - 2]; // komorka jest pusta więc nadajemy jej wartość 
                return obiektfib(wyraz - 1) + obiektfib(wyraz - 2); //rekurencja odnosimy cały czas cofamy się do tego miejsca tworząc drzewo !!
            }
            MessageBox.Show("Wynik = " + obiektfib(n));
        }

        private void WczytajButton_Click(object sender, EventArgs e)
        {
            DialogResult wynikOtwiera = openFileDialog1.ShowDialog();
            if (wynikOtwiera == DialogResult.OK)
            {
                Bitmap Obrazek = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                for (int i = 0; i < Obrazek.Width; i++)
                {
                    for (int j = 0; j < Obrazek.Height; j++)
                    {
                        Color odczytanyPixel = Obrazek.GetPixel(i, j);
                        if (odczytanyPixel.R < 15)
                        {
                            odczytanyPixel = Color.DarkBlue;
                        }
                        else if (odczytanyPixel.R < 40)
                        {
                            odczytanyPixel = Color.Blue;
                        }
                        else if (odczytanyPixel.R < 80)
                        {
                            odczytanyPixel = Color.Wheat;
                        }
                        else if (odczytanyPixel.R < 100)
                        {
                            odczytanyPixel = Color.Olive;
                        }
                        else if (odczytanyPixel.R < 150)
                        {
                            odczytanyPixel = Color.DarkOliveGreen;
                        }
                        else if (odczytanyPixel.R < 200)
                        {
                            odczytanyPixel = Color.Silver;
                        }
                        else
                        {
                            odczytanyPixel = Color.White;
                        }
                        Obrazek.SetPixel(i, j, odczytanyPixel);
                    }
                }
                Obrazek.Save(openFileDialog1.FileName + ".png");
                MessageBox.Show("Ukończono");
            }
        }

        private void PerfectButton_Click(object sender, EventArgs e)
        {
            String perfectShow = "";
            for (int i = 3; i <= 10000; i++)
            {
                if (isPerfect(i) == true)
                {
                    perfectShow += i;
                    perfectShow += " ";
                }
            }
            int sumDividors(int number)
            {
                int sum = 0;
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                        sum += i;
                }
                return sum;
            }
            bool isPerfect(int number)
            {
                if (number == sumDividors(number))
                    return true;
                else
                    return false;
            }
            MessageBox.Show("Wszystkie liczby to: " + perfectShow);
        }

        private void sort_button_Click(object sender, EventArgs e)
        {
            string[] OdczytanieLinie = sortbox.Lines;
            if (OdczytanieLinie.Length > 1)
            {
                int[] sortowanieLiczby = new int[OdczytanieLinie.Length];
                for (int i = 0; i < sortowanieLiczby.Length; i++)
                {
                    try
                    {
                        sortowanieLiczby[i] = Int32.Parse(OdczytanieLinie[i]);
                    }
                    catch (Exception)
                    {
                        sortowanieLiczby[i] = 0;
                    }
                    sortowanieLiczby[i] = Int32.Parse(OdczytanieLinie[i]);
                }

                //sortowanie
                bool wystapilaZmiana = false;
                int bufor;
                do
                {
                    wystapilaZmiana = false;
                    for (int i = 0; i < OdczytanieLinie.Length - 1; i++)
                    {
                        if (sortowanieLiczby[i] > sortowanieLiczby[i + 1])
                        {
                            bufor = sortowanieLiczby[i];
                            sortowanieLiczby[i] = sortowanieLiczby[i + 1];
                            sortowanieLiczby[i + 1] = bufor;
                            wystapilaZmiana = true;
                        }
                    }
                }
                while (wystapilaZmiana == true);

                //zapis
                sortbox.Clear();
                for (int i = 0; i < OdczytanieLinie.Length; i++)
                {
                    sortbox.Text += sortowanieLiczby[i].ToString() + "\n";

                }
            }

        }

        private void peseslButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 11)
            {
                int[] tablicaMnozenia = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
                char[] tablicaZnakow = richTextBox1.Text.ToCharArray();
                int[] tablicaCyfr = new int[11];
                for (int i = 0; i < 11; i++)
                {
                    tablicaCyfr[i] = Int32.Parse(tablicaZnakow[i].ToString());
                }

                int suma = 0;
                for (int i = 0; i < 10; i++)
                {
                    tablicaCyfr[i] *= tablicaMnozenia[i];
                    suma += tablicaCyfr[i];
                }

                suma = suma % 10;
                suma = 10 - suma;
                suma = suma % 10;

                if (suma == tablicaCyfr[10])
                {
                    MessageBox.Show("PESEL jest prawidłowy");
                }
                else
                {
                    MessageBox.Show(" Pesel jest błędny ");
                }

            }
            else
            {
                MessageBox.Show("PESEL jest błędny");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Euler1Button_Click(object sender, EventArgs e)
        {
            int i;
            int suma = 0;
            for (i = 3; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma = suma + i;
                }
            }
            MessageBox.Show(suma.ToString());
        }

        private void euler4Button_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            int chwilowa = 0;
            int wynik = 0;
            int back = 0;
            int rozwiazanie = 0;

            for (i = 99; i < 999; i++)
            {
                for (j = 99; j < 999; j++)
                {
                    wynik = i * j; //nasz iloczyn
                    back = 0; //zeuje back po kazdej petli for
                    while (wynik != 0)
                    { //dopoki nasza wymnozona liczba nie jest = 0 wykonujemy
                        chwilowa = wynik % 10; //odseparowanie ostatniej liczby
                        if (wynik < 10)
                        { //jezeli nasz wynik jest liczba jednosci dodajemy ja do odwroconej
                            back = back + wynik;
                        }
                        else
                        { //nasza odseparowana liczbe dodajemy do pozostalych odwroconych i mnozymy *10
                            back = back + chwilowa;
                            back = back * 10;
                        }
                        wynik = wynik / 10; //otrzymany iloczyn dzielimy przez 10
                    }
                    wynik = i * j; //wymnazamy zeby sprawdzic
                    if (wynik == back) //sprawdzenie czy lliczba odwrocona jest rowna iloczynowi naszych liczb
                    {
                        if (back > rozwiazanie) //jezeli nasz palindrom nie jest wiekszy niz dotychczas otrzymamy nie nadpisujemy zmiennej
                        {
                            rozwiazanie = back;
                        }
                    }
                }
            }
            MessageBox.Show(rozwiazanie.ToString());
        }

        private void euler5Button_Click(object sender, EventArgs e)
        {
            String toShow = "";
            int start;
            int suma = 0;
            int i;
            for (start = 2520; start < 1000000000; start++) //zaczynamy petle od 2520 bo to najmniejsza liczba z podzielna przez 1...10
            {
                suma = 0; //nasza zmienna do sprawdzania czy caly zakres 1...20 moglismy podzielic przez nasza liczbe
                for (i = 1; i <= 20; i++) //dzielimy przez i otrzymana liczbe i bedzie naszymi liczbami z zakresu 1...20
                {
                    if (start % i == 0) // jezeli nasza liczba, którą sprawdzamy jest podzielna przez liczbę i to wtedy do zmiennej suma dodajemy 1
                    {
                        suma++;
                    }
                    else //jezeli nie wyskakujemy z tej petli
                    {
                        break;
                    }
                }
                if (suma == 20) //jezeli nasza zmienna sprawdzajaca jest = 20 to znaczy ze caly zakres liczb od 1 do 20 jest dzielnikiem sprawdzanej liczby
                {
                    toShow += start;
                    break;
                }
            }
            MessageBox.Show(toShow);
        }

        private void euler14Button_Click(object sender, EventArgs e)
        {
            mostStepsNumber(1000000);    
        }

        public static void mostStepsNumber(long number)
        {
            long savedLongestSequence = 1;
            long sequenceSize = 0;
            long longestSequenceNumber = 1;
            for (int i = (int)number; i >= 1; i--)
            {
                sequenceSize = sequence(i);
                if (sequenceSize > savedLongestSequence)
                {
                    longestSequenceNumber = i;
                    savedLongestSequence = sequenceSize;
                }
            }
            MessageBox.Show("Number with: " + savedLongestSequence + " sequence length is: " + longestSequenceNumber);
        }

        private static int sequence(long number)
        {
            int sequence = 1;
            while (number > 1)
            {
                if (number % 2 == 0)
                {
                    number /= 2;
                }
                else
                {
                    number = 3 * number + 1;
                }
                sequence++;
            }
            return sequence;
        }

        private void wczytajZmiana_Click(object sender, EventArgs e)
        {
            DialogResult wynikOtwiera = openFileDialog1.ShowDialog();
            if (wynikOtwiera == DialogResult.OK)
            {
                Bitmap Obrazek = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                for (int i = 0; i < Obrazek.Width; i++)
                {
                    for (int j = 0; j < Obrazek.Height; j++)
                    {
                        Color odczytanyPixel = Obrazek.GetPixel(i, j);
                        Obrazek.SetPixel(i, j, Color.FromArgb(255-odczytanyPixel.R, 255-odczytanyPixel.G, 255-odczytanyPixel.B));
                    }
                }
                Obrazek.Save(openFileDialog1.FileName + ".png");
                MessageBox.Show("Ukończono");
            }
        }
    }
}


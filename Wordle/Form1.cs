namespace Wordle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonGenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] LINEA = System.IO.File.ReadAllLines(@"C:\Users\fran4\Desktop\C#\WORDLE\palabras5.txt");
            int NUM = rnd.Next(LINEA.Length);
            string PalabraElegida = LINEA[NUM];
            TextoPalabraElegida.Text = PalabraElegida;
        }

        private void BotonComparar_Click(object sender, EventArgs e)
        {
            if (String.Compare(CantidadIntentos.Text, "5") == 0)
            {
                ResultadoFinal.Text = "Sin intentos";
            }
            else
            {
                /*
                int IntentosActuales = Int16.Parse(CantidadIntentos.Text);
                CantidadIntentos.Text = ((IntentosActuales + '1')).ToString();
                */
                string PalabraElegida = TextoPalabraElegida.Text;
                char[] ArrayPalabraElegida = PalabraElegida.ToCharArray();
                string PalabraIngresada = TextoPalabraIngresada.Text;
                char[] ArrayPalabraIngresada = PalabraIngresada.ToCharArray();
                string[] RESULTADO = new string[5];

                    for (int I = 0; I < 5; I++)
                    {
                        for (int J = 0; J < 5; J++)
                        {
                            if (ArrayPalabraIngresada[I] == ArrayPalabraElegida[J])
                            {
                                if (I == J)
                                {
                                    RESULTADO[I] = "o";
                                    break;
                                }
                                else
                                {
                                    RESULTADO[I] = "v";
                                    break;
                                }
                            }
                            else
                            {
                            RESULTADO[I] = "x";
                            }
                        }
                    }                        
           
                Letra0.Text = RESULTADO[0];
                Letra1.Text = RESULTADO[1];
                Letra2.Text = RESULTADO[2];
                Letra3.Text = RESULTADO[3];
                Letra4.Text = RESULTADO[4];

                if (String.Compare(PalabraElegida, PalabraIngresada) == 0)
                {
                    ResultadoFinal.Text = "Palabra encontrada";
                }
            }
        }
    }
}
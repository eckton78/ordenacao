using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ordenacao
{
    public partial class Form1 : Form
    {

        #region metodos

        public static int[] bubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
            int comparacoes = 0;
            int trocas = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }

            return vetor;
        }

        public static int[] selectionSort(int[] vetor)
        {
            int min, aux;

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++)
                    if (vetor[j] < vetor[min])
                        min = j;

                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }

            return vetor;
        }

        public static int[] insertionSort(int[] vetor)
        {
            int i, j, atual;
            for (i = 1; i < vetor.Length; i++)
            {
                atual = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }
                vetor[j] = atual;
            }
            return vetor;
        }

        public static int[] quickSort(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;

            quickSort1(vetor, inicio, fim);

            return vetor;
        }

        private static void quickSort1(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }

                vetor[inicio] = vetor[f];
                vetor[f] = p;

                quickSort1(vetor, inicio, f - 1);
                quickSort1(vetor, f + 1, fim);
            }
        }

           private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle;i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while(left.Count > 0 || right.Count>0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if(left.Count>0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());    
                }    
            }
            return result;
        }

        

        #endregion

        List<int> vetA = new List<int>();
        List<int> vetB = new List<int>();
        List<int> vetC = new List<int>();

        public Form1()
        {
            InitializeComponent();

            Novo();

        }

        public void Novo()
        {
            vetA.Clear();
            vetB.Clear();
            vetC.Clear();

            preencherA();
            preencherB();
            preencherC();

            lblAini.Text = "";
            lblAfim.Text = "";
            lblAtemp.Text = "";

            lblBini.Text = "";
            lblBfim.Text = "";
            lblBtemp.Text = "";

            lblCini.Text = "";
            lblCfim.Text = "";
            lblCtemp.Text = "";

            return;
        }

        public void preencherA()
        {
            for (int i = 1; i <= 100000; i++)
            {
                vetA.Add(i);
            }
        }

        public void preencherB()
        {
            for (int i = 100000; i >= 1; i--)
            {
                vetB.Add(i);
            }
        }

        public void preencherC()
        {
            Random r = new Random();

            for (int i = 1; i <= 100000; i++)
            {
                vetC.Add(r.Next(0, 9));
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Novo();

            var aux1A = lblAini.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            bubbleSort(vetA.ToArray());
            var aux2A = lblAfim.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            lblAtemp.Text = Convert.ToString(Convert.ToInt32(aux2A) - Convert.ToInt32(aux1A));

            var aux1B = lblBini.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            bubbleSort(vetB.ToArray());
            var aux2B = lblBfim.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            lblBtemp.Text = Convert.ToString(Convert.ToInt32(aux2B) - Convert.ToInt32(aux1B));

            var aux1C = lblCini.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            bubbleSort(vetC.ToArray());
            var aux2C = lblCfim.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            lblCtemp.Text = Convert.ToString(Convert.ToInt32(aux2C) - Convert.ToInt32(aux1C));

            return;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Novo();

            var aux1A = lblAini.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            selectionSort(vetA.ToArray());
            var aux2A = lblAfim.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            lblAtemp.Text = Convert.ToString(Convert.ToInt32(aux2A) - Convert.ToInt32(aux1A));

            var aux1B = lblBini.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            selectionSort(vetB.ToArray());
            var aux2B = lblBfim.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            lblBtemp.Text = Convert.ToString(Convert.ToInt32(aux2B) - Convert.ToInt32(aux1B));

            var aux1C = lblCini.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            selectionSort(vetC.ToArray());
            var aux2C = lblCfim.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            lblCtemp.Text = Convert.ToString(Convert.ToInt32(aux2C) - Convert.ToInt32(aux1C));

            return;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Novo();

            var aux1A = lblAini.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            insertionSort(vetA.ToArray());
            var aux2A = lblAfim.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            lblAtemp.Text = Convert.ToString(Convert.ToInt32(aux2A) - Convert.ToInt32(aux1A));

            var aux1B = lblBini.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            insertionSort(vetB.ToArray());
            var aux2B = lblBfim.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            lblBtemp.Text = Convert.ToString(Convert.ToInt32(aux2B) - Convert.ToInt32(aux1B));

            var aux1C = lblCini.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            insertionSort(vetC.ToArray());
            var aux2C = lblCfim.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            lblCtemp.Text = Convert.ToString(Convert.ToInt32(aux2C) - Convert.ToInt32(aux1C));

            return;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Novo();

            var aux1A = lblAini.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            quickSort(vetA.ToArray());
            var aux2A = lblAfim.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            lblAtemp.Text = Convert.ToString(Convert.ToInt32(aux2A) - Convert.ToInt32(aux1A));

            var aux1B = lblBini.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            quickSort(vetB.ToArray());
            var aux2B = lblBfim.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            lblBtemp.Text = Convert.ToString(Convert.ToInt32(aux2B) - Convert.ToInt32(aux1B));

            var aux1C = lblCini.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            quickSort(vetC.ToArray());
            var aux2C = lblCfim.Text = DateTime.Now.TimeOfDay.Milliseconds.ToString();
            lblCtemp.Text = Convert.ToString(Convert.ToInt32(aux2C) - Convert.ToInt32(aux1C));

            return;
        }
    }
}

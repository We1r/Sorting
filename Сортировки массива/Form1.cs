using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

namespace Сортировки_массива
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
        int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
        string bubbleTime, insertTime, cocktailTime, quickTime, BOGOTime, BOGOIterString;
        int iteration;
        Stopwatch stopwatchBubble = new Stopwatch();
        Stopwatch stopwatchInsert = new Stopwatch();
        Stopwatch stopwatchCocktail = new Stopwatch();
        Stopwatch stopwatchQuick = new Stopwatch();
        Stopwatch stopwatchBOGO = new Stopwatch();
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            int[] array = Enumerable.Range(1, 20).ToArray();
            Random random = new Random();

            // Перемешивание элементов массива случайным образом
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, array[i]);
            }

            textBox1.Text = "";

            foreach (int number in array)
            {
                textBox1.Text += number + " ";
            }
        }
        private void BubbleSort(int[] bubbleArray)
        {
            int n = bubbleArray.Length;
            bool swapped;

            stopwatchBubble.Restart();
            stopwatchBubble.Start();

            if (checkBox1.Checked == false)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;

                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (bubbleArray[j] > bubbleArray[j + 1])
                        {
                            Swap(array, j, j + 1);
                            swapped = true;
                        }
                    }

                    if (!swapped)
                        break;
                }
            } else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;

                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (bubbleArray[j] < bubbleArray[j + 1])
                        {
                            Swap(array, j, j + 1);
                            swapped = true;
                        }
                    }

                    if (!swapped)
                        break;
                }
            }

            stopwatchBubble.Stop();

            textBoxBubble.Text = "";
            
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                chart1.Series[1].Points.AddXY(i + 1, array[i]);
            }

            foreach (int number in bubbleArray)
            {
                textBoxBubble.Text += number + " ";
            }
        }
        public void InsertionSort(int[] insertArray)
        {
            int n = insertArray.Length;

            stopwatchInsert.Restart();
            stopwatchInsert.Start();

            if (checkBox1.Checked == false)
            {
                for (int i = 1; i < n; i++)
                {
                    int key = insertArray[i];
                    int j = i - 1;

                    while (j >= 0 && insertArray[j] > key)
                    {
                        insertArray[j + 1] = insertArray[j];
                        j--;
                    }

                    insertArray[j + 1] = key;
                }
            } else
            {
                for (int i = 1; i < n; i++)
                {
                    int key = insertArray[i];
                    int j = i - 1;

                    while (j >= 0 && insertArray[j] < key)
                    {
                        insertArray[j + 1] = insertArray[j];
                        j--;
                    }

                    insertArray[j + 1] = key;
                }
            }

            stopwatchInsert.Stop();

            textBoxInsert.Text = "";

            chart1.Series[0].Points.Clear();
            chart1.Series[2].Points.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                chart1.Series[2].Points.AddXY(i + 1, array[i]);
            }

            foreach (int number in insertArray)
            {
                textBoxInsert.Text += number + " ";
            }
        }
        public void CocktailSort(int[] cocktailArray)
        {
            int left = 0;
            int right = cocktailArray.Length - 1;
            bool swapped;

            stopwatchCocktail.Restart();
            stopwatchCocktail.Start();

            if (checkBox1.Checked == false)
            {
                do
                {
                    swapped = false;

                    for (int i = left; i < right; i++)
                    {
                        if (cocktailArray[i] > cocktailArray[i + 1])
                        {
                            Swap(cocktailArray, i, i + 1);
                            swapped = true;
                        }
                    }

                    if (!swapped) 
                    {
                        break;
                    }

                    swapped = false;
                    right--;

                    for (int i = right; i > left; i--)
                    {
                        if (cocktailArray[i - 1] > cocktailArray[i])
                        {
                            Swap(cocktailArray, i - 1, i);
                            swapped = true;
                        }
                    }

                    left++;
                } while (swapped);
            } else
            {
                do
                {
                    swapped = false;

                    for (int i = left; i < right; i++)
                    {
                        if (cocktailArray[i] < cocktailArray[i + 1])
                        {
                            Swap(cocktailArray, i, i + 1);
                            swapped = true;
                        }
                    }

                    if (!swapped)
                    {
                        break;
                    }

                    swapped = false;
                    right--;

                    for (int i = right; i > left; i--)
                    {
                        if (cocktailArray[i - 1] < cocktailArray[i])
                        {
                            Swap(cocktailArray, i - 1, i);
                            swapped = true;
                        }
                    }

                    left++;
                } while (swapped);
            }
            stopwatchCocktail.Stop();

            textBoxCocktail.Text = "";

            chart1.Series[0].Points.Clear();
            chart1.Series[3].Points.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                chart1.Series[3].Points.AddXY(i + 1, array[i]);
            }

            foreach (int number in cocktailArray)
            {
                textBoxCocktail.Text += number + " ";
            }
        }
        public void QuickSort(int[] quickArray, int low, int high)
        {
            stopwatchQuick.Restart();
            stopwatchQuick.Start();

            if (checkBox1.Checked == false)
            {
                if (low > high)
                {
                    int pivotIndex = Partition(quickArray, low, high);

                    QuickSort(quickArray, low, pivotIndex - 1);
                    QuickSort(quickArray, pivotIndex + 1, high);
                }
            } else
            {
                if (low < high)
                {
                    int pivotIndex = Partition(quickArray, low, high);

                    QuickSort(quickArray, low, pivotIndex - 1);
                    QuickSort(quickArray, pivotIndex + 1, high);
                }
            }

            stopwatchQuick.Stop();

            textBoxQuick.Text = "";

            chart1.Series[0].Points.Clear();
            chart1.Series[4].Points.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                chart1.Series[4].Points.AddXY(i + 1, array[i]);
            }

            foreach (int number in quickArray)
            {
                textBoxQuick.Text += number + " ";
            }
        }
        public void BOGOSort(int[] BOGOArray)
        {
            stopwatchBOGO.Restart();
            stopwatchBOGO.Start();
            iteration = 0;

            while (!IsSorted(BOGOArray))
            {
                    Shuffle(BOGOArray);
                iteration++;
            }

            stopwatchBOGO.Stop();

            textBoxBOGO.Text = "";

            int[] reversedArray = new int[BOGOArray.Length];
            int index = BOGOArray.Length - 1;

            if (checkBox1.Checked == false)
            {
                foreach (int number in BOGOArray)
                {
                    textBoxBOGO.Text += number + " ";
                }
            } else
            {
                foreach (int number in BOGOArray)
                {
                    reversedArray[index] = number;
                    index--;
                }

                foreach (int number in reversedArray)
                {
                    textBoxBOGO.Text += number + " ";
                }
            }

            chart1.Series[0].Points.Clear();
            chart1.Series[5].Points.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                chart1.Series[5].Points.AddXY(i + 1, array[i]);
            }
        }

        public static bool IsSorted(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static void Shuffle(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(i, array.Length);
                Swap(array, i, j);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.Series[5].Points.Clear();
        }

        public int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (checkBox1.Checked == false)
                {
                    if (array[j] <= pivot)
                    {
                        i++;
                        Swap(array, i, j);
                    }
                } else
                {
                    if (array[j] >= pivot)
                    {
                        i++;
                        Swap(array, i, j);
                    }
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private void buttonSorting_Click(object sender, EventArgs e)
        {
            textBoxBubble.Text = "";
            textBoxInsert.Text = "";
            textBoxCocktail.Text = "";
            textBoxQuick.Text = "";
            textBoxBOGO.Text = "";

            if (checkBoxBubble.Checked == true)
            {
                BubbleSort(array);
                bubbleTime = stopwatchBubble.Elapsed.ToString();
            } else
            {
                bubbleTime = "Не запущено";
            }

            if (checkBoxInsert.Checked == true)
            {
                InsertionSort(array);
                insertTime = stopwatchInsert.Elapsed.ToString();
            } else
            {
                insertTime = "Не запущено";
            }

            if (checkBoxCocktail.Checked == true)
            {
                CocktailSort(array);
                cocktailTime = stopwatchCocktail.Elapsed.ToString();
            } else
            {
                cocktailTime = "Не запущено";
            }

            if (checkBoxQuick.Checked == true)
            {
                QuickSort(array, 0, array.Length - 1);
                quickTime = stopwatchQuick.Elapsed.ToString();
            }
            else
            {
                quickTime = "Не запущено";
            }

            if (checkBoxBOGO.Checked == true)
            {
                BOGOSort(array);
                BOGOTime = stopwatchBOGO.Elapsed.ToString();
                BOGOIterString = iteration.ToString();
            }
            else
            {
                BOGOTime = "Не запущено";
                BOGOIterString = "Не запущено";
            }

            MessageBox.Show("Пузырьковая сортировка:\n" + bubbleTime + "\n\nСоритровка вставками:\n" + insertTime + "\n\nШейкерная сортировка:\n" + cocktailTime + "\n\nБыстрая сортировка:\n" + quickTime + "\n\nBOGO:\n" + BOGOTime, "Таймер");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

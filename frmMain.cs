using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Algorithms
{
    public partial class frmMain : Form
    {
        //Attributes
        private bool sorted = false;
        private List<int> toSort = new List<int>();
        //Methods
        
        public int LinearSearch(List<int> input, int target)
        {
            int index = 0;
            foreach (int number in input)
            {
                if (number == target)
                {
                    return index;
                }
                ++index;
            }
            return -1;
        }
        /*
         Binary search splits the array into two parts, 
         searches and goes to the weigthed part of the array/list that contains the target
             */
        public int BinarySearch(List<int> input, int target)
        {
            int maxIndex = input.Count - 1;
            int minIndex = 0;
            while (minIndex <= maxIndex)
            {
                int i = minIndex + (maxIndex - minIndex) / 2;
                if (input[i] == target)
                {
                    return i;
                }
                else if (input[i] <= target)
                {
                    minIndex = i + 1;
                }
                else
                {
                    maxIndex = i - 1;
                }
            }
            return -1;
        }

        //Recursive binary search
        /*
        
            When the indexes CROSS we return -1 (not found)
            othewise continue until match found
             */
        public int RecBinarySearch(List<int> input, int target, int maxInd, int minInd)
        {
            if (maxInd < minInd)
            {
                return -1;
            }
            else
            {
                int i = minInd + (maxInd - minInd) / 2;
                if (input[i] == target)
                {
                    return i;
                }
                else if (input[i] <= target)
                {
                    return RecBinarySearch(input, target, maxInd, i + 1);
                }
                else
                {
                    return RecBinarySearch(input, target, i - 1, minInd);
                }
            }
        }

        //Generates List of integers from 0 to number choosen by user
        public List<int> Generate(int dataSetSize)
        {
            string output = "";
            List<int> numGen = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < dataSetSize; i++)
            {
                // numGen.Add(rnd.Next(0, 1000));
                numGen.Add(i);
            }
            output += Environment.NewLine;
            this.outputRTxt.Text = output;
            return numGen;

        }

        //Use Fisher-Yates algorithm to shuffle the list. 
        static Random randomize = new Random();
        public List<int> Shuffle(List<int> makeRandom)
        {
            string output = "";
            List<int> shuffled = new List<int>();
            int n = makeRandom.Count;

            while (n >= 1)
            {
                n--;
                int k = randomize.Next(n + 1);
                int value = makeRandom[k];
                makeRandom[k] = makeRandom[n];
                makeRandom[n] = value;
                shuffled.Add(value);
               output += "    " + value;
            }
            this.outputRTxt.Text = output;
            return shuffled;
        }

        public List<int> BubbleSort(List<int> input)
        {
            string output = "";
            int transactions = 0;
            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i <= input.Count; i++)
            {
                for (int j = 0; j < (input.Count - 1); j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                        transactions++;

                    }
                }
            }
            timer.Stop();
            long ms = timer.ElapsedMilliseconds;
            TimeSpan t = TimeSpan.FromMilliseconds(ms);
            string timeSorting = string.Format("Total Elapsed Time: {0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
            long ticks = timer.ElapsedTicks;
            output += Environment.NewLine + "Ticks: " + ticks;
            output += Environment.NewLine + timeSorting;
            output += Environment.NewLine + "Total in Milliseconds: " + ms;
            output += Environment.NewLine + "Number of transactions: " + transactions;
            output += Environment.NewLine + "\n";
            this.outputRTxt.Text = output;
            return input;
        }

        public List<int> SelectionSort(List<int> input)
        {
            string output = "";
            int transactions = 0;
            int minPosition;
            int temp;
            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < input.Count; i++)
            {
                minPosition = i;
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (input[j] < input[minPosition])
                    {
                        minPosition = j;
                        transactions++;
                    }
                }
                if (minPosition != i)
                {
                    temp = input[i];
                    input[i] = input[minPosition];
                    input[minPosition] = temp;
                    transactions++;
                }
            }
            timer.Stop();
            long ms = timer.ElapsedMilliseconds;
            long ticks = timer.ElapsedTicks;
            TimeSpan t = TimeSpan.FromMilliseconds(ms);
            string timeSorting = string.Format("Total Elapsed Time: {0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);

            output += Environment.NewLine + "Ticks: " + ticks;
            output += Environment.NewLine + timeSorting;
            output += Environment.NewLine + "Total in Milliseconds: " + ms;
            output += Environment.NewLine + "Number of Transactions: " + transactions + Environment.NewLine + Environment.NewLine;
            this.outputRTxt.Text = output;
            return input;

        }

        //base 10
        public int updateUnits(List<int> input)
        {
            int max = input[0];
            int units = 1;
           
            foreach (int number in input)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            for (int i = 0; i < max.ToString().Length; ++i)
            {
                units *= 10;
            }
            return units;
        }

        
        public List<int> RadixSort(List<int> input, int units)
        {
            //Make base 10
            const int radix = 10;
            //This array of lists called buckets will contain the numbers for each base
            List<int>[] buckets = new List<int>[radix];
            Stopwatch timer = new Stopwatch();
            string output = "";
            timer.Start();
            //Initialize buckets
            for (int i = 0; i < buckets.Length; ++i)
            {
                buckets[i] = new List<int>();
            }
            //Recursion -- Fill buckets           
            int aux = -1;
            foreach (int number in input)
            {
                aux = number / units;
                int auxtwo = aux % radix;
                buckets[aux % radix].Add(number);
            }
            //Set bucket into array
            int index = 0;
            //After the buckets are full
            foreach (List<int> bucket in buckets)
            {
                
                if (bucket.Count > 0 && (units / 10) > 0)
                {
                    RadixSort(bucket, units / 10);
                }
             
                foreach (int number in bucket)
                {
                    input[index] = number;
                    ++index;
                }
            }
            

            timer.Stop();
            long ms = timer.ElapsedMilliseconds;
            TimeSpan t = TimeSpan.FromMilliseconds(ms);
            string timeSorting = string.Format("Total Elapsed Time: {0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
            long ticks = timer.ElapsedTicks;
            output += Environment.NewLine + "Ticks: " + ticks;
            output += Environment.NewLine + timeSorting;
            output += Environment.NewLine + "Total in Milliseconds: " + ms;
            output += Environment.NewLine + "\n";
            this.outputRTxt.Text = output;



            return input;
        }

        public List<int> InsertionSort(List<int> input)
        {
            Stopwatch timer = new Stopwatch();
            string output = "";
            int transactions = 0;
            timer.Start();

            for (int i = 0; i < input.Count; i++)
            {
                int j = i - 1;

                while (j >= 0 && input[j] > input[j + 1])
                {
                    int swap = input[j];
                    input[j] = input[j + 1];
                    input[j + 1] = swap;
                    j = j - 1;
                }
            }

            timer.Stop();
            long ms = timer.ElapsedMilliseconds;
            TimeSpan t = TimeSpan.FromMilliseconds(ms);
            string timeSorting = string.Format("Total Elapsed Time: {0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
            long ticks = timer.ElapsedTicks;
            output += Environment.NewLine + "Ticks: " + ticks;
            output += Environment.NewLine + timeSorting;
            output += Environment.NewLine + "Total in Milliseconds: " + ms;
            output += Environment.NewLine + "Number of transactions: " + transactions;
            output += Environment.NewLine + "\n";
            this.outputRTxt.Text = output;

            return input;
        }

        public string showList() {
            string output = "";
            foreach (int i in this.toSort) {
                output += "    " + i;
            }
            return output;
        }
        public List<int> MergeSort(List<int> input)
        {
            
            if (input.Count <= 1)
            {
                return input;
            } 


            int midpoint = input.Count / 2;
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for (int i = 0; i < midpoint; i++)
            {
                left.Add(input[i]);

            }

            for (int j = midpoint; j < input.Count; j++)
            {
                right.Add(input[j]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);

        }

        public List<int> Merge(List<int> _left, List<int> _right)
        {
            Stopwatch timer = new Stopwatch();
            string output = "";
            int transactions = 0;
            timer.Start();

            //list for results
            List<int> returnList = new List<int>(); 

            //while at least one list is not empty
            while (_left.Count > 0 || _right.Count > 0)  

                //if both lists are not empty
            {
                if (_left.Count > 0 && _right.Count > 0) 
                {
                    //Compare first element
                    if (_left[0] <= _right[0])
                    {
                        returnList.Add(_left[0]);
                        _left.RemoveAt(0);
                    }

                    else if (_right[0] <= _left[0])
                    {
                        returnList.Add(_right[0]);
                        _right.RemoveAt(0);
                    }
                }

                else if (_left.Count > 0)
                {
                    returnList.Add(+_left[0]);
                    _left.RemoveAt(0);
                }
                else if (_right.Count > 0)
                {
                    returnList.Add(_right[0]);
                    _right.RemoveAt(0);
                }
                transactions++;
            }

            timer.Stop();
            long ms = timer.ElapsedMilliseconds;
            TimeSpan t = TimeSpan.FromMilliseconds(ms);
            string timeSorting = string.Format("Total Elapsed Time: {0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
            long ticks = timer.ElapsedTicks;
            output += Environment.NewLine + "Ticks: " + ticks;
            output += Environment.NewLine + timeSorting;
            output += Environment.NewLine + "Total in Milliseconds: " + ms;
            output += Environment.NewLine + "Number of transactions: " + transactions;
            output += Environment.NewLine + "\n";
            this.outputRTxt.Text = output;
            return returnList;
        }

        public List<int> ShellSort(List<int> input)
        {

            int N = input.Count;
            int h = 1;
            Stopwatch timer = new Stopwatch();
            int transactions = 0;
            string output = "";
            timer.Start();

            while (h < N / 3)
            {
                h = 3 * h + 1;
            }
            int j;
            while (h > 0)
            {
                for (int i = 0; i < N; i++)
                {
                    j = i;
                    int temp = input[i];
                    while ((j >= h) && (input[j - h] > temp))
                    {
                        input[j] = input[j - h];
                        j -= h;
                        transactions++;
                    }
                    input[j] = temp;
                }
                if (h / 2 != 0)
                {
                    h = h / 2;
                }
                else if (h == 1)
                {
                    h = 0;
                }
                else
                {
                    h = 1;
                }

                
            }

            timer.Stop();
            long ms = timer.ElapsedMilliseconds;
            TimeSpan t = TimeSpan.FromMilliseconds(ms);
            string timeSorting = string.Format("Total Elapsed Time: {0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
            long ticks = timer.ElapsedTicks;
            output += Environment.NewLine + "Ticks: " + ticks;
            output += Environment.NewLine + timeSorting;
            output += Environment.NewLine + "Total in Milliseconds: " + ms;
            output += Environment.NewLine + "Number of transactions: " + transactions;
            output += Environment.NewLine + "\n";
            this.outputRTxt.Text = output;

            return input;
        }

        public void clear() {
            this.outputRTxt.Text = "";
        }

        //Init
        public frmMain()
        {
            InitializeComponent();
        }
        //Event Handlers
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(this.sizeTxt.Text);
                this.toSort = Shuffle(Generate(size));
                this.sorted = false;
            }
            catch (Exception ex) {
                MessageBox.Show("Error, please enter an integer!");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (this.btnBubble.Checked)
            {
                clear();
                List<int> shuffled = BubbleSort(toSort);
                sorted = true;
                this.outputRTxt.Text += showList();
            }
            else if (this.rbtnInsertion.Checked)
            {
                clear();
                List<int> shuffled = InsertionSort(toSort);
                sorted = true;
                this.outputRTxt.Text += showList();
            }
            else if (this.rbtnSelection.Checked)
            {
                clear();
                List<int> shuffled = SelectionSort(toSort);
                sorted = true;
                this.outputRTxt.Text += showList();
            }
            else if (this.rbtnRadix.Checked)
            {
                clear();
                int units = updateUnits(toSort);
                List<int> shuffled = RadixSort(toSort, units);
                sorted = true;
               this.outputRTxt.Text += showList();
            }
            else if (this.rbtnMerge.Checked)
            {
                clear();
                //List<int> shuffled = MergeSort(toSort);
                toSort = MergeSort(toSort);
                sorted = true;
                this.outputRTxt.Text += showList();

            }
            else if(this.rbtnShell.Checked)
            {
                clear();
                List<int> shuffled = ShellSort(toSort);
                sorted = true;
                this.outputRTxt.Text += showList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int target = Convert.ToInt32(this.searchTxt.Text);
                if (this.rbtnLinear.Checked)
                {
                    this.clear();
                    int index = LinearSearch(toSort, target);
                    if (index == -1)
                    {
                        this.outputRTxt.Text = "Number " + target + " was not found!";
                    }
                    else
                    {
                        this.outputRTxt.Text = "Number " + target + " was found at position " + index;
                    }
                }
                else if (this.rbtnBinary.Checked)
                {
                    this.clear();
                    if (!sorted)
                    {
                        this.outputRTxt.Text = "Binary search requires your array to be sorted, please sort it first before using this method!";
                    }
                    else
                    {
                        int index = BinarySearch(toSort, target);
                        if (index == -1)
                        {
                            this.outputRTxt.Text += "Number " + target + " was not found!";
                        }
                        else
                        {
                            this.outputRTxt.Text += "Number " + target + " was found at position " + index;
                        }
                    }
                }
                else if (this.rbtnRecBinary.Checked)
                {
                    this.clear();
                    if (!sorted)
                    {
                        this.outputRTxt.Text = "Binary search requires your array to be sorted, please sort it first before using this method!";
                    }
                    else
                    {
                        int index = RecBinarySearch(toSort, target, toSort.Count - 1, 0);
                        if (index == -1)
                        {
                            this.outputRTxt.Text += "Number " + target + " was not found!";
                        }
                        else
                        {
                            this.outputRTxt.Text += "Number " + target + " was found at position " + index;
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error, please enter an integer!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.outputRTxt.Text = this.showList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shuffle(this.toSort);
            this.sorted = false;
        }

        private void rbtnRadix_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBubble_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnMerge_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

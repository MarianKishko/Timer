namespace Timer
{
    public partial class Form1 : Form
    {
        private const string _timersFileDirection = "D:\\MyProgramProjects\\Timer\\Timer\\timers.txt";

        private List<Timers> _listOfTimers = new List<Timers>();

        private TimeSpan _timeLeft;

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllTimersIntoTheList();
            AddAllItemsToTheListBox();
        }

        private void LoadAllTimersIntoTheList()
        {
            string[] timers = File.ReadAllLines(_timersFileDirection).ToArray();

            for (int i = 0; i < timers.Length; i++)
            {
                timers[i] += " ";
            }

            for (int i = 0; i < timers.Length; i++)
            {
                int[] potentialTimer = new int[3];
                int currentTimeMeasureIndex = 0;
                string m = "";

                for (int j = 0; j < timers[i].Length; j++)
                {
                    if (timers[i][j] == ':' || timers[i][j] == ' ')
                    {
                        potentialTimer[currentTimeMeasureIndex] = Convert.ToInt32(m);
                        currentTimeMeasureIndex++;
                        m = "";
                    }
                    else
                        m += timers[i][j];

                    if (j == timers[i].Length - 1)
                    {
                        Timers newTimer = new Timers(potentialTimer[0], potentialTimer[1], potentialTimer[2]);
                        _listOfTimers.Add(newTimer);
                    }
                }
            }

        }

        private void AddAllItemsToTheListBox()
        {
            foreach (Timers item in _listOfTimers)
            {
                ListOfTimers.Items.Add(item);
            }
        }

        private void ListOfTimers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListOfTimers.SelectedItem is Timers _listOfTimers)
            {
                _timeLeft = new TimeSpan(_listOfTimers.Hour, _listOfTimers.Minute, _listOfTimers.Second);
                ChangeTimerLableText();
                PauseTimer();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timeLeft = _timeLeft.Subtract(TimeSpan.FromSeconds(1));
            ChangeTimerLableText();

            if (_timeLeft == TimeSpan.Zero)
                StopTimerWhenItFinished();
        }

        private void StopTimerWhenItFinished()
        {
            PauseTimer();
            MessageBox.Show("Your time runs out!", "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void ChangeTimerLableText()
        {
            TimerLabel.Text = _timeLeft.ToString(@"hh\:mm\:ss");
        }

        private void StartTimerButton_Click(object sender, EventArgs e)
        {
            if (_timeLeft != TimeSpan.Zero) 
                TimerCountdown.Start();
        }

        private void PauseTimerButton_Click(object sender, EventArgs e)
        {
            PauseTimer();
        }

        private void StopTimerButton_Click(object sender, EventArgs e)
        {
            _timeLeft = TimeSpan.Zero;
            ChangeTimerLableText();
            PauseTimer();
        }

        private void PauseTimer()
        {
            TimerCountdown.Stop();
        }

        private void AddNewTimer_Click(object sender, EventArgs e)
        {
            CreateNewTimer timerCreater = new CreateNewTimer(this);
            timerCreater.Show(this);
        }

        public void AddNewTimerFunction(Timers newTimer)
        {
            _listOfTimers.Add(newTimer);
            ListOfTimers.Items.Add(newTimer);
        }

        private void DeleteSelectedTimer_Click(object sender, EventArgs e)
        {
            if (ListOfTimers.SelectedItems.Count > 0)
            {
                ListOfTimers.Items.Remove(ListOfTimers.SelectedItems[0]);
                _timeLeft = TimeSpan.Zero;
                ChangeTimerLableText();
            }
        }
    }
}

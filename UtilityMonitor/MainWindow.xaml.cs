using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System.Threading;

namespace UtilityMonitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> listProcess = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            ListProcesses();
        }

        private void ListProcesses()
        {
            Process[] processCollection = Process.GetProcesses();
            foreach (Process p in processCollection)
            {
                processesList.Items.Add(p.ProcessName);
                listProcess.Add(p.ProcessName);
            }

        }

        private void kill_Click(object sender, RoutedEventArgs e)
        {
            KillWithDelay();
        }

        private void processesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (processesList.SelectedItem != null)
            {
                var name = processesList.SelectedItem.ToString();
                x.Text = name;
            }
        }
        async void KillWithDelay()
        {
            if(!string.IsNullOrEmpty(x.Text) && y.Text != "" && int.Parse(y.Text) > 0)
            {
                int delayProcess = Int32.Parse(y.Text);
                var nameOfProcess = x.Text.Trim();
                await Task.Delay(delayProcess * 1000);
                foreach (var process in Process.GetProcessesByName(nameOfProcess))
                {
                    try
                    {
                        if (!process.HasExited)
                        {
                            process.Kill();
                            MessageBox.Show("Chosen process has been killed! :\"" + nameOfProcess + ".exe\"");
                        }
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine(String.Format("Could not kill process {0}, exception {1}", process.ToString(), ex.ToString()));
                    }
                }
            }
            else
            {
                MessageBox.Show("Please provide correct input.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            processesList.Items.Clear();
            listProcess.Clear();
            ListProcesses();
        }

        private void y_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void setFreq_Click(object sender, RoutedEventArgs e)
        {
            LogX();
        }

        async void LogX()
        {
            if(int.Parse(z.Text) > 0)
            {
                int freqMon = Int32.Parse(z.Text);
                var timerX = new PeriodicTimer(TimeSpan.FromSeconds(freqMon));
                while (await timerX.WaitForNextTickAsync())
                {
                    if (string.IsNullOrEmpty(z.Text) || z.Text != "")
                    {
                        int tempVar = processesList.SelectedIndex;
                        processesList.Items.Clear();
                        listProcess.Clear();
                        ListProcesses();
                        processesList.SelectedIndex = tempVar;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please provide correct input.","Warning",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Q)
            {
                Application.Current.Shutdown();
            }
        }
    }
}

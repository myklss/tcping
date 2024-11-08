using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Net.Sockets;


namespace tcping
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cts;
        public Form1()
        {
            InitializeComponent();
        }

        private async void tcping_Click(object sender, EventArgs e)
        {
            if (tcping.Text == "开始")
            {
                string ip = IP.Text;
                if (!int.TryParse(Port.Text, out int port))
                {
                    MessageBox.Show("请输入有效的端口号。", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tcping.Text = "停止";
                continuousPingCheckBox.Enabled = false;
                cts = new CancellationTokenSource();

                try
                {
                    listBox1.Items.Clear();

                    while (!cts.Token.IsCancellationRequested)
                    {
                        long latency = await TcpPingAsync(ip, port, cts.Token);
                        string result;
                        if (latency >= 0)
                        {
                            result = $"连接 {ip}:{port} 成功 延迟:{latency}ms";
                        }
                        else
                        {
                            result = $"连接 {ip}:{port} 失败 Timeout";
                        }

                        listBox1.Items.Add(result);
                        listBox1.SelectedIndex = listBox1.Items.Count - 1;

                        if (!continuousPingCheckBox.Checked)
                        {
                            break;
                        }

                        await Task.Delay(1000, cts.Token);
                    }
                }
                catch (OperationCanceledException)
                {
                    // Operation was cancelled, do nothing
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add($"Error: {ex.Message}");
                }
                finally
                {
                    cts.Dispose();
                    cts = null;
                    tcping.Text = "开始";
                    continuousPingCheckBox.Enabled = true;
                }
            }
            else
            {
                cts?.Cancel();
            }
        }


        private async Task<long> TcpPingAsync(string host, int port, CancellationToken cancellationToken)
        {
            using (var tcpClient = new TcpClient())
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();

                try
                {
                    var connectTask = tcpClient.ConnectAsync(host, port);
                    var timeoutTask = Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);

                    var completedTask = await Task.WhenAny(connectTask, timeoutTask);

                    if (completedTask == connectTask)
                    {
                        // Connection succeeded
                        await connectTask; // Ensure any exceptions are propagated
                        stopwatch.Stop();
                        return stopwatch.ElapsedMilliseconds;
                    }
                    else
                    {
                        // Timeout occurred
                        return -1;
                    }
                }
                catch (OperationCanceledException)
                {
                    return -1;
                }
                catch (Exception)
                {
                    return -1;
                }
                finally
                {
                    stopwatch.Stop();
                    tcpClient.Close();
                }
            }
        }


        private void Topdisplay_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = Topdisplay.Checked;
        }
    }
}

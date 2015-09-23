using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uFCoder_DEMO_PC2Phone_NFC
{
    public partial class frmMain : Form
    {
        uFReader ufr = new uFReader();
        bool emu_started = false;
        byte[] dataTx = new byte[100];
        byte[] dataRx = new byte[100];
        byte[] dataOld = new byte[100];
        int address = 0;
        ulong cnt = 0L;

        public frmMain()
        {
            InitializeComponent();
        }

        private void bReaderOpen_Click(object sender, EventArgs e)
        {
            if (!ufr.open())
            {
                //statusLabel.Text = "Reader opening error : " + ufr.getLastError();
                statusLabel.Text = "Reader did not open";
                return;
            }

            // open ok

            // start emulation
            if (!ufr.startEmulation())
            {
                //statusLabel.Text = "Reader can not enter in Emulation mode. Error : " + ufr.getLastError();
                statusLabel.Text = "Reader did not open";
                ufr.close();
                return;
            }

            // init 0
            Array.Clear(dataTx, 0, dataTx.Length);
            if (!ufr.writeShared(address, dataTx))
            {
                //statusLabel.Text = "Reader can not initialise NFC data communication. Error : " + ufr.getLastError();
                statusLabel.Text = "Reader did not open";
                ufr.close();
                return;
            }

            timer1.Start();

            //statusLabel.Text = "Emulation started...";
            statusLabel.Text = "Reader opened";

            emu_started = true;

            bReaderOpen.Enabled = !bReaderOpen.Enabled;
            bReaderClose.Enabled = !bReaderOpen.Enabled;
        }

        private void bReaderClose_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (!ufr.stopEmulation())
            {
                statusLabel.Text = "Stop emulation error : " + ufr.getLastError();
            }

            ufr.close();

            bReaderOpen.Enabled = !bReaderOpen.Enabled;
            bReaderClose.Enabled = !bReaderOpen.Enabled;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (emu_started)
                bReaderClose_Click(sender, e);
        }

        private bool equal(byte[] ba1, byte[] ba2)
        {
            if (ba1.Length != ba2.Length)
                return false;

            bool eq1 = true;

            for (int i = 0; i < ba1.Length; ++i)
            {
                if (ba1[i] != ba2[i])
                {
                    eq1 = false;
                    break;
                }
            }

            return eq1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool ok;
            string msg_status;

            cnt++;

            ok = ufr.readShared(address, dataRx);

            if (!ok)
            {
                statusLabel.Text = "[" + cnt + "] Read Error : " + ufr.getLastError();
                eMsgPhone.Text = "";
                return;
            }

            //            statusLabel.Text = "OK";

            // do

            //eMsgPhone.Text = dataRx.ToString();
            //eMsgPhone.Update();

            //return;


            if (equal(dataRx, dataOld))
                return;

            msg_status = "[" + cnt + "] OK";
            
            Array.Copy(dataRx, dataOld, dataRx.Length);

            if (dataRx[0] != 0)
            {
                getActualText(dataTx);

                ok = ufr.writeShared(address, dataTx);
                if (ok)
                {
                    Array.Copy(dataTx, dataOld, dataTx.Length);
                }
                else
                {
                    msg_status = "[" + cnt + "] Write Error : " + ufr.getLastError();
                    //eMsgPhone.Text = "";
                }
            }

            statusLabel.Text = msg_status;
            eMsgPhone.Text = System.Text.Encoding.UTF8.GetString(dataRx);
            eMsgPhone.Update();
        }

        private void getActualText(byte[] data)
        {
            string msg;

            msg = isMsgDef.Checked ? eMsgDef.Text : eMsgCustom.Text;
            byte[] lastText = System.Text.Encoding.UTF8.GetBytes(msg);

            Array.Clear(data, 0, data.Length);
            Array.Copy(lastText, dataTx, lastText.Length);
        }
    }
}

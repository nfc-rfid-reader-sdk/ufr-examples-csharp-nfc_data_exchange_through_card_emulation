using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLogic.uFCoder.Single;

namespace uFCoder_DEMO_PC2Phone_NFC
{
    class uFReader
    {
        DL_STATUS status = DL_STATUS.DL_OK;

        public uFReader()
        {

        }

        public static string getDLLVersion()
        {
            //return uFCoder.
            return null;
        }

        public string getLastError()
        {
            return status.ToString();
        }

        public bool open()
        {
            status = uFCoder.ReaderOpen();

            return status == DL_STATUS.DL_OK;
        }

        public bool close()
        {
            status = uFCoder.ReaderClose();

            return status == DL_STATUS.DL_OK;
        }

        public bool startEmulation()
        {
            System.Threading.Thread.Sleep(20);

            status = uFCoder.EnterShareRamCommMode();

            System.Threading.Thread.Sleep(20);
            
            if (status == DL_STATUS.DL_OK)
                status = uFCoder.TagEmulationStart();

            if (status == DL_STATUS.DL_OK)
            {
                System.Threading.Thread.Sleep(1000);
            }

            return status == DL_STATUS.DL_OK;
        }

        public bool stopEmulation()
        {
            DL_STATUS stat1;

            stat1 = uFCoder.ExitShareRamCommMode();

            System.Threading.Thread.Sleep(100);

            status = uFCoder.TagEmulationStop();

            return status == DL_STATUS.DL_OK;
        }

        public bool readShared(int adr, byte[] data)
        {
            Array.Clear(data, 0, data.Length);

            unsafe
            {
                fixed (byte* p = data)
                    status = uFCoder.ReadShareRam(p, (byte)adr, (byte)data.Length);
            }

            return status == DL_STATUS.DL_OK;
        }

        public bool writeShared(int adr, byte[] data)
        {
            unsafe
            {
                fixed (byte* p = data)
                    status = uFCoder.WriteShareRam(p, (byte)adr, (byte)data.Length);
            }

            return status == DL_STATUS.DL_OK;
        }

    }
}

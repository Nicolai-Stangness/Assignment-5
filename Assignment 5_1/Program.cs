using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class quadcopter_generic
    {
        //I will just use the shorthand bt for bluetooth
        protected bool ir = false;
        protected bool rf = false;
        protected bool bt = false;
        
        protected int snr_ir = 0;
        protected int snr_rf = 0;
        protected int snr_bt = 0;

        protected int x = 0;
        protected int y = 0;
        protected int z = 0;

        protected string model_id = "generic object";

        public void select_comm_method()
        {
            if (snr_ir > snr_rf && snr_rf > snr_bt)
            {
                ir = true;
            }
            else if (snr_rf > snr_ir && snr_rf > snr_bt)
            {
                rf = true;
            }
            else
            {
                bt = true;
            }
        }
        public void disp_id()
        {
            Console.WriteLine("Model type is {}", model_id);
        }

        public void set_position(int a, int b, int c)
        {
            x = a; y = b; c = z;
        }
    }
}

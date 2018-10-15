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
    class Quadcopter_generic
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

        public void Select_comm_method()
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
        public virtual void Disp_id()
        {
            Console.WriteLine("Model type is {}", model_id);
        }

        public void Set_position(int a, int b, int c)
        {
            x = a; y = b; c = z;
        }
    }
    class Quadcopter_ir : Quadcopter_generic
    {
        public override void Disp_id()
        {
            Console.WriteLine("getting ir quadcopter info");
        }
    }

    class Quadcopter_ir_rf : Quadcopter_ir
    {
        public override void Disp_id()
        {
            Console.WriteLine("getting ir, rf quadcopter into");
        }
    }
    class Quadcopter_rf : Quadcopter_generic
    {
        public override void Disp_id()
        {
            Console.WriteLine("getting rf quadcopter info");
        }
    }

    class Quadcopter_ir_bt_rf : Quadcopter_ir_rf
    {

        public override void Disp_id()
        {
            Console.WriteLine("getting ir_bt_rf quadcopter info");
        }
    }
}


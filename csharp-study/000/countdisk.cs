
namespace coutdisk
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Management;

    class HardDrive
    {
        private string model = null;
        private string type = null;
        private string serialNo = null;
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        
        public string SerialNo
        {
            get { return serialNo; }
            set { serialNo = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GetLogicalDisk();
            GetPhysicDisk();
        }

        private static void GetLogicalDisk()
        {
            WqlObjectQuery wmiquery = new WqlObjectQuery("SELECT * FROM Win32_LogicalDisk");
            ManagementObjectSearcher wmifind = new ManagementObjectSearcher(wmiquery);
            foreach (ManagementObject mobj in wmifind.Get())
            {
                Console.WriteLine("Logical Disk Partion: " + mobj["Description"].ToString());
                Console.WriteLine("Logical Disk Name: " + mobj["Name"].ToString());
                Console.WriteLine("---------------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("Logical disk counter: " + wmifind.Get().Count);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
        }

        private static void GetPhysicDisk()
        {
            ArrayList hdCollection = new ArrayList();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                HardDrive hd = new HardDrive();
                hd.Model = wmi_HD["Model"].ToString();
                hd.Type = wmi_HD["InterfaceType"].ToString();
                hdCollection.Add(hd);
            }

            searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

            var result = searcher.Get();

            if (result.Count != 0)
            {
                int i = 0;
                foreach (ManagementObject wmi_HD in result)
                {
                    // get the hard drive from collection
                    // using index
                    HardDrive hd = (HardDrive)hdCollection[i];

                    // get the hardware serial no.
                    if (wmi_HD["SerialNumber"] == null)
                        hd.SerialNo = "None";
                    else
                        hd.SerialNo = wmi_HD["SerialNumber"].ToString();

                    ++i;
                }

                // Display available hard drives
                foreach (HardDrive hd in hdCollection)
                {
                    Console.WriteLine("Model\t\t: " + hd.Model);
                    Console.WriteLine("Type\t\t: " + hd.Type);
                    Console.WriteLine("Serial No.\t: " + hd.SerialNo);
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Physic disk counter: " + hdCollection.Count);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Physic disk counter is zero");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
            }
        }
    }
}

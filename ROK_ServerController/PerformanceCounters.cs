using System;

using System.Diagnostics;


namespace ROK_ServerController
{
    class PerformanceCounters
    {
        public float CPU { get; set; }
        public decimal usedRAM { get; set; }
        public decimal availableRAM { get; set; }
        public decimal ramPercent { get; set; }

        PerformanceCounter CPUcounter = new PerformanceCounter();
        PerformanceCounter memoryCounter = new PerformanceCounter();
        PerformanceCounter availableMem = new PerformanceCounter();
        PerformanceCounter poolPage = new PerformanceCounter();


        public void makeCounters()
        {
            try
            {
                //cpu
                CPUcounter.CategoryName = "Process";
                CPUcounter.CounterName = "% Processor Time";
                CPUcounter.InstanceName = "ROK";
                float counterCPU = CPUcounter.NextValue();
                CPU = counterCPU / Environment.ProcessorCount;
                //ram
                memoryCounter.CategoryName = "Process";
                memoryCounter.CounterName = "Working Set - Private";
                memoryCounter.InstanceName = "ROK";
                float counterRAM = memoryCounter.NextValue();
                usedRAM = Convert.ToDecimal(counterRAM / 1048570);

                availableMem.CategoryName = "Memory";
                availableMem.CounterName = "Available MBytes";
                decimal memAvailable = Convert.ToDecimal(availableMem.NextValue());
                availableRAM = memAvailable;

                poolPage.CategoryName = "Memory";
                poolPage.CounterName = "Pool Paged Bytes";
                decimal pagePool = Convert.ToDecimal(poolPage.NextValue());
                decimal newPagePool = Convert.ToDecimal(pagePool / 1048570);
                decimal rounedPagePool = Math.Round(newPagePool, 1, MidpointRounding.AwayFromZero);
                decimal totalAvailRam = availableRAM - rounedPagePool;
                decimal p1 = totalAvailRam / 100;
                decimal p2 = usedRAM / p1;
                ramPercent = p2;
            }
            catch{ }

        }
        
    }
}

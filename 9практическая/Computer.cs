using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9практическая
{
    struct Computer
    {
        public string ProcessorType;
        public int MemorySize;
        public int HDDSize;
        public string VideoCard;

        public Computer(string processorType, int memorySize, int hardDiskDriveSize, string videoCard)
        {
            ProcessorType = processorType;
            MemorySize = memorySize;
            HDDSize = hardDiskDriveSize;
            VideoCard = videoCard;
        }
    }
}

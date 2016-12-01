using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_printer_calibrator
{
    abstract class PrinterClass
    {
        public string name;

        abstract public Tuple<float, float> calculateOffsets(float[] numbers);
    }

    class Cartesio : PrinterClass
    {
        public Cartesio()
        {
            name = "Cartesio";
        }

        public override Tuple<float, float> calculateOffsets(float[] numbers)
        {
            float deltaX = numbers[2] - numbers[3];
            float deltaY = numbers[4] - numbers[5];

            float newXValue = numbers[0] + deltaX / 2.0f;
            float newYValue = numbers[1] + deltaY / 2.0f;
            return new Tuple<float, float>(newXValue, newYValue);
        }
    }

    class TAZ6Cura : PrinterClass
    {
        public TAZ6Cura()
        {
            name = "Unimplemented";
        }

        public override Tuple<float, float> calculateOffsets(float[] numbers)
        {
            //Unimplemented
            return new Tuple<float, float>(0,0);
        }
    }

    class TAZ6S3D : PrinterClass
    {
        public TAZ6S3D()
        {
            name = "Unimplemented2";
        }

        public override Tuple<float, float> calculateOffsets(float[] numbers)
        {
            //Unimplemented
            return new Tuple<float, float>(0, 0);
        }
    }
}
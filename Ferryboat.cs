using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    class Ferryboat : PublicTransport
    {
        public override string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Capacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool Electric { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool Rail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool Underground { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Engine { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int AverageSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int MaxSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double ApproximateTravelTime(int distanceKM)
        {
            throw new NotImplementedException();
        }
    }
}

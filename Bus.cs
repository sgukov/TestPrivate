using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    class Bus : PublicTransport, IPayment
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
            return distanceKM / AverageSpeed * factor_TrafficJam * factor_TrafficLights;
        }

        public bool AutomaticPaymentFromCard()
        {
            throw new NotImplementedException();
        }

        public bool BonusPayment()
        {
            throw new NotImplementedException();
        }

        public bool CashlessPayment()
        {
            throw new NotImplementedException();
        }

        public bool CashPayment()
        {
            throw new NotImplementedException();
        }

        public bool OnlineTransferPayment()
        {
            throw new NotImplementedException();
        }
    }
}

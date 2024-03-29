﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Physical_Layer;
using Link_Layer;

namespace Network_Simulator.Instructions
{
    public class CreateHostI : Instruction
    {
        public CreateHostI(int time, string[] args) : base(time, args) { }

        public override void Exec(Dictionary<string, Device> devices, List<IConnector> connectors)
        {
            HostLL h = new HostLL(Args[0], Simulator.Time);
            h.signal_time = Simulator.Signal_Time;
            h.Clock = Simulator.Time;
            devices.Add(h.Name, h);
        }
    }
}

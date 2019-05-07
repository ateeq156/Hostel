﻿using Shared;

namespace Hostel.Event
{
    public class SensorInstalled : IEvent
    {
        public Sensor.Model.Sensor Device { get; }
        public string Commander { get; }
        public string CommandId { get; }
        public SensorInstalled(Sensor.Model.Sensor device, string commander, string commandid)
        {
            Device = device;
            Commander = commander;
            CommandId = commandid;
        }
    }
}

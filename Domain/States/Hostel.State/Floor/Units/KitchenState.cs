﻿using Hostel.Model;
using Hostel.State.Sensor;
using Shared;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Hostel.State.Floor.Units
{
    public class KitchenState : Message, IState<KitchenState>
    {
        public string KitchenId { get; }
        public string Tag { get; }
        public IEnumerable<SensorSpec> Sensors { get; }
        public IEnumerable<Reading> Current { get; }
        public IEnumerable<Reading> Previous { get; }
        public ImmutableDictionary<string, ICommand> PendingCommands { get; }
        public ImmutableHashSet<IMassTransitEvent> PendingResponses { get; }

        public KitchenState(string id, string tag, IEnumerable<SensorSpec> sensors) : this(id,tag, sensors, Enumerable.Empty<Reading>(), Enumerable.Empty<Reading>(), ImmutableDictionary<string, ICommand>.Empty, ImmutableHashSet<IMassTransitEvent>.Empty)
        {
        }
        public KitchenState(string id, string tag, IEnumerable<SensorSpec> sensors, IEnumerable<Reading> current, IEnumerable<Reading> previous, ImmutableDictionary<string, ICommand> pendingCommands, ImmutableHashSet<IMassTransitEvent> pendingResponses)
        {
            Tag = tag;
            Sensors = sensors;
            KitchenId = id;
            Current = current;
            Previous = previous;
            PendingCommands = pendingCommands;
            PendingResponses = pendingResponses;
        }
        public KitchenState Update(IEvent evnt)
        {
            switch (evnt)
            {
                default: return this;
            }
        }
    }
}

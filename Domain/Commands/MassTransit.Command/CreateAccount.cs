﻿using Shared;
using System.Collections.Generic;

namespace MassTransit.Command
{
    public class CreateAccount:IMassTransitCommand
    {
        public string Command { get; private set; }
        public string Commander { get; private set; }
        public string CommandId { get; private set; }
        public Dictionary<string, string> Payload { get; private set; }
        public CreateAccount(string command, string commander, string commandid, Dictionary<string, string> payload)
        {
            Command = command;
            Commander = commander;
            CommandId = commandid;
            Payload = payload;
        }
    }
}

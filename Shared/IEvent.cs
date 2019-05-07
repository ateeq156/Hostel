﻿
namespace Shared
{
    public interface IEvent
    {
        string Commander { get; } //e.g. UserName so that we can send response to the right user
        string CommandId { get; } // This we need to track the command
    }
}

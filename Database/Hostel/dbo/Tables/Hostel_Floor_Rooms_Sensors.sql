﻿CREATE TABLE [dbo].[Hostel_Floor_Rooms_Sensors] (
    [RoomSensor] UNIQUEIDENTIFIER CONSTRAINT [DF_Hostel_Floor_Room_Sensors_RoomSensor] DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    [RoomId]     UNIQUEIDENTIFIER NOT NULL,
    [Key] NVARCHAR(50) NOT NULL, 
    [Value] NVARCHAR(50) NOT NULL, 
    [TimeStamp] BIGINT NOT NULL, 
    CONSTRAINT [PK_Hostel_Floor_Room_Sensors] PRIMARY KEY CLUSTERED ([RoomSensor] ASC),
    CONSTRAINT [FK_Hostel_Floor_Rooms_Sensors_Hostel_Floor_Rooms] FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Hostel_Floor_Rooms] ([RoomId]),
);


--
UPDATE dbo.GroupMeeting 
SET GroupMeeting.[RoomName] = r.[RoomName]
FROM dbo.GroupMeeting gr JOIN dbo.Room AS r
ON r.RoomID = gr.RoomID

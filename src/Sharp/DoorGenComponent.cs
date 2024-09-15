using Godot;
using System;



public partial class DoorGenComponent : Node
/*

*/



{
public void NorthDoor()
    {
        if (RoomData.NorthDoor != null && RoomData.NorthWall != null)
        {
            RoomData.NorthDoor.Visible = true;
            RoomData.NorthWall.QueueFree();
        }
        else
        {
            GD.PrintErr("NorthDoor or NorthWall is null");
        }
    }

    public void SouthDoor()
    {
        if (RoomData.SouthDoor != null && RoomData.SouthWall != null)
        {
            RoomData.SouthDoor.Visible = true;
            RoomData.SouthWall.QueueFree();
        }
        else
        {
            GD.PrintErr("SouthDoor or SouthWall is null");
        }
    }

    public void EastDoor()
    {
        if (RoomData.EastDoor != null && RoomData.EastWall != null)
        {
            RoomData.EastDoor.Visible = true;
            RoomData.EastWall.QueueFree();
        }
        else
        {
            GD.PrintErr("EastDoor or EastWall is null");
        }
    }

    public void WestDoor()
    {
        if (RoomData.WestDoor != null && RoomData.WestWall != null)
        {
            RoomData.WestDoor.Visible = true;
            RoomData.WestWall.QueueFree();
        }
        else
        {
            GD.PrintErr("WestDoor or WestWall is null");
        }
    }

	 public override void _Process(Double delta)
	{
	
	}
}

using Godot;
using System;



public partial class DoorGenComponent : Node
/*

*/



{
public void NorthDoor()
    {
        if (RoomData.NorthDoor != null)
        {
            RoomData.NorthDoor.Instantiate();
        }
        else
        {
            GD.PrintErr("NorthDoor or NorthWall is null");
        }
    }

    public void SouthDoor()
    {
        if (RoomData.SouthDoor != null)
        {
            RoomData.SouthDoor.Instantiate();
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
            RoomData.EastDoor.Instantiate();
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
            RoomData.WestDoor.Instantiate();
        }
        else
        {
            GD.PrintErr("WestDoor or WestWall is null");
        }
    }

    public void NorthWall()
    {
        if (RoomData.NorthWall != null)
        {
            var instance = RoomData.NorthWall.Instantiate();
            AddChild(instance);
            GD.Print("NorthWall instantiated");
        }
        else
        {
            GD.PrintErr("NorthWall is null");
        }
    }

    public void SouthWall()
    {
        if (RoomData.SouthWall != null)
        {
            var instance = RoomData.SouthWall.Instantiate();
            AddChild(instance);
        }
        else
        {
            GD.PrintErr("SouthWall is null");
        }
    }

    public void EastWall()
    {
        if (RoomData.EastWall != null)
        {
            var instance = RoomData.EastWall.Instantiate();
            AddChild(instance);
        }
        else
        {
            GD.PrintErr("EastWall is null");
        }
    }

    public void WestWall()
    {
        if (RoomData.WestWall != null)
        {
            var instance = RoomData.WestWall.Instantiate();
            AddChild(instance);
        }
        else
        {
            GD.PrintErr("WestWall is null");
        }
    }

	 public override void _Process(Double delta)
	{
	
	}
}

using Godot;
using System;

public partial class RoomData : Node2D
/*
	Stores the data of a room's tilesets and its permutations.
*/
{
	int RoomInsideWidth = 9;
	int RoomInsideHeight = 9;

	public static Guid id {get;} = Guid.NewGuid();

	public static Vector2 position {get; set;} = new Vector2(0, 0);

	public static PackedScene NorthWall = GD.Load<PackedScene>("res://assets/objects/room/north_wall_component.tscn"); 
	public static PackedScene SouthWall = GD.Load<PackedScene>("res://assets/objects/room/south_wall_component.tscn"); 
	public static PackedScene EastWall = GD.Load<PackedScene>("res://assets/objects/room/east_wall_component.tscn"); 
	public static PackedScene WestWall = GD.Load<PackedScene>("res://assets/objects/room/west_wall_component.tscn"); 

	public static PackedScene NorthDoor = GD.Load<PackedScene>("res://assets/objects/room/north_door_component.tscn"); 
	public static PackedScene SouthDoor = GD.Load<PackedScene>("res://assets/objects/room/south_door_component.tscn"); 
	public static PackedScene EastDoor = GD.Load<PackedScene>("res://assets/objects/room/east_door_component.tscn"); 
	public static PackedScene WestDoor = GD.Load<PackedScene>("res://assets/objects/room/west_door_component.tscn"); 


    public override void _Ready()
	/*
		When this object is loaded, it will attemp to find and store
		the tilemap layers that represent the walls and doors of the room.
	*/

    {
        
    }

	public override void _Process(double delta)
	{
		position = Position;
	}
}

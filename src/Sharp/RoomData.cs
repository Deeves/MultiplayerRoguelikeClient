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

	public static TileMapLayer NorthWall {get; set;}
	public static TileMapLayer SouthWall{get; set;}
	public static TileMapLayer EastWall{get; set;}
	public static TileMapLayer WestWall {get; set;}

	public static TileMapLayer NorthDoor {get; set;}
	public static TileMapLayer SouthDoor {get; set;}
	public static TileMapLayer EastDoor {get; set;}
	public static TileMapLayer WestDoor {get; set;}


    public override void _Ready()
	/*
		When this object is loaded, it will attemp to find and store
		the tilemap layers that represent the walls and doors of the room.
	*/

    {
        
		
		NorthWall = GetNode<TileMapLayer>("NorthWallComponent");
		SouthWall = GetNode<TileMapLayer>("SouthWallComponent");
		EastWall = GetNode<TileMapLayer>("EastWallComponent");
		WestWall = GetNode<TileMapLayer>("WestWallComponent");

		NorthDoor = GetNode<TileMapLayer>("NorthDoorComponent");
		SouthDoor = GetNode<TileMapLayer>("SouthDoorComponent");
		EastDoor = GetNode<TileMapLayer>("EastDoorComponent");
		WestDoor = GetNode<TileMapLayer>("WestDoorComponent");
    }

	public override void _Process(double delta)
	{
		position = Position;
	}
}

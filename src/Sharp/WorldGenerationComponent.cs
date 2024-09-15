using Godot;
using System;
using System.Numerics;
using System.Collections.Generic;


public partial class WorldGenerationComponent : Node
/*
	Generates a 2D map of rooms using room objects located in 
	world/room.tscn 
*/
{

	private int MapWidth = 14;
	// Width of the map to generate

	private int MapHeight = 14;
	// Height of the map to generate	

	private int RoomsToGenerate = 24;
	// Number of rooms to generate

	private int RoomCount = 0;
	// Number of generated rooms

	private Godot.Vector2 MapOrigin;
	// Origin X and Y vector of the map

	private List<List<object>> Map = new List<List<object>>();
	// a 2D list that represents the map
	

	public override void _Ready()
	/*
		When this component is added, it will fill a tilemap with 
		procedurally generated dungeon rooms.
	*/
	{

		for (int i = 0; i < MapWidth; i++)
		{
			Map.Add(new List<object>()); 
			for (int j = 0; j < MapHeight; j++)
			{
				Map[i].Add(null);
			}
		}
		Generate();
	}

	public void Generate()
	/*
		Generates the map, and an array representation of the map
		in Terminal. 
	*/
	{
		CheckRoom(3, 3, RoomsToGenerate, new Godot.Vector2(0, 0), true);
		instatniateRooms();
		String Preview = "";
		for (int i = 0; i < MapWidth; i++)
		{
			for (int j = 0; j < MapHeight; j++)
			{
				if (Map[i][j] != null)
				{
					Preview += "|X|";
				}
				else
				{
					Preview += "|O|";
				}
			}
			Preview += "\n";
		} 
		GD.Print(Preview);
	}

	public void CheckRoom(int x, int y, int remaining, Godot.Vector2 GeneralDirection, bool FirstRoom = false)
	/*
		Checks if a room can be placed at the given coordinates. If it can, 
		it places the room and calls itself recursively to place more rooms.
	*/
	{
		if (RoomCount >= RoomsToGenerate)
		//if we have already met the qouta of rooms to generate, then stop 
		{
			return;
		}

		if (x < 0 || x > MapWidth - 1 || y < 0 || y > MapHeight - 1)
		// if the coordinates are out of bounds, then stop
		{
			return;
		}

		if (FirstRoom == false && remaining <= 0)
		// if we have no more rooms to generate, then stop
		{
			return;
		}

		if (Map[x][y] != null)
		// if there is already a room at the coordinates, then stop
		{
			return;
		}
		if (FirstRoom == true)
		// if this is the first room, then record the origin of the map
		{
			MapOrigin = new Godot.Vector2(x, y);
		}
		{
			var FirstRoomPosition = new Godot.Vector2(x, y);
		}

		RoomCount += 1;
		Map[x][y] = true;
		// place the room in a series of random directions 

		var NorthProbe = GD.Randf() > (GeneralDirection == Vector2I.Up ? 0.2 : 0.8);
		var SouthProbe = GD.Randf() > (GeneralDirection == Vector2I.Down ? 0.2 : 0.8);
		var EastProbe = GD.Randf() > (GeneralDirection == Vector2I.Right ? 0.2 : 0.8);
		var WestProbe = GD.Randf() > (GeneralDirection == Vector2I.Left ? 0.2 : 0.8);

		int MaxRemaining = RoomsToGenerate;

		if (NorthProbe || FirstRoom == true)
		{
			CheckRoom(x, y - 1, MaxRemaining - 1, Vector2I.Up);
		}
		if (SouthProbe || FirstRoom == true)
		{
			CheckRoom(x, y + 1, MaxRemaining - 1, Vector2I.Down);
		}
		if (EastProbe || FirstRoom == true)
		{
			CheckRoom(x + 1, y, MaxRemaining - 1, Vector2I.Right);
		}
		if (WestProbe || FirstRoom == true)
		{
			CheckRoom(x - 1, y, MaxRemaining - 1, Vector2I.Left);
		}
	}

	public void instatniateRooms()
	/*
		Populates the room.tscn objects into the TyleMapLayer.	
	*/
	{
		if (WorldData.roomsInstantiated == true)
		{
			return;
		}
		WorldData.roomsInstantiated = true;

		for (int x = 0; x < MapWidth; x++)
		{
			for (int y = 0; y < MapHeight; y++)
			{
				if (Map[x][y] == null)
				{
					continue;
				}

				Node2D room = (Node2D)WorldData.room.Instantiate();
				room.Position = new Godot.Vector2(x, y) * 816;
				AddChild(room);
				
				var doorGenComponent = room.GetNode<DoorGenComponent>("DoorGenComponent");
				GD.Print($"Processing room at {x}, {y})");

				// if there is a room to the north, then place a door
				if (y>0 && Map[x][y-1] != null)
				{
					GD.Print("Placing North Door");
					doorGenComponent.NorthDoor();
				}
				else
				{
					GD.Print("Placing North Wall");
					doorGenComponent.NorthWall();
				}

				// if there is a room to the south, then place a door
				if (y < MapHeight - 1 && Map[x][y + 1] != null)
				{
					doorGenComponent.SouthDoor();
				}
				else
				{
					doorGenComponent.SouthWall();
				}

				// if there is a room to the east, then place a door
				if (x < MapWidth - 1 && Map[x + 1][y] != null)
				{
					doorGenComponent.EastDoor();
				}
				else
				{
					doorGenComponent.EastWall();
				}

				// if there is a room to the west, then place a door
				if (x > 0 && Map[x - 1][y] != null)
				{
					doorGenComponent.WestDoor();
				}
				else
				{
					doorGenComponent.WestWall();
				}

				//CallDeferred("add_child", room);
				WorldData.roomNodes.Add(room);
			}
		}
	}
}

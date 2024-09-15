using Godot;
using System;


public partial class WorldData : Node
{
	
	public static Guid id {get;} = Guid.NewGuid();

	public static PackedScene room = GD.Load<PackedScene>("res://assets/objects/world/room.tscn"); 

 	public static bool roomsInstantiated = false;

	public  static Godot.Collections.Array roomNodes = new Godot.Collections.Array();

	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

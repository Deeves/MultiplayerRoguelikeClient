using Godot;
using System;
using System.Collections.Generic;


public partial class SpiritData : Node2D


{
	public static Guid id = Guid.NewGuid();

	public static Vector2 position = new Vector2(0, 0);

	public static Color myColor = Utility.RollRandomColor();

	public static bool isPossesing = false;



	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Player ID " + id);
		GD.Print("Player Position " + position);
		GD.Print(Utility.Roll20());

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	// I need to update the position of SpritData to the MoveComponent Node's position every frame to keep the player's position updated.
    {

	}
}
using Godot;
using System;

public partial class EntityData : Node2D
{
	
	public static Guid id = Guid.NewGuid();

	public static Vector2 position = new Vector2(0, 0);

	public static Color myColor = Utility.RollRandomColor();

	public static bool isPossesable = false;

	public static Guid possesedBy;

	public static int health = 100;

	public static int damage = 10;

	public static float attackChance  = 0.15f;

	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Update the position of the entity to the MoveComponent Node's position every frame to keep the entity's position updated.
		position = Position;
	}
}

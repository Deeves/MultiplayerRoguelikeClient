using Godot;
using System;
using System.Numerics;

public partial class MoveComponent : CharacterBody2D
{

	[Export]
	private int TileSize = 64;

	public override void _UnhandledInput(InputEvent @event)
	{

		Vector2I Velocity = Vector2I.Zero;

		if (@event is InputEventKey eventKey)
		{
			if (eventKey.Pressed)
			{
				if (eventKey.IsActionPressed("ui_right"))
				{
					Velocity = Vector2I.Right;
					Move(Velocity);
				}
				if (eventKey.IsActionPressed("ui_left"))
				{
					Velocity = Vector2I.Left;
					Move(Velocity);
				}
				if (eventKey.IsActionPressed("ui_up"))
				{
					Velocity = Vector2I.Up;
					Move(Velocity);
				}
				if (eventKey.IsActionPressed("ui_down"))
				{
					Velocity = Vector2I.Down;
					Move(Velocity);
				}
			}
		}
	}

	    private void Move(Vector2I direction)
    {
        var spaceRid = GetWorld2D().Space;
        var spaceState = PhysicsServer2D.SpaceGetDirectState(spaceRid);
        var query = PhysicsRayQueryParameters2D.Create(GlobalPosition, GlobalPosition + direction * TileSize);

        var result = spaceState.IntersectRay(query);

		this.GlobalPosition += direction * TileSize;
    }
	
}

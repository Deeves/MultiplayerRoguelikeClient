using Godot;
using System;

public partial class SpriteComponent : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		SelfModulate = SpiritData.myColor;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (SpiritData.isPossesing)
		{
			Visible = false;
		}
		else
		{
			Visible = true;
		}
	}
}

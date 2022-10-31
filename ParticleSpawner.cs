using Godot;
using System;

public class ParticleSpawner : Particles2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

     // Called every frame. 'delta' is the elapsed time since the previous frame.
     public override void _Process(float delta)
     {
         if (!Emitting)
         QueueFree();
         
     }

    public void Initialize(Vector2 spawnPosition, Color col, int amount, bool isOneShot)
    {
        Position = spawnPosition;
        OneShot = isOneShot;
        Amount = amount;
        ProcessMaterial.Set("color", col);
    }
}

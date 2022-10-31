using Godot;
using System;

public class Main : Node2D
{

#pragma warning disable 649
    [Export]
    public PackedScene ParticleScene;
#pragma warning disable 649

    public Color ParticleColour = new Color(1.0f,1.0f,1.0f,1.0f);
    public int ParticleAmount = 10;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }

    public override void _Input(InputEvent inputEvent)
    {
        // if (inputEvent is InputEventMouseButton mouseEvent && mouseEvent.Pressed)
        // {
        //     switch ((ButtonList)mouseEvent.ButtonIndex)
        //     {
        //         case ButtonList.Left:
        //             GD.Print("Left button was clicked at ", mouseEvent.Position);
        //             break;
        //         case ButtonList.WheelUp:
        //             GD.Print("Wheel up");
        //             break;
        //     }
        // }

        if (inputEvent is InputEventScreenTouch touchEvent && touchEvent.Pressed)
        {
            ParticleSpawner PS = (ParticleSpawner)ParticleScene.Instance();
            
            PS.Initialize(touchEvent.Position, ParticleColour, ParticleAmount, true);

            AddChild(PS);

            GD.Print("Particle At ", PS.Position);
        }
    }

    public void OnColorPickerButtonColorChanged(Color col)
    {
        //ParticleColour = GetNode<ColorPickerButton>("ColourPickerButton").Color;
        ParticleColour = col;
        //GD.Print(ParticleColour.ToString());
    }

    public void OnHSliderDragEnded(bool value_changed)
    {
        
    }

    public void OnHSliderValueChanged(float value)
    {
        ParticleAmount = (int)value;
    }
}

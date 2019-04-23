using Godot;
using System;

public class Sprite : Godot.Sprite
{
    private int mScale = 1;
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }
  //checking things
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
 public override void _Process(float delta)
 {
     bool upKey = Input.IsActionJustReleased("ui_up");
     bool downKey = Input.IsActionJustReleased("ui_down");

    if(upKey)
    {
        mScale += 1;
    }
    
    if(mScale)
    {
        mScale -= 1;
    }

    if(upKey || downKey)
    {
        Sprite sprite = GetNode(".") as Sprite;
        if(sprite != null)
        {
            sprite.SetScale(new Vector2(mScale, mScale));
        }
    }
 }
}

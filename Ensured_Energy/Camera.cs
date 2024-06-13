using Godot;
using System;

public class Camera:Camera2D {
    [Export] private NodePath targetPath;
    private Node2D target;

    public override void _Ready() {
        target = GetNode<Node2D>(targetPath);
    }

    public override void _Process(float delta) {
        if (target!=null){
            Position=Position.LinearInterpolate(target.Position, 0.1f);
        }
    }
}


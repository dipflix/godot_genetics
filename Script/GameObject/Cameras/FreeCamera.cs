using System;
using Godot;


namespace GeneticsMono.Script.GameObject.Cameras
{
    public partial class FreeCamera : Camera2D
    {
        [Export] public double LerpSpeed { get; set; }

        [Export] public double ZoomSpeed { get; set; } = 0.1;
        [Export] public double MaxZoom { get; set; } = 2;
        [Export] public double MinZoom { get; set; } = 0.5;


        private bool _dragging = false;

        private Vector2 _mouseStartPosition = Vector2.Zero;
        private Vector2 _screenStartPosition = Vector2.Zero;

        public override void _Input(InputEvent @event)
        {
            if (@event.IsAction("camera_zoom_plus")) ZoomIn();
            else if (@event.IsAction("camera_zoom_minus")) ZoomOut();

            if (@event is InputEventMouseButton eventMouseButton)
            {
                if (@event.IsAction("drag"))
                {
                    if (@event.IsPressed())
                    {
                        _mouseStartPosition = eventMouseButton.Position;
                        _screenStartPosition = Position;

                        if (!_dragging)
                            _dragging = true;
                    }
                    else
                    {
                        if (_dragging)
                            _dragging = false;
                    }
                }
            }
            else if (@event is InputEventMouseMotion eventMouseMotion && _dragging)
            {
                Position = (_mouseStartPosition - eventMouseMotion.Position) / Zoom + _screenStartPosition;
            }
        }

        private void ZoomIn()
        {
            Zoom = new Vector2(
                (float)Math.Min(MaxZoom, Zoom.X + ZoomSpeed),
                (float)Math.Min(MaxZoom, Zoom.Y + ZoomSpeed)
            );
        }


        private void ZoomOut()
        {
            Zoom = new Vector2(
                (float)Math.Min(MinZoom, Zoom.X - ZoomSpeed),
                (float)Math.Min(MinZoom, Zoom.Y - ZoomSpeed)
            );
        }


        private void _on_application_ready()
        {
            GD.Print("zxczxc");
        }
    }
}
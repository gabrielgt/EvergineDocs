using System;
using WaveEngine.Common.Input;
using WaveEngine.Common.Math;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Services;


namespace NetworkRecipe
{
    public class TapAppearBehavior : Behavior
    {
        private Input input;
        private Vector2? currentPosition;
        private MouseState currentMouseState;
        private TouchPanelState currentTouchState;

        [RequiredComponent]
        protected Transform2D transform;

        protected override void Initialize()
        {
            base.Initialize();
			
            this.input = WaveServices.Input;
        }

        protected override void Update(TimeSpan gameTime)
        {
            this.currentPosition = null;

            this.currentMouseState = this.input.MouseState;

            if (this.currentMouseState.IsConnected && this.currentMouseState.LeftButton == ButtonState.Pressed)
            {
                this.currentPosition = new Vector2(this.currentMouseState.X, this.currentMouseState.Y);
            }

            this.currentTouchState = this.input.TouchPanelState;
			
            if (this.currentTouchState.IsConnected && this.currentTouchState.Count > 0)
            {
                this.currentPosition = this.currentTouchState[0].Position;
            }

            if (this.currentPosition != null)
            {
                this.transform.LocalPosition = this.currentPosition.Value;

                this.transform.Opacity = 1f;
            }
            else
            {
                this.transform.Opacity = 0f;
            }
        }
    }
}
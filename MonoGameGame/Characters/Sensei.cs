

namespace MonoGameGame
{
    internal class Sensei : Basic2D
    {

        public float VerticalSpeed { get; private set; } = 100;
        public float HorizontalSpeed { get; private set; } = 400;
        public float JumpPower { get; private set; } = 300;
        public Vector2 Velocity { get; private set; }
        public Vector2 Gravity { get; private set; } = new Vector2(0, 9.8f);


        private bool CanJump;
        public Sensei() : base("2D/sensei", new Vector2(300, 300), new Vector2(16 * 3, 26 * 3))
        {
            CanJump = true;
        }

        public override void Update(float delta)
        {

            if (Keyboard.GetState().IsKeyDown(Keys.Up) && CanJump)
            {
                Velocity -= Vector2.UnitY * JumpPower * delta;
                CanJump = false;
            }

            if ((Pos + Velocity * VerticalSpeed * delta).Y > Main.ViewportBounds.Height - (26 * 3 / 2))
            {
                Pos.Y = Main.ViewportBounds.Height - (26 * 3 / 2);
                Velocity = new Vector2(0, 0);
                CanJump = true;
            }

            Velocity += Gravity * delta;
            Pos += GetHorizontal() * HorizontalSpeed * delta;
            Pos += Velocity * VerticalSpeed * delta;



            base.Update(delta);
        }
        private static Vector2 GetHorizontal()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                return new Vector2(-1, 0);
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                return new Vector2(1, 0);

            }
            return Vector2.Zero;
        }
    }
}

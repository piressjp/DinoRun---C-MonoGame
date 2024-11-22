using Microsoft.Xna.Framework;

namespace DinoGame.Models
{
    public class Player
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public bool IsJumping { get; private set; }

        private int _groundLevel;

        private int _speed;

        private int _fall = 5;

        public Player(int startX, int startY)
        {
            _speed = startX;

            PositionX = _speed;
            PositionY = startY;
            _groundLevel = startY;
            IsJumping = false;
        }

        public void Jump()
        {
            if (!IsJumping)
            {
                IsJumping = true;
            }
        }

        public void Update(GameTime gameTime)
        {
            if (IsJumping)
            {
                // Simula um pulo (movimento parabólico simples)
                PositionY -= 20; // Subir

                if (PositionY <= _groundLevel - 100) // Altura máxima
                {
                    IsJumping = false;
                }
            }
            else if (PositionY < _groundLevel)
            {
                if (_fall < 10)
                {
                    PositionY += _fall; // Cair de volta
                }
                else
                {
                    PositionY += 10;
                }

            }
        }

        public void IncreaseSpeed(int increment)
        {
            _speed += increment;
        }

        public void IncreaseFall(int increment)
        {
            _fall += increment;
        }
    }
}

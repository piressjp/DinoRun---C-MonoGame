using DinoGame.Application;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DinoGame.View
{
    public class GameInterface : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private GameService _gameService;
        private Texture2D _groundLineTexture;
        private Texture2D _playerRunTexture1;
        private Texture2D _playerRunTexture2;
        private Texture2D _playerJumpTexture;
        private Texture2D _obstacleTexture;
        private SpriteFont _font;

        private enum GameState { Menu, Playing, GameOver }
        private GameState _gameState;

        public GameInterface()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            _gameService = new GameService();
            _gameState = GameState.Menu;
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _groundLineTexture = new Texture2D(GraphicsDevice, 1, 1);
            _groundLineTexture.SetData(new[] { Color.Black }); // Define a cor da linha

            // Carregando os sprites do dinossauro
            _playerRunTexture1 = Content.Load<Texture2D>("Sprites/DinoRun1");
            _playerRunTexture2 = Content.Load<Texture2D>("Sprites/DinoRun2");
            _playerJumpTexture = Content.Load<Texture2D>("Sprites/DinoJump");

            _obstacleTexture = Content.Load<Texture2D>("Sprites/Obstacle");

            // Fonte do jogo
            _font = Content.Load<SpriteFont>("font");
        }


        protected override void Update(GameTime gameTime)
        {
            var keyboardState = Keyboard.GetState();

            switch (_gameState)
            {
                case GameState.Menu:
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        _gameState = GameState.Playing;
                    }
                    break;

                case GameState.Playing:
                    if (keyboardState.IsKeyDown(Keys.Space))
                    {
                        _gameService.Player.Jump();
                    }

                    _gameService.Update(gameTime);


                    if (_gameService.IsGameOver)
                    {
                        _gameState = GameState.GameOver;
                    }
                    break;

                case GameState.GameOver:
                    if (keyboardState.IsKeyDown(Keys.Enter))
                    {
                        _gameService.ResetGame();
                        _gameState = GameState.Menu;
                    }
                    break;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGray);
            _spriteBatch.Begin();

            switch (_gameState)
            {
                case GameState.Menu:
                    _spriteBatch.Draw(_playerRunTexture1, new Rectangle(365, 100, 80, 80), Color.White);
                    _spriteBatch.DrawString(_font, "DinoRun", new Vector2(355, 200), Color.Black);

                    _spriteBatch.DrawString(_font, "Press ENTER to start", new Vector2(300, 250), Color.Black);
                    break;

                    case GameState.Playing:
                        // Desenha a linha do chão
                        _spriteBatch.Draw(_groundLineTexture,
                            new Rectangle(0, 300, _graphics.PreferredBackBufferWidth, 5), // Largura igual à da tela, altura de 5px
                            Color.Brown); // Cor do chão

                        // Desenha jogador
                        var player = _gameService.Player;
                        Texture2D currentPlayerTexture;

                        if (player.IsJumping)
                        {
                            currentPlayerTexture = _playerJumpTexture;
                        }
                        else
                        {
                            // Alterna entre Run1 e Run2
                            var frame = (int)(gameTime.TotalGameTime.TotalMilliseconds / 200) % 2; // Troca a cada 200ms
                            currentPlayerTexture = frame == 0 ? _playerRunTexture1 : _playerRunTexture2;
                        }

                        _spriteBatch.Draw(currentPlayerTexture, new Rectangle(player.PositionX, player.PositionY, 80, 80) , Color.White);

                        // Desenha os obstáculos
                        foreach (var obstacle in _gameService.Obstacles)
                        {
                            var obstacleTexture = _obstacleTexture; // Por enquanto usando o primeiro tipo de obstáculo
                            _spriteBatch.Draw(obstacleTexture, new Rectangle(obstacle.PositionX, 300 - obstacle.Height, obstacle.Width, obstacle.Height), Color.White);
                        }

                        // Exibe pontuação
                        _spriteBatch.DrawString(_font, $"SCORE: {_gameService.Score}", new Vector2(350, 30), Color.Goldenrod);
                     break;

                case GameState.GameOver:
                    _spriteBatch.DrawString(_font, "Game Over", new Vector2(345, 100), Color.Red);
                    _spriteBatch.DrawString(_font, $"Final Score: {_gameService.Score}", new Vector2(335, 150), Color.Black);
                    _spriteBatch.DrawString(_font, "Press ENTER to restart", new Vector2(300, 200), Color.Black);
                    break;
            }

            _spriteBatch.End();
            base.Draw(gameTime);
        }

    }
}

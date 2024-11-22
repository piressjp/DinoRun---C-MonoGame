using DinoGame.Domain;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace DinoGame.Application
{
    public class GameService
    {
        public Player Player { get; private set; }
        public List<Obstacle> Obstacles { get; private set; }
        public int Score { get; private set; }
        public bool IsGameOver { get; private set; }

        private int obstacleSpeed = 5;    // Velocidade inicial dos obstáculos
        private int obstacleFrequency = 100; // Frequência inicial de geração de obstáculos
        private int elapsedTime = 0;     // Tempo decorrido em milissegundos

        private int _obstacleSpawnTimer;


        public GameService()
        {
            ResetGame();
        }

        public void Update(GameTime gameTime)
        {
            if (IsGameOver) return;

            elapsedTime += gameTime.ElapsedGameTime.Milliseconds;
            Player.Update(gameTime);
            MoveObstacles(gameTime);
            DetectCollisions();

            // Atualizar pontuação com base no tempo
            Score = elapsedTime / 200; // 1 ponto a cada 100ms

            // Dificuldade crescente
            UpdateDifficulty();
        }

        private void UpdateDifficulty()
        {
            if (elapsedTime % 5000 == 0) // A cada 5 segundos
            {
                Player.IncreaseSpeed(5); // Aumenta a velocidade do jogador

                Player.IncreaseFall(1); 

                obstacleSpeed++;              // Aumentar a velocidade
                if (obstacleFrequency > 50)  // Limitar frequência mínima
                    obstacleFrequency -= 5;  // Obstáculos aparecem mais frequentemente
            }
        }

        private void MoveObstacles(GameTime gameTime)
        {
            _obstacleSpawnTimer += (int)gameTime.ElapsedGameTime.TotalMilliseconds;

            var random = new Random();
            // Lógica de spawn de obstáculos
            if (_obstacleSpawnTimer > random.Next(1000, 5000)) 
            {
                SpawnObstacle();
                _obstacleSpawnTimer = 0;
            }

            foreach (var obstacle in Obstacles)
            {
                obstacle.PositionX -= 5; // Movimento dos obstáculos da direita para a esquerda
            }

            // Remove obstáculos que saem da tela
            Obstacles.RemoveAll(o => o.PositionX < -50);
        }

        private void SpawnObstacle()
        {
            // Adiciona um novo obstáculo (exemplo de cacto)
            var obstacle = new Obstacle
            {
                PositionX = 800, // Começa à direita da tela
                PositionY = 300, // Altura do chão
                Width = 25,
                Height = 70
            };

            Obstacles.Add(obstacle);
        }

        private void DetectCollisions()
        {
            Rectangle playerRectangle = new Rectangle(Player.PositionX, Player.PositionY, 70, 70);

            foreach (var obstacle in Obstacles)
            {
                Rectangle obstacleRectangle = new Rectangle(obstacle.PositionX, 300 - obstacle.Height, obstacle.Width, obstacle.Height);

                if (playerRectangle.Intersects(obstacleRectangle))
                {
                    IsGameOver = true;
                    break;
                }
            }
        }


        public void ResetGame()
        {
            Player = new Player(30, 230);
            Obstacles = new List<Obstacle>();
            Score = 0;
            obstacleSpeed = 5;
            obstacleFrequency = 100;
            elapsedTime = 0;
            IsGameOver = false;
        }

        public int GetElapsedTimeInSeconds() => elapsedTime / 1000;
    }
}

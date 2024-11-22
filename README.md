# Dino Game
- Um jogo simples inspirado no clássico jogo do dinossauro offline do Google Chrome. Desenvolvido em C# usando a biblioteca MonoGame, este projeto é uma introdução ao desenvolvimento de jogos 2D, apresentando mecânicas básicas como movimentação, colisões e lógica de pontuação.

# Objetivo do Jogo
- O objetivo do jogador é sobreviver o maior tempo possível, desviando de obstáculos enquanto o dinossauro corre automaticamente. A dificuldade aumenta conforme o tempo passa, com os obstáculos surgindo mais rapidamente e a velocidade do dinossauro subindo.

# Finalidade do Projeto
Este projeto foi desenvolvido como um exercício educacional para:

- Praticar o uso da biblioteca MonoGame.
- Entender os fundamentos do desenvolvimento de jogos 2D.
- Demonstrar o uso de boas práticas de programação em um contexto de jogos.
- Aprender sobre colisões, animações e loops de jogo.

# Padrão de Projeto
O projeto segue o padrão de arquitetura MVC (Model-View-Controller) simplificado:

- Model: Representa as entidades principais do jogo (Player, Obstacle).
- View: Renderiza gráficos na tela e lida com entradas do usuário.
- Controller: A lógica do jogo está no GameService, responsável por atualizar o estado do jogo.

# Stack
- Linguagem: C#
- Framework: MonoGame
- Ferramentas Adicionais:
    - ```Visual Studio``` para desenvolvimento.
    - ```OpenGameArt``` para sprites (arte do jogo).
    - ```Content Pipeline Tool``` do MonoGame para gerenciar e compilar assets gráficos.

# Executar o Projeto
## Requisitos
Antes de executar o projeto, certifique-se de que possui:

- .NET SDK (versão 6.0 ou superior).
- MonoGame Framework (instale o MonoGame em seu ambiente de desenvolvimento).
- Visual Studio (ou outra IDE que suporte projetos C#).
- Bibliotecas adicionais (já incluídas no projeto).

## Passo a Passo

### 1. Clone o Repositório
No terminal, execute:

```bash
git clone https://github.com/SeuUsuario/DinoGame.git
cd DinoGame
```

### 2. Configure o Ambiente
Certifique-se de que você tem o MonoGame instalado. Se ainda não, instale-o usando o comando:

```bash
dotnet tool install --global dotnet-mgcb
```
### 3. Compile os Assets do Jogo
Use o Content Pipeline Tool do MonoGame para compilar os sprites:
  - Abra o arquivo de conteúdo do projeto ```Content.mgcb``` na pasta Content, compile e salve.

### 4. Execute o Projeto
Abra o projeto na IDE e execute o projeto.

# Controles
- Space: Faz o dinossauro pular.
- Enter: Reinicia o jogo após o Game Over.

# Contribuição
Se você deseja contribuir para este projeto:

1. Faça um fork.
2. Crie um branch para sua feature (git checkout -b minha-feature).
3. Faça commit de suas alterações (git commit -m "Adiciona minha feature").
4. Envie o branch (git push origin minha-feature).
5. Abra um Pull Request.

# Créditos
**Arte**: Sprites do dinossauro obtidos no OpenGameArt.

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
O projeto segue o padrão de arquitetura MVP (Model-View-Presenter) simplificado:

- Model: Representa as entidades principais do jogo (Player, Obstacle).
- View: Renderiza gráficos na tela e lida com entradas do usuário.
- Presenter: A lógica do jogo está no GameService, responsável por atualizar o estado do jogo.

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
   
# Time de desenvolvimento
- Pedro Domingues 29443768
- Kaique Santos 30063272
- João Paulo Costa Pires 29291135
- Giovana Costa 31496636

# Checklist de Desenvolvimento

## Fase 1: 

### Análise [ Done ] 

    [ Kaique ] Problema selecionado e definido claramente.
    [ Kaique ]  Compreensão aprofundada da natureza e desafios do problema.
    [ Kaique ] Modelo matemático ou teórico desenvolvido para representar o problema.

## Fase 2: 
### Planejamento [ Done ] 

     [ Pedro ] Objetivos do algoritmo definidos com clareza.
     [ Pedro ] Métricas para avaliação de eficiência do algoritmo estabelecidas.
     [ João Paulo ] Estratégia geral de resolução do problema proposta.
     [ João Paulo ] Estrutura geral do algoritmo esboçada.
     [ João Paulo ] Casos limite ou situações especiais identificados.
     [ João Paulo ] Análise teórica realizada para verificar a correção do algoritmo.

## Fase 3: 
### Desenho [ Done ] 

     [ Giovana ] Análise de complexidade realizada para avaliar a eficiência teórica do algoritmo.
     [ Giovana ] Pontos críticos do algoritmo identificados para otimização, se necessário.

## Fase 4: 

 ### Programação e Teste [ Done ] 

     [ João Paulo ] Algoritmo traduzido com precisão em código de programação.
     [ João Paulo ] Código de programação escrito de forma clara e organizada.
     [ João Paulo ] Testes rigorosos realizados em uma variedade de casos de teste.
     [ Kaique ] Casos limite e situações especiais testados.
     [ Kaique e João Paulo ] Erros e problemas durante o teste de programa identificados e corrigidos.

 ### Documentação e Avaliação do Projeto [ Done ] 

     [ João Paulo ] Documentação completa, incluindo especificação do algoritmo e análise de complexidade.
     [ Giovana ] Documentação revisada para clareza e rigor técnico.
     [ Kaique ] Avaliação da eficácia do algoritmo em termos de tempo de execução, uso de recursos e precisão na resolução do problema.
     [ Giovana ] Avaliação da colaboração da equipe e cumprimento dos prazos.

 ### Apresentação e Conclusão do Projeto [ Done ] 

     [ João Paulo ] Apresentação do projeto preparada com informações claras e objetivas.
     [ João Paulo ] Conclusões do projeto destacando os resultados e aprendizados.
     [ João Paulo ] Discussão sobre o projeto e respostas a perguntas da audiência.

# Créditos
**Arte**: Sprites do dinossauro obtidos no OpenGameArt.

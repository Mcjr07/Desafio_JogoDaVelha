# Desafio_JogoDaVelha da academia UFN/ATOS


 No primeiro jogo no arquivo program, os jogadores alternam entre '1' e '2', e o jogo continua até que um jogador vença ou haja um empate. 
 Os jogadores fazem suas jogadas escolhendo uma posição no tabuleiro 3x3, e o objetivo é conseguir três de suas marcas em linha horizontal, vertical ou diagonal.

Componentes:
Variáveis:
tabuleiro - Uma matriz 3x3 que representa o tabuleiro do jogo.
jogadorAtual - Uma variável que mantém o jogador atual ('1' ou '2').
jogoEncerrado - Uma variável booleana que indica se o jogo terminou.

Métodos:

Main() - A função principal que controla o loop do jogo e permite que os jogadores joguem.
InicializarTabuleiro() - Inicializa o tabuleiro com espaços em branco.
ExibirTabuleiro() - Exibe o estado atual do tabuleiro na tela.
RealizarJogada() - Permite que o jogador atual faça uma jogada, inserindo as coordenadas da linha e da coluna.
VerificarVitoria() - Verifica se o jogador atual ganhou o jogo (três em linha).
VerificarEmpate() - Verifica se houve um empate no jogo.
TrocarJogador() - Alterna o jogador atual entre '1' e '2'.

Uso:
O programa começa com o jogador '1' e alterna entre os jogadores até que um deles vença ou haja um empate.
Os jogadores fazem suas jogadas inserindo as coordenadas da linha (1-3) e da coluna (1-3).
O jogo exibe o tabuleiro após cada jogada e informa o resultado do jogo.
Após o término de um jogo, o programa pergunta se os jogadores desejam jogar novamente. Digitar 'S' reiniciará o jogo.
Esse é um jogo da velha simples em C# que permite que dois jogadores joguem em um console.


----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Jogo da Velha

PLAY vs CPU 

Neste segundo jogo, jogador pode competir contra uma CPU. O jogador começa como "2" e a CPU como "1". O jogo continua até que um dos jogadores vença ou haja um empate. O jogador faz suas jogadas inserindo as coordenadas da linha e da coluna, enquanto a CPU realiza suas jogadas aleatoriamente.

Componentes:
Variáveis:
tabuleiro - Uma matriz 3x3 que representa o tabuleiro do jogo.
jogadorAtual - Uma variável que mantém o jogador atual ('1' para a CPU e '2' para o jogador humano).
jogadorHumano - Uma variável que armazena o identificador do jogador humano ('2').
jogoEncerrado - Uma variável booleana que indica se o jogo terminou.
rand - Uma instância da classe Random para gerar números aleatórios.

Métodos:
Main() - A função principal que controla o loop do jogo, permitindo que o jogador humano e a CPU façam jogadas.
InicializarTabuleiro() - Inicializa o tabuleiro com espaços em branco.
ExibirTabuleiro() - Exibe o estado atual do tabuleiro na tela.
RealizarJogadaPlay() - Permite que o jogador humano faça uma jogada, inserindo as coordenadas da linha e da coluna.
RealizarJogadaCPU() - Permite que a CPU faça uma jogada aleatória no tabuleiro.
VerificarVitoria() - Verifica se o jogador atual ou a CPU ganhou o jogo (três em linha) ou se houve um empate.
TrocarJogador() - Alterna o jogador atual entre '1' e '2'.

Uso:
O jogo começa com o jogador humano como "2" e a CPU como "1".
Os jogadores fazem suas jogadas alternadamente até que um deles vença ou haja um empate.
O jogador humano insere as coordenadas da linha (1-3) e da coluna (1-3) para fazer suas jogadas.
A CPU realiza suas jogadas aleatoriamente.
O jogo exibe o tabuleiro após cada jogada e informa o resultado do jogo.
Após o término de um jogo, o programa pergunta se os jogadores desejam jogar novamente. Digitar 'S' reiniciará o jogo.

Esta é uma versão do jogo da velha que permite jogar contra uma CPU que faz jogadas aleatórias, tornando-o um desafio interessante

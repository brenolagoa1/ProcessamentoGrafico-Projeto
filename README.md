# ProcessamentoGrafico-Projeto
Repositório destinado a realização do trabalho da disciplina de Processamento Gráfico.

## Execução
Para rodar o programa é necessário seguir os seguintes passos:
1. Instalar o ambiente Python mais recente, encontrado neste [link](https://www.python.org/downloads/)
2. Baixar o projeto em .zip pelo Github ou clonar o projeto pelo Terminal com o comando:<br/> ``git clone https://github.com/MatheusFernando13/ProcessamentoGrafico-Projeto.git``
3. Abrir a pasta ``ProcessamentoGrafico-Projeto`` no explorador de arquivos e depois abrir ``PG-Grupo3-PP3-Compilado`` no terminal do seu computador
4. Digitar o comando ``py -m http.server 8000`` no terminal
5. Entrar no Broswer de sua preferência e digitar o caminho ``localhost:8000``

Após isso, o projeto feito pelo grupo irá carregar dentro do navegador.
<div align="center">
  <figure>
    <figcaption><b>Imagem da execução do projeto</b></figcaption>
	<img src="https://github.com/MatheusFernando13/ProcessamentoGrafico-Projeto/blob/main/Imagens/print_projeto_execução.png" alt="Uma imagem impressionante">
</figure>
  </div>


## PP3 - Criação de um cenario 3D de um tabuleiro de xadrez e inserção de Peças nele.

O Unity já disponibiliza quando criamos um projeto o cenário 3D, uma câmera padrão e uma iluminação.

### O tabuleiro
Para simular o tabuleiro criamos um objeto 3D denominado plane disponibilizado pelo Unity, que depois foi renomeado como Tabuleiro. Por padrão quando criamos o plano sua origem estava localizada no ponto (373.82, 276.02, 860.06) para facilitar a sua manipulação realizamos a translação para move-lo até a origem do mundo (0, 0, 0). A escala do plano que inicialmente era de (x = 1, y = 1, z = 1) foi aumentada para (x = 80, y = 1, z =80) somente os eixos x e z do plano foram aumentados utilizando a escala, uma vez que o tabuleiro é um plano, desse modo cada posição do tabuleiro passou a ter um tamanho 10x10 unidades de medida. Em seguida aplicamos uma textura ao plano para que ele realmente tivesse a coloração de um tabuleiro de xadrez. Não foi necessária a aplicação de uma rotação ao plano.

**Observação:** na perspectiva de visão dos jogadores em relação ao tabuleiro consideramos que  os eixos do sistema de coordenadas (considerando o plano xz) do mundo estão dispostos de modo que o movimento das peças na horizontal é representado pelo eixo z e a movimentação das peças na vertical é representada pelo eixo x. O eixo y não faz muita diferença, pois as peças não vão voar sobre o tabuleiro, apenas alteramos o valor de y das peças para 1, ficando 1 unidade acima do tabuleiro.

### Movimentação das peças sob a perspectiva dos jogadores em relação ao tabuleiro:

**Peças Brancas**
- Mover para a esquerda: basta aplicar a translação adicionando uma constante positiva a coordenada z da peça.
- Mover para a direita: basta aplicar a translação adicionando uma constante negativa a coordenada z da peça.
- Mover para a frente: basta aplicar a translação somando uma constante positiva a coordenada x.
- Mover para trás: basta aplicar a translação somando uma constante negativa a coordenada x.

**Peças Pretas**
- Mover para a esquerda: basta aplicar a translação somando uma constante negativa a coordenada z.
- Mover para a direita: basta aplicar a translação somando uma constante positiva a coordenada z. 
- Mover para a frente: basta aplicar a translação somando uma constante negativa a coordenada x.
- Mover para trás: basta aplicar a translação somando uma constante positiva a coordenada x.  

### Adição das peças no mundo e o seu correto posicionamento no tabuleiro.
**Observação:** todas as peças foram obtidas do [TURBOSQUID](https://www.turbosquid.com/) um site que disponibiliza objetos 3D para serem utilizados em diferentes ferramentas.

- Rainha Branca: Quando adicionamos essa peça ao mundo ela foi posicionada na origem dele (0, 0, 0) o que de certo modo ajudou na disposição da peça dentro do tabuleiro, antes de realizar a translação para a posição correta da rainha branca dentro do tabuleiro realizamos a modificação no tamanho do objeto que era muito pequeno quando comparado com o tabuleiro, fizemos varios testes para verificar qual era o melhor tamanho para a peça e decidimos escolher a constante 5 que quando multiplicada as coordenadas do objeto resultou em uma escala de 5x5x5. Em seguida realizamos a movimentação da peça até a sua posição dentro do tabuleiro para isso somamos -349 de x e somamos -50 a z (moveu para tras e para a direita na perspectiva do jogador que possui as peças branca). 
- Rainha Preta: Possui as mesmas caracteristicas iniciais da rainha preta, a unica coisa que muda são os valores atribuidos as coordenadas x e z que nesse caso foi +349 e -50 respectivamente (moveu para traz e para a esquerada na perspectiva do jogador que possui as peças pretas) 
- Rei Branco: mesmo processo das rainhas, porem o valor de x e z durante a translação foi de -349 e 50 respectivamente (moveu para traz e para a esquerda).
- Rei Preto: fez uma translação de +349 no eixo x e +50 no eixo x (moveu para traz e para a direita).
- Torres: Mesmo processo para cada uma das quatro torres, aumento de escala de 1x1x1 para 5x5x5 a unica diferenças em cada uma é a translação realizada, no caso da torre branca da esquerda ela saiu da origem (0, 0, 0) para a posição de coordenada (-349, 1, 349), no caso da torre branca da direita saiu da origem (0, 0, 0) para (-349, 1, 349), a torre preta que fica na direita saiu da origem (0, 0, 0) para o ponto (349, 1, 349) e a torre preta da esquerda saiu da origem para o ponto (349, 1, -349).
- Cavalos: Aumento da escala de 1x1x1 (padrão) para 5x5x5 a fim de condizer com as outras peças. Todos os cavalos saíram da origem e se deslocaram 345 em X e 248 em Z. Ao final, os cavalos brancos ficaram com a posição (-345, 0, -248) para o da esquerda e (-345, 0, 248) para o da direita, e os pretos ficaram com (345, 0, -248) na esquerda e (345, 0, 248) na direita. Também foi necessário adicionar o material cor-preta criado às peças pretas e rotacioná-las em 180° no eixo Y
- Bispos: Foi feito o mesmo que os Cavalos, houve um aumento da escala de 1x1x1 (padrão) para 5x5x5 a fim de condizer com as outras peças. Todos os bispos saíram da origem e se deslocaram 345 em X e 150 em Z. Ao final, os bispos brancos ficaram com a posição (-345, 0, -150) para o da esquerda e (-345, 0, 150) para o da direita, e os pretos ficaram com (345, 0, -150) na esquerda e (345, 0, 150) na direita. Também foi necessário adicionar o material cor-preta criado às peças pretas.
- Peões: Mesmo processo foi realizado para os 16 peões, aumentando a escala de 1x1x1 para 5x5x5, a unica diferença entre eles são as translações realizadas, todos sairam da origem (0,0,0) indo para outras posições onde a coordenada y é 1 para todos os casos. Todos os peões brancos(1 a 8) foram para coordenadas com o X=-249, mudando unicamente os valores de Z, que assumiu os valores: -349;-249;-149;-50;349;249;149;50. Já os peões pretos(9 - 16) foram para coordenadas com X=249, mudando unicamente os valorez de Z, que foram: -349;-249;-149;-50;349;249;149;50; tal como para as peças brancas.

### A câmera
Quando o projeto foi criado a câmera estava posicionada na coordenada (0, 1, -10) do mundo, sua projeção era do tipo perspectiva, seu ângulo de visão era de 60° e sua direção de projeção estava sob o eixo z. Para projetar a cena sob o ponto de vista do jogador das peças branca decidimos mudar a camera de posição então aplicamos a translação, para que ela saisse da posição de coordenadas (0, 1, -10) para a posição de coordenadas (-550, 450, 16). Quanto a projeção mantemos a do tipo perspectiva pala simular a realiade. No caso da direção de projeção tivemos que mudar do eixo z para o eixo x devido a disposição do tabuleiro no mundo, para fazer isso aplicamos a rotação de 90° sob o eixo y, além disso aplicamos uma rotação de 45° sob o eixo x para que o eixo de projeção nesse caso o x focasse o tabuleiro, uma vez que a camera estava acima do tabuleiro. Para que todo o tabuleiro fosse projetado modificamos o seu campo de visão de 60° para 61°.


## PP4

### As câmeras
Ao todo existem 4 cameras disposta no mundo de modo que cada uma possa capturar uma determinada visão do tabuleiro. 
- **Camera 0**: possui a projeção do tipo perspectiva e está localizada na posição de coordenadas (-520, 460, 0) do mundo, possui um angulo de visão de 82°, uma inclinação de 55° no eixo x e 90° no eixo y.
- **Camera 1:** possui a projeção do tipo perspectiva e está localizada na posição de coordenadas (520, 460, 0) do mundo, possui um angulo de visão de 82°, uma inclinação de 55° no eixo x e -90° no eixo y.
- **Camera 2:** possui a projeção do tipo paralela, está localizada na posição de coordenadas (0, 450, 0) do mundo, possui um tamanho de campo de visão de 550, uma inclinação de 90° no eixo x. Ela possui uma visão de cima do tabuleiro.
- **Camera 3:** possui a projeção do tipo paralela, está localizada na posição de coordenadas (0, 400, 450) do mundo, possui um tamanho de 450, uma inclinação de 15° no eixo x e 180° no eixo y. Inicialmente ela possui uma visão lateral do tabuleiro. 
Para mudar de uma câmera para outra criamos um script que permite ao usuário da aplicação realizar essa ação ao clicar na tecla **space** do teclado.

### Os movimentos
Para realizar os movimentos foi necessario criar um script chamado RotacionaTabuleiro, o qual tem como função rotacionar o tabuleiro e as peças em conjunto, para isso foi utilizado o sistema de hierarquia do unity que ao colocarmos as peças na hierarquia do tabuleiro por consequência irão se movimentar em conjunto com o tabuleiro, de forma que não fossem perdidas as coordenadas de suas posições dentro do tabuleiro(casas). 
Essa rotação para que seja iniciada é necessario clicar na tecla P que serve para iniciar e parar o movimento, movendo automaticamente a primeira peça(peão preto), única peça com movimento dependente do tabuleiro estar rodando. Em sequencia para mover as outras peças, que podem se mover com o tabuleiro movendo ou parado, são primeiramente a Dama(tecla D), depois o Rei(tecla R) e por fim a Torre(tecla T), sendo necessário clicar nas teclas nessa ordem, para que possam se mover corretamente como se os jogadores estivessem jogando. Para o movimento dessas peças foi aplicada, em cada quadro, a técnica de rotação até sua posição destino correspondente e também foi aplicada, em cada quadro, a técnica de translação para o tabuleiro



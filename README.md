# ProcessamentoGrafico-Projeto
Repositório destinado a realização do trabalho da disciplina de Processamento Gráfico.

## Execução
Para rodar o programa é necessário seguir os seguintes passos:
1. Instalar o ambiente Python mais recente, encontrado neste [link](https://www.python.org/downloads/)
2. Baixar o projeto em .zip pelo Github ou clonar o projeto pelo Terminal com o comando:<br/> ``git clone https://github.com/MatheusFernando13/ProcessamentoGrafico-Projeto.git``
3. Abrir a pasta ``ProcessamentoGrafico-Projeto`` no explorador de arquivos e depois abrir ``PG-Grupo3-PP3-Compilado`` no terminal do seu computador
4. Digitar o comando ``py -m http.server 8000`` no terminal
5. Entrar no Broswer de sua preferência e digitar o caminho ``localhost:8000"

Após isso, o projeto feito pelo grupo irá carregar dentro do navegador.


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
- Mover para traz: basta aplicar a translação somando uma constante negativa a coordenada x.

**Peças Pretas**
- Mover para a esquerda: basta aplicar a translação somando uma constante negativa a coordenada z.
- Mover para a direita: basta aplicar a translação somando uma constante positiva a coordenada z. 
- Mover para a frente: basta aplicar a translação somando uma constante negativa a coordenada x.
- Mover para traz: basta aplicar a translação somando uma constante positiva a coordenada x.  

### Adição das peças no mundo e o seu correto posicionamento no tabuleiro.
**Observação:** todas as peças foram obtidas do TURBOSQUID um site que disponibiliza objetos 3D para serem utilizados em diferentes ferramentas.

- Rainha Branca: Quando adicionamos essa peça ao mundo ela foi posicionada na origem dele (0, 0, 0) o que de certo modo ajudou na disposição da peça dentro do tabuleiro, antes de realizar a translação para a posição correta da rainha branca dentro do tabuleiro realizamos a modificação no tamanho do objeto que era muito pequeno quando comparado com o tabuleiro, fizemos varios testes para verificar qual era o melhor tamanho para a peça e decidimos escolher a constante 5 que quando multiplicada as coordenadas do objeto resultou em uma escala de 5x5x5. Em seguida realizamos a movimentação da peça até a sua posição dentro do tabuleiro para isso somamos -349 de x e somamos -50 a z (moveu para tras e para a direita na perspectiva do jogador que possui as peças branca). 
- Rainha Preta: Possui as mesmas caracteristicas iniciais da rainha preta, a unica coisa que muda são os valores atribuidos as coordenadas x e z que nesse caso foi +349 e -50 respectivamente (moveu para traz e para a esquerada na perspectiva do jogador que possui as peças pretas) 
- Rei Branco: mesmo processo das rainhas, porem o valor de x e z durante a translação foi de -349 e 50 respectivamente (moveu para traz e para a esquerda).
- Rei Preto: fez uma translação de +349 no eixo x e +50 no eixo x (moveu para traz e para a direita).
- Torres: Mesmo processo para cada uma das quatro torres, aumento de escala de 1x1x1 para 5x5x5 a unica diferenças em cada uma é a translação realizada, no caso da torre branca da esquerda ela saiu da origem (0, 0, 0) para a posição de coordenada (-349, 1, 349), no caso da torre branca da direita saiu da origem (0, 0, 0) para (-349, 1, 349), a torre preta que fica na direita saiu da origem (0, 0, 0) para o ponto (349, 1, 349) e a torre preta da esquerda saiu da origem para o ponto (349, 1, -349).
- Cavalos: Aumento da escala de 1x1x1 (padrão) para 5x5x5 a fim de condizer com as outras peças. Todos os cavalos saíram da origem e se deslocaram 345 em X e 150 em Z. Ao final, os cavalos brancos ficaram com a posição (-345, 0, -150) para o da esquerda e (-345, 0, 150) para o da direita, e os pretos ficaram com (345, 0, -150) na esquerda e (345, 0, 150) na direita. Também foi necessário adicionar o material cor-preta criado às peças pretas e rotacioná-las em 180° no eixo Y
- Peões: Mesmo processo foi realizado para os 16 peões, aumentando a escala de 1x1x1 para 5x5x5, a unica diferença entre eles são as translações realizadas, todos sairam da origem (0,0,0) indo para outras posições onde a coordenada y é 1 para todos os casos. Todos os peões brancos(1 a 8) foram para coordenadas com o X=-249, mudando unicamente os valores de Z, que assumiu os valores: -349;-249;-149;-50;349;249;149;50. Já os peões pretos(9 - 16) foram para coordenadas com X=249, mudando unicamente os valorez de Z, que foram: -349;-249;-149;-50;349;249;149;50; tal como para as peças brancas.


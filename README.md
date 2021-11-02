# ProcessamentoGrafico-Projeto
Repositório destinado a realização do trabalho da disciplina de Processamento Gráfico.

PP3 - Criação de um cenario 3D de um tabuleiro de xadrez e inserção de Peças nele.

O Unity já disponibiliza quando criamos um projeto o cenário 3D, uma câmera padrão e uma iluminação.

Para simular o tabuleiro criamos um objeto 3D denominado plane disponibilizado pelo Unity, que depois foi renomeado como Tabuleiro. Por padrão quando criamos o plano sua origem estava localizada no ponto (373.82, 276.02, 860.06) para facilitar a sua manipulação realizamos a translação para translada-lo até a origem do mundo (0, 0, 0). A escala do plano que inicialmente era de 1x1x1 foi aumentada para 80x1x80 (somente os eixos x e z aumentam) utilizando a escala, desse modo cada posição do tabuleiro passou a ter um tamanho 10x10. Em seguida aplicamos uma textura ao plano para que ele realmente tivesse a coloração de um tabuleiro de xadrez. Não foi necessária a aplicação de uma rotação ao plano.

Dama: Essa peça foi obtida do TURBOSQUID um site que disponibiliza objetos 3D para serem utilizados em diferentes ferramentas. Inicialmente as coodernadas de origem desse objeto quando convertido para o sistema de coordenadas do mundo era (-415, -43, 883) o que não era o ideal para o nosso projeto, então tivemos que translada-lo para a origem do mundo para em seguida translada-lo novamente até a sua respectiva posição no tabuleiro, no fim sua origem ficou localizada no ponto (-363, 94, 50). Além disso o objeto já veio rotacionado 90° em relação ao eixo x para manter a peça em pé, caso ela viesse com 0° a peça estaria deitada. Uma outra alteração foi na escala da peça para que ela ocupasse todo o espaço da sua posição no tabuleiro, por padrão sua escala era de 1x1x1 e aumentamos ela para 1,29x1,29x1,29.



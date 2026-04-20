# Steal-The-Thing---TPO-Parcial

El Juego se llama Steal The Thing! Este trata de que el jugador sea el mayor ladron de casas de la ciudad. El objetivo es sencillo, el jugador debe encontrar los objetos de valor que habra por las casas de los ciudadanos y tendra que llevarselas sin ser detectado, osea, debera jugar mucho con su sigilo y el entorno de las casas. Por ahora, el unico enemigo que hay es un perro, el cual tendra un movimiento de patrulla particular por zonas de la casa.

Sistemas de IA implementados en esta instancia:
Line Of Sight (Para detectar al jugador cuando este cerca del enemigo).
FSM (Chase, Idle y Patrol) Estos son los estados que por ahora tiene el enemigo, Chase es en el momento el cual el enemigo tiene en su rango de vision al jugador y lo persigue. Idle, es cuando tras dar un par de vueltas en su patrulla, se queda quieto en uno de los puntos del recorrido. Patrol, es el momento el cual el enemigo se mueve patrullando zonas definididas previamente.

Controles:

WASD para moverse.
R para reiniciar al perder o ganar.
Esc para menu de pausa.
Click izquierdo para interactuar con los botones de los menus.

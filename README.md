# SelfHost
Exemplo de aplicação self-host (WebApi rodando em um console application)

A ideia a partir deste projeto é que possamos hospedar nossas aplicações em uma outra aplicação host 
(uma Console Application ou um Windows Service) lógico ainda teremos que efetuar a instalação no server mas 
independente de um IIS.

Com isso você ganha a possibilidade de rodar sua aplicação sob seu próprio processo sem se preocupar com o 
desempenho de aplicações que estão no mesmo Pool de aplicativos e não travar como acontece muitas vezes quando 
ocorre sobrecarga no processo do IIS.

Na prática esse exemplo cria uma aplicação com um servidor embarcado o que pode ser bem bacana para pequenas 
aplicações dispensando a necessidade de ter que hospedar no IIS ou outro web server.

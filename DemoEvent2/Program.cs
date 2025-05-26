
using DemoEvent2.Models;

// Création de l'écouteur d'événéments
EventListener eventListener = new EventListener();


// Création des boutons
LeftButton leftButton = new LeftButton();
RightButton rightButton = new RightButton();


// Abonnement de l'écouteur d'événement aux boutons créés
eventListener.Subscribe(leftButton);
eventListener.Subscribe(rightButton);

// Simuler les clics
leftButton.Click();
rightButton.Click();
rightButton.Click();
rightButton.Click();
# Distributeur automatique de boisson chaude

Ce projet est une application console en C# qui permet de commander des boissons à partir d'une liste prédéfinie de recettes.

## Description

L'application offre les fonctionnalités suivantes :

- Afficher la liste des boissons disponibles.
- Permettre à l'utilisateur de sélectionner une boisson à commander en entrant son numéro.
- Calculer et afficher le prix de vente de la boisson sélectionnée.

Les prix de vente des boissons sont calculés en fonction des coûts des ingrédients et d'une marge bénéficiaire de 30% modulable dans le code.

## Fichiers

- `Ingredient.cs` : Définition de la classe `Ingredient` représentant un ingrédient avec son nom et son coût.
- `Recipe.cs` : Définition de la classe `Recipe` représentant une recette de boisson avec ses ingrédients et leurs quantités.
- `Commande.cs` : Définition de la classe `Commande` pour la gestion des commandes de boissons.
- `Vente.cs` : Définition de la classe `Vente` pour le calcul et la gestion des prix de vente des boissons.
- `Program.cs` : Point d'entrée de l'application, contient la logique principale de l'interface console.

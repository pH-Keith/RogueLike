# RoguelikeRPG

* António Louro - a21702439
* Paulo Ramires - a21701507

## Phase Implemented
We implemented up to phase 3, however there is a good amount of code that is created for the other phases however it is not fully implemented. For example the structure for weapon damage etc, has all been coded just hasn't been implemented.
## Contribution
Paulo Ramires - He contributed on Render, Grid, InputManager, GameLoop, ObjectList	.
António Louro - he contributed on Character, Food, GameObject, IAttackPower, IHP, IPos, Item, Map, NPC, Player, Tile, Trap, Weapon.

## Our solution

We created a grid class, with an bi-dimensional array of Tiles (these tiles being another class) and in these tiles are a stack of GameObjects, which eases the organization of our work by making all of the objects that are interact-able have a relationship with this class.

### Architecture

The project is separated by 19 files, all of which have their own uses without much overlapping, 17 of these are classes and 2 of them are Interfaces.

### Algorithms
UML of the Program:

![UML of the program.](https://lh6.googleusercontent.com/oMt9IFA4P3DNnWOhzUItt8YGc_--PVGWZx9Z1KoeMw_I8EEFOrEdpZBkKzYe0moTqmIUXXWhn_QmIenbHjB8=w1273-h948)
Fluxogram of the gameLoop:
![enter image description here](https://lh6.googleusercontent.com/V5TOYCCxzUWzibPSvfdRPVoy9IGfqKpUfc5IkF-hci2SxGakI6_eJ2qL1WDY3-8QP98UETyjpO3Q5pqsStlk=w1273-h948)
## User guide

The controls for the user are shown in the console itself.

## Conclusions


This work showed us the importance of hierarchies of the various files to enable simpler code and most importantly easily readable and modified. This code allows us to easily add new types of NPCs, foods, weapons etc... All via a txt file, making it quite intuitive and adding its own modability to the player if he wishes.
A big hurdle we had to go through was to find an intuitive and simple way of identifying an object in a tile and easily access its methods.
Another big hurdle was trying to organize our work in an intuitive matter without there being overlapping purposes on the classes etc. As a project of this scale can quickly become confusing and convoluted if we hadn't rewritten parts of the code, where as the original code was not only sloppy but overly complex and messy.

## References

* <a name="ref1">\[1\]</a> Pereira, A. (2017). C e Algoritmos, 2ª edição. Sílabo.
* <a name="ref2">\[2\]</a> stackoverflow.com


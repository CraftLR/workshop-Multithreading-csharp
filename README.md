# <img src="https://raw.githubusercontent.com/CraftLR/workshop-git/main/src/main/resources/assets/logo.png" alt="class logo" class="logo"/> 

## La Rochelle Software Craftsmenship

* **Auteurs:**

  * [Sébastien NEDJAR](mailto:sebastien.nedjar@univ-amu.fr)

* **Besoin d'aide ?**

  * Consulter et/ou créér des [issues](https://github.com/CraftLR/workshop-git/issues).
  * [Email](mailto:sebastien.nedjar@univ-amu.fr) pour toutes questions autres.

## Aperçu de l'atelier et objectifs d'apprentissage

Le multithreading est l'un des concepts les plus importants en programmation que vous devez comprendre en tant que développeur. Dans cet atelier, vous allez découvrir les concepts du multithreading en C#.

Avant de comprendre le concept de multithreading en C#, découvrons d'abord le multitasking. Comme son nom l'indique, le multitâche est le fait d'effectuer plusieurs tâches en même temps. Les systèmes d'exploitation généralistes sont aujourd'hui tous des systèmes d'exploitation multitâches. Cela signifie qu'ils ont la capacité d'exécuter plusieurs applications en même temps. Par exemple, sur une même machine, il est possible d'ouvrir un navigateur, un document PDF, un éditeur de texte, Visual Studio Code en même temps. Le système s'occupe de partager les ressources de la machine pour que chaque programme puisse s'éxécuter de manière simultanée.

Dans cet atelier, vous allez découvrir les mécanismes permettant de mettre en oeuvre une approche multitâche dans vos programmes. Que ce soit avec des processus, ou avec des Threads, quand on partage des ressources entre plusieurs tâches, il faut disposer de mécanismes de synchronisation intra et inter processus. Par la découverte des Verrous, des Moniteurs, des Mutex, des Sémaphores et des Sémaphores légers.

## Multitasking, Multithreading et Synchronisation

La première chose à faire est de créer un fork de ce dépôt. Pour ce faire, rendez-vous sur le lien suivant :

<https://classroom.github.com/a/JRCuCOHA>

GitHub va vous créer un dépôt contenant un fork de ce dépôt. Vous apparaîtrez automatiquement comme contributeur de ce projet pour y pousser votre travail. Clonez localement votre fork et ouvrez le avec Visual Studio Code.

Le code de départ de ce dépôt est basé sur celui de [l'environnement de distant de développement d'application en C#](https://github.com/CraftLR/RemoteDevelopmentCsharp). Cet environnement, permet de disposer de l'ensemble des outils nécessaires au développement d'application et à la gestion de la qualité de code. Si vous n'avez pas pris le temps de le tester, il est conseillé de le faire avant de commencer cet atelier même si les éléments les plus important seront rappelés.

### Premières applications multitaches
Un Thread (aussi appelé en bon français un exétron même si le terme est très peu usité) est ce que l'on qualifie de processus léger. En termes simples, un Thread est une partie d'un processus responsable de l'exécution du code de l'application. Ainsi, chaque programme pour s'exécuter va utiliser un Thread. Au sein d'un même processus, les exétrons ont la particularité de partager le même espace mémoire.

Par défaut, chaque processus a au moins un thread responsable de l'exécution du code de l'application et ce thread est appelé Thread principal. Ainsi, chaque application par défaut est une application à thread unique.

Remarque : toutes les classes liées au threading en C# appartiennent à l'espace de noms `System.Threading`. 

#### Exercice 1
Ouvrez la classe `Exercice1` et modifiez-la pour que votre application respecte les contraintes suivantes :

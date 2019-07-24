# ARpoly
An educational AR app made in Unity with Vuforia and written in C#. 

App was made for my MSc project: Assessing the viability of use of Augmented Reality in aiding education of primary school children in developing countries. 

It consists of 4 scenes: MainMenu, Batch1, Batch2, Endgame.

Game manager has been split into two scripts as I initially wasn't sure whether both batches will be working on the same logic. That ended up being the case but I never changed it. It works but could be more elegant.

Both batches contain 5 3D models with descriptions. Models are displayed for two minutes each after which the app switches to the next one.

Feedback sounds are integrated throughout the app.

Unity version 2019.1.7f1. Vuforia version 8.3.8.

To use this, download the repo and open it in Unity. You'll need a Vuforia license. In Unity, navigate to Resources/VuforiaConfiguration and input it in the appropriate field in the Inspector window. Free license is fine.

You can download and use the app, but you cannot use the 3D models or the targat picture as I've purchased or made those and hold the license.

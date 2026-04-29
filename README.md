# GDIM33 Vertical Slice
## Milestone 1 Devlog
Milestone 1 Devlog goes here.

1. One Visual Scripting Graph that is in my game is the "Cat" State Graph. How it works is that
I have it attached to a State Machine Component on the Cat GameObject, and the it is used to control
the Cat image's animations. The Graph is comprised of two states "notSilly" and "Silly", where the notSilly
state leaves the Cat in the notsilly Animator state as a still image and the Silly state plays the Cat's silly 
animation state which scales  the Cat up and down in a funny way. The states are triggered by an Animator Boolean 
named isSilly. If isSilly is true, the notsilly Animator state runs while the silly Animator state runs if isSilly
is false, and additionaly this is how the states transition in the State Machine.

2. What I updated about my breakdown was adding the implementation of my State Machine as well as how I plan to
incorporate Unity's Input System into my game. How my State Machine works (as mentioned in question 1) is that it
is composed of the two states "notSilly" and "Silly", where the notSilly state leaves the Cat in the notsilly Animator 
state with no playing animation and the Silly state plays the Cat's silly animation state which bounces it up and down
a bit in a "silly" manner. Again, The states are triggered by an Animator Boolean named isSilly where if it is true, we
transition to the Silly State and if it is false we transition to the notSilly State. This State Machine relates to other
Unity systems in my game behind is relies on the Animation/Animator system by checking the Cat Animator's isSilly boolean 
variable to transition between states.

Updated Break-Down:
<img width="1523" height="1149" alt="Screenshot 2026-04-28 233421" src="https://github.com/user-attachments/assets/54922c41-409d-48eb-b491-c7f83043a36b" />

## Milestone 2 Devlog
Milestone 2 Devlog goes here.
## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!

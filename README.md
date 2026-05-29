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
1. Animator Feature for scenarios steps:
	- 1. Create Animations
		1. Give chosen GameObject an Animator Component
		2. Make the Animations in the Animation tab
	- 2. Create + Control Animation transitions
		1. Create parameters necessary to control Animation transitions
		2. Create transition arrows to connect each Animation.
		3. Create code that edits/utilizes parameters to cause Animation transitions (ex. SetBool(parameter, boolean))

2. I think that the breakdown helped somewhat guide me through a step by step process to creation Animations, but for me
personally I think I still could have create them without the breakdown. I mostly like to jump straight into making something
in code before planning it out as that is what works best for me, but the breakdown was not useless and just helped me not get
lost in what to do next. If I were to do one of these breakdowns again I would improve them by adding even more detail to the steps
even if it is not needed as I often avoid writing out smaller steps in breakdowns if i believe they are already self-explanatory to me.

3. I bridged visual scripting and code in my game by using a script graph named titleScreen to control the Play and Retry buttons
in my game. In the scene "MainMenu", I attached it to the Script Machine component of the GameObject named Image under the GameObject
title screen. Inside the Graph I use the the method OnMouseDown and connected it to the method StartGame() of the C# script MainMenu
so when the Image GameObject aka the Play button is clicked the scene where the main game is located "SampleScene" is loaded. I reuse this
same Graph for the Image GameObject under the GameObject Retry Button in SampleScene so when the player loses the game, they can click the retry
button to reload SampleScene and start the game over again.

<img width="1167" height="458" alt="Screenshot 2026-05-14 231301" src="https://github.com/user-attachments/assets/14437d18-bf89-4cb6-acd0-55ce73aefeea" />

<img width="761" height="311" alt="Screenshot 2026-05-14 231336" src="https://github.com/user-attachments/assets/318138a7-4d09-4ad7-813a-47531b083ff9" />

4. I would like my use of the Animator system in my game to be graded. As of right now the GameObject Cat has an Animator and Animation that plays 
when it is on screen and I may add more animations for future scenarios just so the game doesn't look so still and lifeless. You can find the GameObject
Cat under the hierarchy to find it's Animator component and Animations.

## Milestone 3 Devlog
1. In short, my shader graph changes the color of a 2D texture. How it works is that it used a Sample Texture 2D node to take in
a Texture2D property. Then the Sample Texture 2D node's RGBA output is connected to one part of a multiply node while a color node
is connected to the other part of it. Finally, the output of the multiply node is connected to the Fragment node, resulting in me
being able to change the color of a 2D texture by only changing the color value in the color node. However, I have found no way to
implement this in my game yet, but I have a few ideas such as making scenario images flash red for a little bit before disappearing
when the player counters them (like the Minecraft hit effect), or maybe in the future having a scenario the has a rainbow animated 
effect through finding a way to loop through colors in the color node. You can find the graph applied to the disabled GameObject Cat(1) 
in the hierarchy (enable it to see the effect). It has no purpose to the game, but it is there to show off the shader graph.

2. Something I did in response to some of my feedback while playtesting was adding background music and unique sound effects
for each scenario when they appear to make the game feel more alive as opposed to the lack of these features the last time
we playtested. For example when the scissors scenario appears a scissors sound effect plays. It gives more life to the game
and provides a more enjoyable experience instead of playing the game in complete silence.

3. I added a new scenario called Thumb (appears a little bit after Popups scenario is introduced) and how it works is that
randomly either a thumbs up image will appear on screen or a thumbs down image will. If the thumbs up appears then the player
must press the up arrow to counter it, while if the thumbs down image appears the player must press the down arrow to counter it.
It adds more chaos and variety to my gameplay loop because it forces the player to utilize even more keys on their keyboard after
introducing the use of the mouse to click away the popups, keeping them on their toes and more alert on both the mouse and keybord.


## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!

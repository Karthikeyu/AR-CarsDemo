# AR-CarsDemo
Hi. This repository contains a unity project based on voice controlled augmented reality. This project can be imported directly to unity and can be built with andriod SDK, Vuforia SDK (for Augmented Reality). To enbale voice recognition, [wit ai](https://wit.ai/) an open source online API has been used. 


## Functionality

This project is aimed to built an augmented reality andriod appication where user can watch several demo car models and can project them in real world to see how it looks for example in their parking place. In addition to that, user can interact with the projected car using his/her voice commands. To add the augmented reality experience, vuforia SDK has been used with user defined target functionality. For speech to text translation, [wit ai](https://wit.ai/) has been integrated to project. [wit ai](https://wit.ai/) provides the functionality to train our voice or commands to a bot on their website. We can train the bot on several intents and with several topics. Here,for this application simple commands has been trained to bot for interacting with car. The trained commands to bot are 
* Open the drivers door
* Close the driverse door
* Open the bonnet
* Close the bonnet
* Open the trunk
* Close the trunk
* Change color to red or yellow or white or magenta or black or grey.  

After the model is projected into the real world, user can press the voice recorder button to enable voice based interaction. Unity scirpt sends user voice from micropphone to wit ai and then wit replays with a JSOn tree structure. This JSON tree file contains text string, intent and entities in a tree format. Based on those JSON file parametres responsive real-time animation is triggered on the projected car. 

**Note:*** When running the application in the androiod phone, internet connection should be there in order to enable voice recognition.

## Demo

Here, you can watch a demo. Link will be added soon. Thank you for your interest in this project! 

# power-ML

PowerCommands using machine learning in some way, my first lab is to try out the Microsoft Azure CognitiveService **ComputerVision**

## Before you start
You need an Azure account, you need to add a new Cognitive Service of the type Computer Vision here:

https://portal.azure.com/#view/Microsoft_Azure_ProjectOxford/CognitiveServicesHub/~/overview

Setup two environment variables for the endpoint and the key, look in the **PowerCommandsConfiguration.yaml** file and there you se the details.

```
environment:
    variables:
    - name: powercommands-computer-vision-endpoint
      environmentVariableTarget: User
    - name: powercommands-computer-vision
      environmentVariableTarget: User
```
## Computer vision command
So the first PowerCommand I added is the ```computervision``` command (**ComputerVisionCommand.cs**), just run it and of course check out the code.

```
computervision
```

Read more about it here: https://learn.microsoft.com/en-us/azure/cognitive-services/computer-vision/quickstarts-sdk/image-analysis-client-library?tabs=visual-studio%2C3-2&pivots=programming-language-csharp

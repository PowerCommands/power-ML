# power-ML


PowerCommands using machine learning in some way, every lab I do to learn more will be one or more PowerCommands that I add the Visual Studio project located in the **src** directory.

## ComputerVision
My first lab is to try out the Microsoft Azure CognitiveService **ComputerVision** using machine learning photo recognition to categorize photos.

### Before you start
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
### Computer vision command
So the first PowerCommand I added is the ```computervision``` command (**ComputerVisionCommand.cs**), just run it and of course check out the [code](/src/).

```
computervision
```

![Alt text](docs/images/computervision.png?raw=true "ai query")

Read more about it here: https://learn.microsoft.com/en-us/azure/cognitive-services/computer-vision/quickstarts-sdk/image-analysis-client-library?tabs=visual-studio%2C3-2&pivots=programming-language-csharp

## AIaC Artificial Intelligence Infrastructure-as-Code
### Before you start
You need an Open AI API account witch is free (for the moment), you can register an account here: 

https://openai.com/

You also need Docker Desktop or likewise that can run Docker container images.

Setup one environment variables for Open AI key with the name **aiac**,  and apply this to the **PowerCommandsConfiguration.yaml** file. 
```
environment:
    variables:
    - name: aiac
      environmentVariableTarget: User
```
I named this command simply ```ai``` and it is spinning up a Docker container created by Firefly, this container hosing a services that using Open AI to answer your instructions.

First run this command to start Docker Desktop and pull the image.
```
ai ----pull-image
```
This should display something like this.
```
Docker Desktop started
 docker Docker Desktop needs to pull image ghcr.io/gofireflyio/aiac
error during connect: This error may indicate that the docker daemon is not running.: Post "http://%2F%2F.%2Fpipe%2Fdocker_engine/v1.24/images/create?fromImage=ghcr.io%2Fgofireflyio%2Faiac&tag=latest": open //./pipe/docker_engine: The system cannot find the file specified.
Using default tag: latest
Docker Desktop needs to spin up the image, waiting a 1 seconds, before executing your query ...
```
Now you are ready to run your query, please not that this AIaC service created by Firefly is a service that is concentrated to help DevOps and handling query's regarding infrastructure as code mainly. (I have not try to ask about great movies in Denmark, maybe it works), to run a query just run command like this:
```
ai "get kubernetes deployment and service manifest for keycloak"
```
![Alt text](docs/images/ai_query.png?raw=true "ai query")


Read more about that here: https://aiac.dev/


# Getting Started with Machine Learning using `.Net Core 5.0` and `ML.Net`

This project is used to learn about Machine Learning using .Net Core 5.0. I followed the sample project from [ML.Net Tutorial Page](https://dotnet.microsoft.com/learn/ml-dotnet/get-started-tutorial/intro).

## Tech Stack

C#, .Net Core 5.0, ML.Net

## Pre-requisites

1. `dotnet` command line has been installed. Can be download from this [link](https://dotnet.microsoft.com/download/dotnet/5.0)

## Steps to run the project

1. Fork and clone this repo to your local machine. Let's say you cloned the repo under `c:\repo` folder.
2. Build the project by running a command line below:

    ```shell
    cd "C:\repo\GettingStarted-MachineLearning-NET"
    dotnet build
    ```

3. To run the project, run similar command below:

    ```shell
    dotnet run --project "C:\repo\GettingStarted-MachineLearning-NET\GettingStarted-MachineLearning-NET\GettingStarted-MachineLearning-NET.csproj"
    ```

    You should similar output below:

    ```text
    Text: That is rude.
    Is Toxic: 1
    ```

4. By building the project, it will produce an exe file located inside the bin folder of your project ("C:\repo\GettingStarted-MachineLearning-NET\GettingStarted-MachineLearning-NET\bin"). You can try to run the exe file like below having multiple text inputs.

    ```shell
    cd "C:\repo\GettingStarted-MachineLearning-NET\GettingStarted-MachineLearning-NET\bin\Debug\net5.0"
    GettingStarted-MachineLearning-NET.exe "Nice" "You're Rude"
    ```

    You should similar output below:

    ```text
    Text: Nice
    Is Toxic: 0


    Text: You're Rude
    Is Toxic: 1
    ```

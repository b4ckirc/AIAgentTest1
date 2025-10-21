# 🤖 My First AI Agent

Welcome to **AIAgentTest1**, my first test project for creating an AI agent! This project uses the `Microsoft.Agents.AI` framework to build a simple AI agent that provides weather information.

The agent interacts with the user to get two inputs: their preferred **language** and their **location**. It then fetches and outputs the current weather data for the specified location in the chosen language.

---

## 🛠️ Prerequisites

This project requires **Ollama** to be installed and running to manage and serve the Large Language Model (LLM).

### 1. Install Ollama

Ollama is a fantastic tool for running large language models locally.

1.  **Download Ollama:** Visit the official Ollama website and download the appropriate installer for your operating system (macOS, Windows, or Linux).
    > [https://ollama.com/](https://ollama.com/)
2.  **Installation:** Follow the on-screen instructions to complete the installation.
3.  **Verify Installation:** Open your terminal or command prompt and run the following command to ensure Ollama is installed correctly:

    ```bash
    ollama --version
    ```

### 2. Pull an Ollama Model

Once Ollama is installed, you need to pull a model that the agent can use. For a weather task, a small, capable model like `llama3.2` or `mistral` is usually sufficient.

1.  **Pull the Model:** Use the `ollama pull` command in your terminal. For this example, we'll use `llama3.2:3b`:

    ```bash
    ollama pull llama3.2:3b
    ```

    Ollama will download the model files. This might take a few minutes depending on your internet connection.
2.  **Verify Model:** You can check which models you have installed with:

    ```bash
    ollama list
    ```

---

## 🚀 Running the Project

1.  **Clone the Repository:**

    ```bash
    git clone [YOUR_REPO_URL]
    cd [your-repo-name]
    ```

2.  **Configure:** Ensure the configuration file (`config.json` or equivalent) correctly points to the running Ollama service and the chosen model.

3.  **Run the C# Project:** Open the solution in Visual Studio and run the project, or execute it via the CLI:

    ```bash
    dotnet run
    ```

---

## 💡 How the Agent Works

The agent will prompt you for the following information:

1.  **Language:** (e.g., "English", "Italiano", "Español")
2.  **Location:** (e.g., "London", "Tokyo", "Paris")

The agent then uses the selected LLM (served by Ollama) to process the request and provide the weather details for that location, formatted in the language you specified.

### Example Interaction:

| Input | Description |
| :--- | :--- |
| **Agent:** Please write your language: | *User types: Italian* |
| **Agent:** Please write your location: | *User types: Berlin* |
| **Agent Output (Italian):** Il tempo a Berlino è attualmente soleggiato con una temperatura di 18°C. | |

This is a personal learning project and a testament to the power of the `Microsoft.Agents.AI` framework combined with local LLMs via Ollama. Feel free to explore the code and provide feedback!
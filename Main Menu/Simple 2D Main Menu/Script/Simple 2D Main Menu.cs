using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required for UI elements like Buttons
using UnityEngine.SceneManagement; // Required for scene management

public class Simple2DMainMenu : MonoBehaviour
{
    public Button StartButton; // Reference to the 'Start' button in the UI
    public Button ExitButton; // Reference to the 'Exit' button in the UI

    void Start()
    {
        // Add a listener to the Mula button which will call the 'LoadGameScene' method when clicked
        StartButton.onClick.AddListener(LoadGameScene);

        // Add a listener to the Close button which will call the 'CloseGame' method when clicked
        ExitButton.onClick.AddListener(CloseGame);
    }

    void LoadGameScene()
    {
        // Go to The Next Screen
        SceneManager.LoadSceneAsync(1);
    }

    void CloseGame()
    {
        // This will close the application. Note: This will not work in the editor.
        Application.Quit();
    }
}
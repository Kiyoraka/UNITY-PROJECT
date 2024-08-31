using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required for UI elements like Buttons
using UnityEngine.SceneManagement; // Required for scene management

public class LevelOneS2DMM : MonoBehaviour
{
    public Button BackButton; // Reference to the 'Back' button in the UI
    void Start()
    {
        // Add a listener to the Mula button which will call the 'LoadGameScene' method when clicked
        BackButton.onClick.AddListener(LoadMainMenu);
    }

    void LoadMainMenu()
    {
        // Go to The Main Menu
        SceneManager.LoadSceneAsync(0);
    }
}

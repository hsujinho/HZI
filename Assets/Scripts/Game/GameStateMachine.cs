using UnityEngine;
using HZI.Shared.Enums;

public class GameStateMachine : MonoBehaviour
{
    public static GameStateMachine instance { get; private set; }
    
    public GameState currentState;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    
    void Start()
    {
        ChangeState(GameState.Init);
    }
    
    public void ChangeState(GameState newState)
    {
        currentState = newState;
        switch (currentState)
        {
            case GameState.Init:
                Init();
                break;
            case GameState.MainMenu:
                MainMenu();
                break;
            case GameState.Setting:
                // Setting();
                break;
            case GameState.Battle:
                // Battle();
                break;
            case GameState.Quit:
                // Quit();
                break;
        }
    }

    private void Init()
    {
        Debug.Log("Initializing Game State Machine...");
        
        
        Debug.Log("Done initializing Game State Machine.");
        
        ChangeState(GameState.MainMenu);
    }

    private void MainMenu()
    {
        Debug.Log("Entering Main Menu...");

        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuScene");
    }
}
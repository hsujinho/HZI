using UnityEngine;
using UnityEngine.UIElements;
using HZI.Shared.Enums;

public class MainMenuController : MonoBehaviour
{
    private Button _startButton;
    private Button _quitButton;
    
    private void Awake()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        
        _startButton = root.Q<Button>("StartButton");
        _quitButton = root.Q<Button>("QuitButton");
    }
    
    private void Start()
    {
        _startButton.RegisterCallback<ClickEvent>(_ => OnStartButtonClicked());
        _quitButton.RegisterCallback<ClickEvent>(_ => OnQuitButtonClicked());
    }
    
    private void OnStartButtonClicked()
    {
        Debug.Log("Start button clicked!");
        // Load the game scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/test_room");
        GameStateMachine.instance.ChangeState(GameState.Battle);
        
        Debug.Log("Game state changed to Battle.");
    }
    
    private void OnQuitButtonClicked()
    {
        // Quit the application
        Debug.Log("The game is quit.");
        Application.Quit();
        
        #if UNITY_EDITOR
        Debug.Log("Switch to editor mode.");
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuManager : Singleton<MenuManager>
{
    public MainMenuHandler mainMenuHandler;
    public SettingsHandler settingsHandler;
    public GameModeHandler gameModeHandler;
    public GamePlayUIHandler gamePlayUIHandler;
    public PauseMenuHandler pauseMenuHandler;
    public SplashHandler splashHandler;
    public PopupHandler popupHandler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /// <summary>
    /// Setting to splash screen on gamestart
    /// </summary>
    public void onGameStart()
    {
        switchMenu();
    }

    /// <summary>
    /// disable all menus before switching to new menu according to gamestate
    /// </summary>
    public void disableAllMenus()
    {
        mainMenuHandler.gameObject.SetActive(false);
        settingsHandler.gameObject.SetActive(false);
        gameModeHandler.gameObject.SetActive(false);
        gamePlayUIHandler.gameObject.SetActive(false);
        pauseMenuHandler.gameObject.SetActive(false);
        splashHandler.gameObject.SetActive(false);
    }

    /// <summary>
    /// Switch Menus according to current gamestate
    /// </summary>
    public void switchMenu()
    {
        disableAllMenus();
        switch (GameManager.Instance.currentState)
        {
            case GameState.GAMEMODE:
                gameModeHandler.gameObject.SetActive(true);
                break;
            case GameState.GAMEPLAY:
                gamePlayUIHandler.gameObject.SetActive(true);
                break;
            case GameState.LEADERBOARD:
                break;
            case GameState.LOOSE:
                break;
            case GameState.MAINMENU:
                mainMenuHandler.gameObject.SetActive(true);
                break;
            case GameState.MATCHMAKING:
                break;
            case GameState.PAUSE:
                pauseMenuHandler.gameObject.SetActive(true);
                break;
            case GameState.SETTINGS:
                settingsHandler.gameObject.SetActive(true);
                break;
            case GameState.SHOP:
                break;
            case GameState.SPLASH:
                splashHandler.gameObject.SetActive(true);
                break;
            case GameState.WIN:
                break;
        }
    }

    public void showPopup()
    {
        popupHandler.gameObject.SetActive(true);
    }
}

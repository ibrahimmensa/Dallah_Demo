using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    SPLASH,
    MAINMENU,
    SETTINGS,
    SHOP,
    LEADERBOARD,
    GAMEMODE,
    MATCHMAKING,
    GAMEPLAY,
    PAUSE,
    WIN,
    LOOSE,
    DAILYREWARDS
}

public class GameManager : Singleton<GameManager>
{
    public GameState currentState;
    // Start is called before the first frame update

    /// <summary>
    /// Setting game to splash state on game start
    /// </summary>
    void Start()
    {
        currentState = GameState.SPLASH;
        MenuManager.Instance.onGameStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Switching states depending on user interaction with UI
    /// </summary>
    public void switchState(GameState newState)
    {
        currentState = newState;
        MenuManager.Instance.switchMenu();
    }
}

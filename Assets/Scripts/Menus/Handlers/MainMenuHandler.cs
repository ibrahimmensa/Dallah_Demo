using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// On Click Play Button on Main Menu
    /// </summary>
    public void onClickPlay()
    {
        GameManager.Instance.switchState(GameState.GAMEMODE);
    }

    /// <summary>
    /// LeaderBoard functionality will be implemented later
    /// </summary>
    public void onClickLeaderBoard()
    {
        GameManager.Instance.switchState(GameState.LEADERBOARD);
        //MenuManager.Instance.showPopup();
    }

    /// <summary>
    /// INApps will be implemented later
    /// </summary>
    public void onClickNoAds()
    {
        MenuManager.Instance.showPopup();
    }

    /// <summary>
    /// Seasons will be implemented later
    /// </summary>
    public void OnClickSeasons()
    {
        MenuManager.Instance.showPopup();
    }

    /// <summary>
    /// Missions will be implemented later
    /// </summary>
    public void OnClickMissions()
    {
        MenuManager.Instance.showPopup();
    }

    /// <summary>
    /// SHop will be implemented later
    /// </summary>
    public void onClickShop()
    {
        GameManager.Instance.switchState(GameState.SHOP);
        //MenuManager.Instance.showPopup();
    }

    /// <summary>
    /// Daily rewards will be implemented Later
    /// </summary>
    public void onClickDailyRewards()
    {
        GameManager.Instance.switchState(GameState.DAILYREWARDS);
        //MenuManager.Instance.showPopup();
    }

    /// <summary>
    /// Rewarded Ads will not be implemented in demo
    /// </summary>
    public void onClickMoreCoins()
    {
        MenuManager.Instance.showPopup();
    }

    /// <summary>
    /// Open up settings menu
    /// </summary>
    public void onClickSettings()
    {
        GameManager.Instance.switchState(GameState.SETTINGS);
    }
}

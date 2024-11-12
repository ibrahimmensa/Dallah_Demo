using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickBack()
    {
        GameManager.Instance.switchState(GameState.MAINMENU);
    }

    public void onClickMultiplayer()
    {
        GameManager.Instance.switchState(GameState.GAMEPLAY);
    }
}

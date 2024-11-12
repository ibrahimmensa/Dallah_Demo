using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashHandler : MonoBehaviour
{
    public Slider loadingBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        loadingBar.value = 0;
        StartCoroutine(startLoadingTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchToMainMenu()
    {
        GameManager.Instance.switchState(GameState.MAINMENU);
    }

    public void startLoading()
    { 
    }

    IEnumerator startLoadingTimer()
    {
        yield return new WaitForSeconds(3);
        for (int i = 0; i < 5; i++)
        {
            loadingBar.value += 20;
            yield return new WaitForSeconds(0.5f);
        }
        Invoke("switchToMainMenu", 2);
    }
}

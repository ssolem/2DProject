using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartUI : BaseUI
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button endButton;

    public override void Init(FirstUIManager uiManager)
    {
        base.Init(uiManager);

        startButton.onClick.AddListener(OnClickStart);
        endButton.onClick.AddListener(OnClickEnd);
    }
    protected override UIState GetUIState()
    {
        return UIState.Start;
    }

    public void OnClickStart()
    {
        if (!FirstGameManager.Instance.isPlayedOnce)
        {
            uiManager.HelpGame();
        }
        else
            FirstGameManager.Instance.GameStart();
    }

    public void OnClickEnd()
    {
        //¾À µ¹¾Æ°¡±â
        SceneManager.LoadScene("StartScene");
    }
   
}

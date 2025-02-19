using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpUI : BaseUI
{
    public GameObject ruleBook1;
    public GameObject ruleBook2;

    [SerializeField] private Button nextButton;
    [SerializeField] private Button exitButton;

    public override void Init(FirstUIManager uiManager)
    {
        base.Init(uiManager);

        nextButton.onClick.AddListener(OnClickNextRule);

        ruleBook1.SetActive(true);
        ruleBook2.SetActive(false);
    }
    protected override UIState GetUIState()
    {
        return UIState.Help;
    }

    public void OnClickNextRule()
    {

    }

    public void OnClickExitRule()
    {
        if (!FirstGameManager.Instance.isPlayedOnce)
        {
            FirstGameManager.Instance.isPlayedOnce = true;
            FirstGameManager.Instance.GameStart();
        }
        else
        {
            uiManager.StartGame();
        }


    }
}

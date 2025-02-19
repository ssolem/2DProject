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
        exitButton.onClick.AddListener(OnClickExitRule);

        ruleBook1.SetActive(true);
        ruleBook2.SetActive(false);
    }
    protected override UIState GetUIState()
    {
        return UIState.Help;
    }

    public void OnClickNextRule()
    {
        ruleBook1.SetActive(false);
        ruleBook2.SetActive(true);
    }

    public void OnClickExitRule()
    {
        ruleBook1.SetActive(true);
        ruleBook2.SetActive(false);

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

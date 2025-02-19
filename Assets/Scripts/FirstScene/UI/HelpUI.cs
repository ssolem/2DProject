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

        Debug.Log("init");
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
        Debug.Log("exit");
        ruleBook1.SetActive(true);
        ruleBook2.SetActive(false);
        Debug.Log(FirstGameManager.Instance.isPlayedOnce);


        if (!FirstGameManager.Instance.isPlayedOnce)
        {
            Debug.Log("true");

            FirstGameManager.Instance.isPlayedOnce = true;
            FirstGameManager.Instance.GameStart();
        }
        else
        {
            Debug.Log("else");
            uiManager.StartGame();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndUI : BaseUI
{
    public TextMeshProUGUI bestTimeText;
    public TextMeshProUGUI scoreTimeText;

    [SerializeField] private Button restartButton;
    [SerializeField] private Button exitButton;

    public override void Init(FirstUIManager uiManager)
    {
        base.Init(uiManager);

        restartButton.onClick.AddListener(OnClickRestartButton);
        exitButton.onClick.AddListener(OnClickExitButton);

    }
    protected override UIState GetUIState()
    {
        return UIState.End;
    }

    public void OnClickRestartButton()
    {
        FirstGameManager.Instance.Restart();
    }

    public void OnClickExitButton()
    {
        //¾À µ¹¾Æ°¡±â
    }

    public void Update()
    {
        Score();
        BestScore();
    }

    public void Score()
    {
        scoreTimeText.text = FirstGameManager.Instance.PlayTime.ToString("N2");
    }

    public void BestScore()
    {
        float score = 0;
        float bestScore = 0;

        if(!float.TryParse(scoreTimeText.text,out score))
            score = 0;
        if(!float.TryParse(bestTimeText.text, out bestScore))
            bestScore = 0;

        if(score < bestScore || bestScore == 0)
        {
            bestScore = score;
        }

        bestTimeText.text = bestScore.ToString("N2");
    }
}

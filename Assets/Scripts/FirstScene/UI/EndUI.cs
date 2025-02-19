using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndUI : BaseUI
{

    public float score;
    public float bestScore = 0;

    private const string BestScoreKey = "bestScore";

    public TextMeshProUGUI bestTimeText;
    public TextMeshProUGUI scoreTimeText;

    [SerializeField] private Button restartButton;
    [SerializeField] private Button exitButton;

    private void Start()
    {
        bestScore = PlayerPrefs.GetFloat(BestScoreKey);
    }
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
        SceneManager.LoadScene("StartScene");
        Debug.Log($"New Best Score Saved: {bestScore}");

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
        score = FirstGameManager.Instance.PlayTime;

        if (score < bestScore || bestScore == 0)
        {
            bestScore = score;
            PlayerPrefs.SetFloat(BestScoreKey, bestScore);
            PlayerPrefs.Save();
        }



        bestTimeText.text = bestScore.ToString("N2");
    }
}

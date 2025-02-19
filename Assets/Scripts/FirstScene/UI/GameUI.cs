using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUI : BaseUI
{
    public TextMeshProUGUI timeText;

    public override void Init(FirstUIManager uiManager)
    {
        base.Init(uiManager);

    }
    protected override UIState GetUIState()
    {
        return UIState.Game;
    }

    private void Update()
    {
        timeText.text = FirstGameManager.Instance.PlayTime.ToString("N2");
    }
}

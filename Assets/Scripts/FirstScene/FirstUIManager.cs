using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum UIState
{
    Start,
    Help,
    Game,
    End
}
public class FirstUIManager : MonoBehaviour
{
    HelpUI helpUI;
    StartUI startUI;
    GameUI gameUI;
    EndUI endUI;

    private UIState currentState;

    private void Awake()
    {
        helpUI = GetComponentInChildren<HelpUI>(true);
        helpUI.Init(this);
        startUI = GetComponentInChildren<StartUI>(true);
        startUI.Init(this);
        gameUI = GetComponentInChildren<GameUI>(true);
        gameUI.Init(this);
        endUI = GetComponentInChildren<EndUI>(true);
        endUI.Init(this);

        ChangeState(UIState.Start);
    }

    public void StartGame()
    {
        ChangeState(UIState.Game);
    }

    public void GameOver()
    {
        ChangeState(UIState.End);
    }

    public void HelpGame()
    {
        ChangeState(UIState.Help);
    }

    public void ChangeState(UIState state)
    {
        currentState = state;
        helpUI.SetActive(currentState);
        gameUI.SetActive(currentState);
        startUI.SetActive(currentState);
        endUI.SetActive(currentState);
    }


}

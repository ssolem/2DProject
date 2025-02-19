using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseUI : MonoBehaviour
{
    protected FirstUIManager uiManager;

    protected abstract UIState GetUIState();

    public virtual void Init(FirstUIManager uiManager)
    {
        this.uiManager = uiManager;
    }

    public void SetActive(UIState state)
    {
        this.gameObject.SetActive(GetUIState() == state);
    }
}

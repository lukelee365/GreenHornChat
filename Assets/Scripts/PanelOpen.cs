using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpen : MonoBehaviour
{
    public static bool openPanel = false;
    public CanvasGroup panel;
   

    void Start()
    {
        panel.alpha = 0;
        panel.interactable = false;

    }
    public void OpenCloseImagePanel()
    {
        if (!openPanel)
        {
            panel.alpha = 1;
            panel.interactable = true;
            openPanel = true;
        }
        else
        {
            panel.alpha = 0;
            panel.interactable = false;
            openPanel = false;
        }
    }

    public void CloseButtonPanel()
    {
        panel.interactable = false;
        panel.alpha = 0f;
        openPanel = false;
    }
}

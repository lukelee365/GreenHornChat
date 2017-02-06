using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageUpload : MonoBehaviour
{

    public Image imageUI;
    public Sprite sprite;
    public CanvasGroup panel;
    public Text textPanel;
    public Button CloseButton;
    public Button SubmitButton;

    void Start()
    {
        SubmitButton.interactable = false;
    }


    public void UploadImage()
    {
        imageUI.sprite = sprite;
        SubmitButton.interactable = true;
    }

    public void SubmitImage()
    {
        PanelOpen.openPanel = false;
        panel.interactable = false;
        panel.alpha = 0f;
        imageUI.sprite = null;
        Post();
        SubmitButton.interactable = false;

    }

    public void Post()
    {
        textPanel.text = textPanel.text + "\n" + "<color=Red>Correct image has been uploaded as answer. Stay tuned for more info</color>";
    }
}

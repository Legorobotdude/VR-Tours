using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Artifact : VRTK_InteractableObject
{
    [Header("Custom Properties")]
    [SerializeField] CanvasGroup infoBox;
    [SerializeField] Loading loading;
    [SerializeField] GameObject textBox;

    protected void Start()
    {
        infoBox = GetComponentInChildren<CanvasGroup>();
    }

    protected override void Update()
    {
        base.Update();
        if (loading.readyToLoad)
        {
            LoadText();
        }
    }

    public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
    {
        base.StartUsing(currentUsingObject);
        infoBox.alpha = 1;
        loading.gameObject.SetActive(true);
    }

    public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
    {
        base.StopUsing(previousUsingObject, resetUsingObjectState);
        UnloadText();
    }

    public void LoadText()
    {
        loading.readyToLoad = false;
        loading.ResetAmount();
        loading.gameObject.SetActive(false);
        textBox.SetActive(true);
    }

    public void UnloadText()
    {
        loading.readyToLoad = false;
        loading.ResetAmount();
        infoBox.alpha = 0;
        textBox.SetActive(false);
    }
}

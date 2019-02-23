using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Artifact : VRTK_InteractableObject
{
    [SerializeField] CanvasGroup infoBox;
    public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
    {
        print("Hit");
        base.StartUsing(currentUsingObject);
        infoBox.alpha = 1;
    }

    public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
    {
        base.StopUsing(previousUsingObject, resetUsingObjectState);
        infoBox.alpha = 0;
    }

    protected void Start()
    {
        infoBox = GetComponentInChildren<CanvasGroup>();
    }

    protected override void Update()
    {
        base.Update();
    }
}

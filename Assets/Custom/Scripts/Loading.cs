using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Loading : MonoBehaviour
{

    public Transform loadingBar;
    public TextMeshProUGUI loadingText;
    public bool readyToLoad;
    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
            loadingText.text = ((int)currentAmount).ToString() + "%";
            readyToLoad = false;
        }

        else
        {
            readyToLoad = true;
        }

        loadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
    }

    public void ResetAmount()
    {
        currentAmount = 0;
    }
}

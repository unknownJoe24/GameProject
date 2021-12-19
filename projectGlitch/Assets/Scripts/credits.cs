using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class credits : MonoBehaviour
{
    public Button mainMenu;
    public TMP_Text mainText;

    private void Start()
    {
        mainText.text = "Main Menu";
    }
}

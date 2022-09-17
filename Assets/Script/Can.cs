using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Can : MonoBehaviour
{
    public static int hak = 3;
    public TextMeshProUGUI hakyazisi;
    public GameObject bitisPanel;
    void Update()
    {
        hakyazisi.text = "Kalan hak:" + hak.ToString();
        if (hak == 0)
        {
            bitisPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

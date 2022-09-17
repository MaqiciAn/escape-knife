using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class YenidenOyna : MonoBehaviour
{
    public void TekrarOyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Can.hak = 3;
        Time.timeScale = 1;
    }
}

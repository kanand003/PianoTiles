using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
   public void P1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Q1()
    {
        Application.Quit();
    }
}

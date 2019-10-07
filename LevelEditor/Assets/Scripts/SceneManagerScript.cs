//Refrence from Youtube: Reso Coder
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    public Text valueTxt;

    private void Start()
    {
            valueTxt.text = PresistentManager.Instance.value.ToString();
    }
    public void GoToFirstScene()
    {
        SceneManager.LoadScene("UI");
        PresistentManager.Instance.value++;
    }
    public void GoToSecondScene()
    {
        SceneManager.LoadScene("SampleScene");
        PresistentManager.Instance.value++;
    }
}

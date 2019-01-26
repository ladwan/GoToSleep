using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject HowTO;

    // Start is called before the first frame update
    void Start()
    {
        HowTO.SetActive(false);
        Invoke("HideFade", 1);
    }

    public void HideFade()
    {
        GameObject.FindGameObjectWithTag("Fade").SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void HowTo()
    {
        HowTO.SetActive(true);
    }

    public void GoBack()
    {
        HowTO.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

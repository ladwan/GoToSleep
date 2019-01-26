using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Animator Anim;
    public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GameObject.FindGameObjectWithTag("Fade").GetComponent<Animator>();
    }
    public void GamePaused()
    {
        Time.timeScale = 0f;
        Menu.SetActive(true);
    }

    public void GameUnpaused()
    {
        Time.timeScale = 1f;
        Menu.SetActive(false);
    }
     public void FadeToMain()
    {
        Anim.SetBool("FadeOut", true);
        Time.timeScale = 1f;

        Invoke("GoToMain", 2);
    }


    public void GoToMain()
    {
        
        SceneManager.LoadScene(0);
    }

}

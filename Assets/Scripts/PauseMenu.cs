using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        
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
    // Update is called once per frame
    void Update()
    {
        
    }
}

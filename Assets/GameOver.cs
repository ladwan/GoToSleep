using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Stuff()
    {
        SceneManager.LoadScene(0);
        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().GameWon = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stopBoi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<ClickMove>().Hold = true;
        Invoke("End", 5);
    }

    public void End()
    {
        SceneManager.LoadScene(13);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

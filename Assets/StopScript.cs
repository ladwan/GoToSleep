using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopScript : MonoBehaviour
{
    public GameObject Wife;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<ClickMove>().Hold = true;
        Invoke("This", 5f);
    }
    public void This()
    {
        Wife.SetActive(false);
        GameObject.Find("WifeText").SetActive(false);
        GameObject.FindGameObjectWithTag("Player").GetComponent<ClickMove>().Hold = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

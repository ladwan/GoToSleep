using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopBoi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<ClickMove>().Hold = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

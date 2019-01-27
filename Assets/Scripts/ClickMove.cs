using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickMove : MonoBehaviour
{
    public bool Hold;
    bool doOnce,noClick, noClick1 ;
    NavMeshAgent NavREF;
 
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        NavREF = GetComponent<NavMeshAgent>();
    }

    private void OnMouseOver()
    {
        noClick = true;
    }
    private void OnMouseExit()
    {
        noClick = false;
    }

    public void Delay()
    {
        noClick1 = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            
            doOnce = false;
        }
      
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
       
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (doOnce == false && noClick == false && noClick1 == false)
                {
                    Invoke("Delay", 1);
                    noClick1 = true;
                    doOnce = true;
                    if(Hold == false)
                    {
                        GameObject.FindGameObjectWithTag("Player").transform.LookAt(hit.point);

                    }

                }
                if(Hold == false)
                {
                    NavREF.destination = hit.point;

                }


            }
        }
  
    }
}

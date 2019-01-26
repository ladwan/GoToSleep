using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrophyScript : MonoBehaviour
{
    public Color bronze, white;
    public GameObject GameManagerREF;
    int stage1REF, stage1MAXREF;
    // Start is called before the first frame update
    void Start()
    {
        GameManagerREF = GameObject.FindGameObjectWithTag("GM");

        switch (gameObject.name)
        {
            case "Stage1":
                stage1REF = GameManagerREF.GetComponent<GameManager>().stage1;
                stage1MAXREF = GameManagerREF.GetComponent<GameManager>().stage1MAX;
                if (stage1REF >= 1)
                {
                    GameObject.Find("Lvl1").transform.GetChild(0).GetComponent<Image>().color = bronze;
                }

                if (stage1REF >= 4)
                {
                    GameObject.Find("Lvl1").transform.GetChild(1).GetComponent<Image>().color = white;
                }

                if (stage1REF >= 6)
                {
                    GameObject.Find("Lvl1").transform.GetChild(2).GetComponent<Image>().color = white;
                }

                break;


        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

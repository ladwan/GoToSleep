using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TrophyScript : MonoBehaviour
{
    public Color bronze, white;
    public GameObject GameManagerREF;
    int stage1REF, stage1MAXREF, stage2REF;
    // Start is called before the first frame update
    void Start()
    {
        GameManagerREF = GameObject.FindGameObjectWithTag("GM");

        switch (gameObject.name)
        {
            case "Stage1":
                stage1REF = GameManagerREF.GetComponent<GameManager>().stage1;
                stage1MAXREF = GameManagerREF.GetComponent<GameManager>().stage1MAX;
                Debug.Log(stage1REF);
                if (stage1REF >= 1)
                {
                    GameObject.Find("Lvl1").transform.GetChild(0).GetComponent<Image>().color = bronze;
                }

                if (stage1REF >= 3)
                {
                    GameObject.Find("Lvl1").transform.GetChild(1).GetComponent<Image>().color = white;
                }

                if (stage1REF >= 5)
                {
                    GameObject.Find("Lvl1").transform.GetChild(2).GetComponent<Image>().color = white;
                }

                break;

            case "Stage2":
                stage2REF = GameManagerREF.GetComponent<GameManager>().stage2;
                //stage1MAXREF = GameManagerREF.GetComponent<GameManager>().stage1MAX;
                //Debug.Log(stage1REF);
                if (stage2REF >= 1)
                {
                    GameObject.Find("Lvl2").transform.GetChild(0).GetComponent<Image>().color = bronze;
                }

                if (stage2REF >= 3)
                {
                    GameObject.Find("Lvl2").transform.GetChild(1).GetComponent<Image>().color = white;
                }

                if (stage2REF >= 5)
                {
                    GameObject.Find("Lvl2").transform.GetChild(2).GetComponent<Image>().color = white;
                }

                break;

        }

    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

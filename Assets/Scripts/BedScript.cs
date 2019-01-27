using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BedScript : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    bool HasBeenClicked, stageComplete;
    int stage, ObjectsInteracted;
    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        stage = SceneManager.GetActiveScene().buildIndex;
        CheckStage();
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            HasBeenClicked = true;
            StartCoroutine(ClickDelay());
        }
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    

    }

    void CheckStage()
    {
        /*switch (stage)
        {
            case 1:
                stageComplete = true;
                break;

            case 2:
                if(ObjectsInteracted >= 3)
                {
                    stageComplete = true;
                }
                break;
        }*/
    }
    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame

        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.tag == "Player" && HasBeenClicked == true)
        {
            Anim.SetBool("FadeOut", true);
            Invoke("OpenScene", 2);
        }
    }
    // Update is called once per frame

        void OpenScene()
    {
        SceneManager.LoadScene(stage += 1);
    }
    void Update()
    {
        
    }

    IEnumerator ClickDelay()
    {
        yield return new WaitForSeconds(10);
        HasBeenClicked = false;
    }
}

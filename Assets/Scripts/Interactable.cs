using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Interactable : MonoBehaviour {
 
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    bool HasBeenClicked, PickedName, ToiletBool,DogName, doOnce;
    public Text Object1;
    public GameObject InteractPawn;
    private void Start()
    {
        if(Object1 != null)
        Object1.enabled = false;
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            
            HasBeenClicked = true;
            StartCoroutine(ClickDelay());
        }
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        //If your mouse hovers over the GameObject with the script attached, output this message

    }



    private void OnTriggerEnter(Collider other)
    {
     
        if (other.tag == "Player" && HasBeenClicked == true)
        {
            

            switch (gameObject.name)
            {
                case "EarlyRoom_TubeTV":
                    GameObject.Find("Spot Light").GetComponent<Animator>().SetTrigger("BlinkTrigger");

                    if(SceneManager.GetActiveScene().buildIndex <= 4)
                    {
                        if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Tv1 == false)
                        {
                            GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckTv1();

                        }
                    }
                    if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Tv2 == false)
                    {
                        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckTv2();

                    }


                    break;

                case "Taffy":
                    if (SceneManager.GetActiveScene().buildIndex <= 4)
                    {
                        if (PickedName == false)
                        {
                            if (InteractPawn.transform.GetChild(0) != null)
                            {
                                PickedName = true;

                                GameObject.FindGameObjectWithTag("Player").GetComponent<ClickMove>().Hold = true;
                                InteractPawn.transform.GetChild(0).gameObject.SetActive(true);
                            }


                            if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Puppy1 == false)
                            {
                                GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckPuppy1();

                            }

                        }
                    }
                    if(SceneManager.GetActiveScene().buildIndex >= 5)
                    {
                        InteractPawn.GetComponent<Animator>().SetTrigger("Dog2Trigger");
                        if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Puppy2 == false)
                        {
                            GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckDog2();

                        }
                    }

                   
                    
                    break;

                case "Toybox":
                    InteractPawn.GetComponent<Animator>().SetTrigger("RideTrigger");
                    if(GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Toybox1 == false)
                    {
                        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckToybox1();

                    }
                    break;


                case "Toilet":
                    if (ToiletBool == false)
                    {
                        ToiletBool = true;
                        gameObject.GetComponent<Animator>().SetTrigger("ToiletTrigger");
                        InteractPawn.GetComponent<AudioSource>().Play();
                        Invoke("ToiletDelay", 10);

                        if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Toilet1 == false)
                        {
                            GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckToilet1();

                        }

                    }
                    break;

                case "Drawings":
                    if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Drawings1 == false)
                    {
                        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckDrawings1();

                    }
                    break;

                case "Guitar":
                    InteractPawn.GetComponent<Animator>().SetTrigger("GuitarTrigger");
                    if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Guitar2 == false)
                    {
                        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckGuitar2();

                    }
                    break;

                case "SkateBoard":
                    InteractPawn.GetComponent<Animator>().SetTrigger("SkateTrigger");
                    if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Skate2 == false)
                    {
                        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckSkate2();

                    }
                    break;

                case "Tissues":
                    //InteractPawn.GetComponent<Animator>().SetTrigger("SkateTrigger");
                    if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Tissues2 == false)
                    {
                        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckTissue2();

                    }
                    break;





                case "FlatScreenTV":
                    //InteractPawn.GetComponent<Animator>().SetTrigger("SkateTrigger");
                    InteractPawn.SetActive(true);
                    if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Tissues2 == false)
                    {
                        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckTissue2();

                    }
                    break;

                case "taffyUnwrapped":

                    DogName = true;
                    if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Puppy3 == false)
                    {
                        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckDog3();

                    }
                    break;

                case "Chair":
                    InteractPawn.GetComponent<Animator>().SetTrigger("ChairTrigger");
                    if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Chair3 == false)
                    {
                        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckChair3();

                    }
                    break;
                    
                case "Mirror":
                    if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Mirror3 == false)
                    {
                        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckMirror3();

                    }
                    break;

                case "WindowBoi":
                    if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Window3 == false)
                    {
                        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckWindow3();

                    }
                    break;

            }
       
            if (Object1 != null)
                Object1.enabled = true;
            if (DogName == true)
            {
                if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().SavedDogName != null && doOnce == false)
                {
                    doOnce = true;
                    Object1.text += GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().SavedDogName += "?";
                }

               
            }
        }
    }

    public void ToiletDelay()
    {
        ToiletBool = false;
    }
    public void DogNamed()
    {
        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().SavedDogName = InteractPawn.transform.GetChild(0).transform.GetChild(1).GetComponent<InputField>().text;
        GameObject.FindGameObjectWithTag("Player").GetComponent<ClickMove>().Hold = false;
        InteractPawn.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.GetComponent<Animator>().SetTrigger("DogNameTrigger");
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if(Object1 != null)
            Object1.enabled = false;
            DogName = false;
        }
    }
    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame

        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    IEnumerator ClickDelay()
    {
        yield return new WaitForSeconds(10);
        HasBeenClicked = false;
    }

}

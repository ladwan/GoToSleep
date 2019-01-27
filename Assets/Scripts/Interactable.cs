﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour {
 
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    bool HasBeenClicked, PickedName, ToiletBool;
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

                    if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Tv1 == false)
                    {
                        GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckTv1();

                    }

                    break;

                case "Taffy":
                    if (PickedName == false)
                    {
                        PickedName = true;
                        GameObject.FindGameObjectWithTag("Player").GetComponent<ClickMove>().Hold = true;
                        InteractPawn.transform.GetChild(0).gameObject.SetActive(true);

                        if (GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().Puppy1 == false)
                        {
                            GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckPuppy1();

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
            }
       
            if (Object1 != null)
                Object1.enabled = true;
        }
    }

    public void ToiletDelay()
    {
        ToiletBool = false;
    }
    public void DogNamed()
    {
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

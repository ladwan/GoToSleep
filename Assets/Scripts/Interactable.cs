using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour {

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    bool HasBeenClicked;
    public Text Object1;

    private void Start()
    {
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
        Debug.Log("1");
        if (other.tag == "Player" && HasBeenClicked == true)
        {
            switch (gameObject.name)
            {
                case "Tv":
                    GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().CheckTv1();
                    break;

            }
            Debug.Log("2");
            Object1.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
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

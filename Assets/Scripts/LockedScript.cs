using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockedScript : MonoBehaviour
{
    public GameObject LockedText;

    // Start is called before the first frame update
public void LockText()
    {
        LockedText.SetActive(true);
        Invoke("TextGoAway", 3);

    }


    private void TextGoAway()
    {
        LockedText.SetActive(false);
    }
}

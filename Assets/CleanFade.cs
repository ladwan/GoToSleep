using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CleanFade : MonoBehaviour
{
    public Image FadeImage;
    // Start is called before the first frame update
    void Start()
    {
        FadeImage = gameObject.transform.GetChild(0).GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

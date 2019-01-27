using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int stage1, stage1MAX = 5;
    public int stage1Interacts;
    public bool Puppy1, Tv1, Toybox1, Toilet1, Drawings1, Sink1;

    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {

    }



public void CheckPuppy1()
    {
        Puppy1 = true;
        stage1++;
    }
    public void CheckTv1()
    {
        Tv1 = true;
        stage1++;
    }
    public void CheckToybox1()
    {
        Toybox1 = true;
        stage1++;
    }
    public void CheckToilet1()
    {
        Toilet1 = true;
        stage1++;
    }
    public void CheckDrawings1()
    {
        Drawings1 = true;
        stage1++;
    }
    public void CheckSink1()
    {
        Sink1 = true;
        stage1++;
    }



// Update is called once per frame
void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int stage1, stage2, stage3, stage4;
    public int stage1Interacts;
    public bool Puppy1, Tv1, Toybox1, Toilet1, Drawings1, Sink1, DogBed, GameWon;
    public string SavedDogName;
    public bool Skate2, Tv2, Guitar2, Tissues2, Puppy2;
    public bool Tv3, Chair3, Mirror3, Puppy3, Window3;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        if (GameWon == true)
        {
            if(GameObject.Find("LockedButton") != null)
            {
                GameObject.Find("LockedButton").SetActive(false);
            }
        }
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




    public void CheckSkate2()
    {
        Skate2 = true;
        stage2++;
    }
    public void CheckTv2()
    {
        Tv2 = true;
        stage2++;
    }
    public void CheckTissue2()
    {
        Tissues2 = true;
        stage2++;
    }
    public void CheckDog2()
    {
        Puppy2 = true;
        stage2++;
    }
    public void CheckGuitar2()
    {
        Guitar2 = true;
        stage2++;
    }




    public void CheckMirror3()
    {
        Mirror3 = true;
        stage3++;
    }
    public void CheckTv3()
    {
        Tv3 = true;
        stage3++;
    }
    public void CheckWindow3()
    {
        Window3 = true;
        stage3++;
    }
    public void CheckDog3()
    {
        Puppy3 = true;
        stage3++;
    }
    public void CheckChair3()
    {
        Chair3 = true;
        stage3++;
    }



    public void CheckDogBed4()
    {
        DogBed = true;
        stage4++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

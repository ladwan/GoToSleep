using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;
   // private CharacterMotor motor;
    private Vector3 targetPosition;
    private Vector3 directionVector;
    private Camera mainCamera;

    public float walkMultiplier = 1f;
    public bool defaultIsWalk = false;
    public float smooth = 0.0005F, SmoothMove;

    bool doOnce;
    void Start()
    {

    }

    void Update()
    {
    
        if (Input.GetMouseButtonDown(0))
        {
            mainCamera = FindCamera();

        
            RaycastHit hit;
            if (!Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hit, 100))
                return;
   
            if (!hit.transform)
                return;

            targetPosition = hit.point;
            directionVector = hit.point - transform.position;
            directionVector.y = 0;
            if (directionVector.magnitude > 1)
                directionVector = directionVector.normalized;

            if(doOnce == false)
            {
                doOnce = true;
                StartCoroutine(Lerp());
            }

           
            
        }
        Player.transform.position = Vector3.Lerp(Player.transform.position, targetPosition, SmoothMove);
    }

    IEnumerator Lerp()
    {
        if(SmoothMove < 1)
        {
            yield return new WaitForSeconds(0.1f);
            SmoothMove += 0.1f;
            StartCoroutine(Lerp());
        }
        else
        {
            doOnce = false;
            SmoothMove = 0;
            StopCoroutine(Lerp());
        }
   
    }

    Camera FindCamera()
    {
            return Camera.main;
    }

}

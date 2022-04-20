using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    public PlayerControls player;
    private Vector2 startPos;
    public int pixelDistToDetect = 20;
    private bool fingerDown;

    private void Update()
    {
        
        if(fingerDown == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            startPos = Input.touches[0].position;
            fingerDown = true;
        }
        if(fingerDown)
        {
            if (Input.touches[0].position.y >= startPos.y + pixelDistToDetect)
            {
                fingerDown = false;
                Debug.Log("Swipe up");
                player.PlayerAttack(0);
            }
            else if (Input.touches[0].position.x >= startPos.x + pixelDistToDetect)
            {
                fingerDown = false;
                Debug.Log("Swipe right");
                player.PlayerAttack(1);
            }
            else if (Input.touches[0].position.y <= startPos.y - pixelDistToDetect)
            {
                fingerDown = false;
                Debug.Log("Swipe down");
                player.PlayerAttack(2);
            }
            
            else if (Input.touches[0].position.x <= startPos.x - pixelDistToDetect)
            {
                fingerDown = false;
                Debug.Log("Swipe left");
                player.PlayerAttack(3);
            }
            
        }
        if(fingerDown&&Input.touchCount>0&&Input.touches[0].phase == TouchPhase.Ended)
        {
            fingerDown = false;
        }
        //Testing for PC

        //if (fingerDown == false && Input.GetMouseButton(0))
        //{
        //    startPos = Input.mousePosition;
        //    fingerDown = true;
        //}
        //if (fingerDown == false && Input.GetMouseButton(0))
        //{
        //    startPos = Input.mousePosition;
        //    fingerDown = true;
        //}
        //if (fingerDown)
        //{
        //    if (Input.mousePosition.y >= startPos.y + pixelDistToDetect)
        //    {
        //        fingerDown = false;
        //        Debug.Log("Swipe up");
        //        player.PlayerAttack(0);
        //    }
        //    else if (Input.mousePosition.x >= startPos.x + pixelDistToDetect)
        //    {
        //        fingerDown = false;
        //        Debug.Log("Swipe right");
        //        player.PlayerAttack(1);
        //    }
        //    else if (Input.mousePosition.y <= startPos.y - pixelDistToDetect)
        //    {
        //        fingerDown = false;
        //        Debug.Log("Swipe down");
        //        player.PlayerAttack(2);
        //    }
        //    else if (Input.mousePosition.x <= startPos.x - pixelDistToDetect)
        //    {
        //        fingerDown = false;
        //        Debug.Log("Swipe left");
        //        player.PlayerAttack(3);
        //    }
            
            
        //}
        //if(fingerDown && Input.GetMouseButtonUp(0))
        //{
        //    fingerDown = false;
        //}
    }
}

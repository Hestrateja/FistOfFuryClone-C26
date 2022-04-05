using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    private byte direction;
    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        direction = CheckPosition(this.transform.parent);
        Move(direction);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(movement.x*speed*Time.deltaTime, movement.y * speed * Time.deltaTime);
    }

    private byte CheckPosition(Transform parentLocation)
    {
        if(parentLocation.position.y>0)
        {
            return 0;
        }
        if (parentLocation.position.x > 0)
        {
            return 1;
        }
        if (parentLocation.position.y < 0)
        {
            return 2;
        }
        if (parentLocation.position.x < 0)
        {
            return 3;
        }
        else
        {
            return 4;
        }
    }

    private void Move(byte direction)
    {
        switch (direction)
        {
            case 0:
                movement = new Vector2(0, -1);
                break;
            case 1:
                movement = new Vector2(-1, 0);
                break;
            case 2:
                movement = new Vector2(0, 1);
                break;
            case 3:
                movement = new Vector2(1, 0);
                break;
            default:
                print("Dirección incorrecta");
                break;
        }
    }
}

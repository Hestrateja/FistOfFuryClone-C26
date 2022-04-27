using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] Text ActionText;
    [SerializeField] Text ButtonText;
    [SerializeField] Text Score;
    [SerializeField] string scoreText;
    [SerializeField] InteractiveElement up, down, left, right;
    [SerializeField] Transform kill;
    Color color;
    private float scoreNumber;
    private void Start()
    {
        scoreNumber = 0;
        Score.text = scoreText +" "+scoreNumber.ToString();
    }
    void Update()
    {
        /*
        ButtonText.text = "IDLE";
        if (up.isPressed)
        {
            ButtonText.text = "UP";
            
        }
        if (down.isPressed)
        {
            ButtonText.text = "DOWN";
            
        }
        if (left.isPressed)
        {
            ButtonText.text = "LEFT";
            
        }
        if (right.isPressed)
        {
            ButtonText.text = "RIGHT";
            
        }
        */
        Collider2D collider = Physics2D.OverlapCircle(kill.position, 0.1f);
        if (collider.gameObject.tag == "enemy")
        {
            Destroy(collider.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            scoreNumber++;
            Score.text = scoreText + " " + scoreNumber.ToString();
        }
        */
    }
    public void PlayerAttack(byte direction)
    {
        switch (direction)
        {
            case 0:
                ActionText.text = "Arriba";
                transform.eulerAngles = new Vector3(0, 0, 90);
                break;
            case 1:
                ActionText.text = "Derecha";
                transform.eulerAngles = new Vector3(0, 0, 0);
                break;
            case 2:
                ActionText.text = "Abajo";
                transform.eulerAngles = new Vector3(0, 0, 270);
                break;
            case 3:
                ActionText.text = "Izquierda";
                transform.eulerAngles = new Vector3(0, 0, 180);
                break;
            default:
                print("Dirección incorrecta");
                break;
        }
    }
}

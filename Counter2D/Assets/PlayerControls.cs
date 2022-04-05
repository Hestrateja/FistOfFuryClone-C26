using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] Text ActionText;
    [SerializeField] Text Score;
    [SerializeField] string scoreText;
    private float scoreNumber;
    private void Start()
    {
        scoreNumber = 0;
        Score.text = scoreText +" "+scoreNumber.ToString();
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            scoreNumber++;
            Score.text = scoreText + " " + scoreNumber.ToString();
        }
    }
    public void PlayerAttack(byte direction)
    {
        switch (direction)
        {
            case 0:
                ActionText.text = "Arriba";
                break;
            case 1:
                ActionText.text = "Derecha";
                break;
            case 2:
                ActionText.text = "Abajo";
                break;
            case 3:
                ActionText.text = "Izquierda";
                break;
            default:
                print("Dirección incorrecta");
                break;
        }
    }
}

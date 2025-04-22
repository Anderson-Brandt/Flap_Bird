using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.controll.score++;
        GameController.controll.scoreText.text = GameController.controll.score.ToString();
    }
}

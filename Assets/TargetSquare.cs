using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSquare : MonoBehaviour
{
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            Debug.Log("Square touched by Player!");
            GameManager.instance.AddScore();
            GameManager.instance.SpawnNewSquare();
            Destroy(gameObject);
        }

    }
}
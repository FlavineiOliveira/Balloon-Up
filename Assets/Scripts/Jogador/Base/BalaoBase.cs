using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class BalaoBase : MonoBehaviour
{

    public Rigidbody2D BalaoRigidbody;

    protected float gravidade;

    public Text Texto;

    protected void MovimentarLateralmente()
    {
        BalaoRigidbody.AddForce(new Vector2(Input.acceleration.x, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
            Texto.text = "Game Over";
    }
}

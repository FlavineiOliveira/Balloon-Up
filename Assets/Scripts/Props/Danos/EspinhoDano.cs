using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspinhoDano : DanoBase
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            print("Perdeu");
    }
}

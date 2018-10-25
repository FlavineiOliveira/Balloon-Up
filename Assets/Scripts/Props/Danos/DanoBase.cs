using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class DanoBase : MonoBehaviour
{

    public BoxCollider2D ReceberPosicaoObjeto;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            print("O jogador Perdeu");
    }
}

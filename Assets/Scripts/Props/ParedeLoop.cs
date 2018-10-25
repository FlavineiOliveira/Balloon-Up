using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(Collider2D))]
public class ParedeLoop : MonoBehaviour
{
    public Transform AvancarBloco;
    public BoxCollider2D ReceberPosicao;

    public float valorYparaDistanciaCenario;

    private void Start()
    {
        valorYparaDistanciaCenario = ReceberPosicao.bounds.size.y * 5;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            AvancarBloco.transform.position += new Vector3(0, valorYparaDistanciaCenario, 0);
    }
}

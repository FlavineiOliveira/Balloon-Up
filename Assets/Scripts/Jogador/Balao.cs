using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balao : BalaoBase
{

    void Start()
    {
        gravidade = -0.01f;
        BalaoRigidbody.gravityScale = gravidade;
    }

    void FixedUpdate()
    {

        MovimentarLateralmente();
    }
}

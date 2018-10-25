using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorNiveis : MonoBehaviour
{

    public Transform EspinhoSimples1;
    public Transform EspinhoSimples2;

    protected float valorYparaDistancia;

    public static bool SetarGameObject;

    void Start()
    {
        valorYparaDistancia = 20;

        SetarGameObject = false;
    }

    private void FixedUpdate()
    {
        SetarPosicaoGameObject(Pontuacao.pontos);
    }

    private void SetarPosicaoGameObject(int pontos)
    {
        if (SetarGameObject)
        {
            if (pontos > 0 && pontos < 20)
                EspinhoSimples1.transform.position += new Vector3(0, valorYparaDistancia, 0);

            if (pontos > 20)
                EspinhoSimples2.transform.position += new Vector3(0, valorYparaDistancia, 0);

            SetarGameObject = false;
        }
    }
}

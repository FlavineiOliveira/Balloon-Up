using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject balaoJogador;
    private Vector2 distanciaEntreJogadorCamera;

    private void Start()
    {
        distanciaEntreJogadorCamera = transform.position - balaoJogador.transform.position;
    }

    // LateUpdate is called after Update each frame
    private void LateUpdate()
    {
        transform.position = new Vector3(0, balaoJogador.transform.position.y + distanciaEntreJogadorCamera.y, transform.position.z);
    }
}

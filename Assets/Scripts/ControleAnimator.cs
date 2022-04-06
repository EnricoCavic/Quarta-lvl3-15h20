// bibliotecas/libs
// códigos prontos para serem utilizados
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// aqui é iniciada a classe do script
public class ControleAnimator : MonoBehaviour
{

    float inputY;
    float inputX; 
    Animator meuAnimator;

    Rigidbody meuRb;
    public float velocidade;
    public float forcaGiro;


    // função que ocorre uma vez no inicio do jogo
    void Start()
    {
        meuAnimator = GetComponent<Animator>();
        meuRb = GetComponent<Rigidbody>();
    }

    // função que ocorre uma vez por frame (fps)
    // game loop
    void Update()
    {
        inputY = Input.GetAxis("Vertical");
        inputX = Input.GetAxis("Horizontal");

        meuAnimator.SetFloat("Y", inputY);
    }

    // função que ocorre SEMPRE 50 vezes por segundo
    void FixedUpdate()
    {
        Vector3 frente = transform.forward * velocidade * inputY;
        meuRb.AddForce(frente, ForceMode.Force);

        Vector3 dirGiro = transform.up * forcaGiro * inputX;
        meuRb.AddTorque(dirGiro, ForceMode.Force);

    }

}

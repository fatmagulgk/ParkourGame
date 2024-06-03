using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    PlayerMovement PlayerMovement;
    Rigidbody rb;
    private void Awake()
    {
        PlayerMovement = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody>();

    }
    
    private void FixedUpdate()
    {
        Vector3 movePos = transform.position;
        if (Input.GetKey(KeyCode.W))//GetKey basili tuttugun surece calisir.Ancak GetKeyDown bastigimiz anda calisir basili tutmaya devam edersek calismaz.Ve birakip tekrar basmamiz gerekir.
        {
           movePos+= Vector3.forward*(Time.deltaTime*PlayerMovement.Speed);//Rigidbody'e kendi pozisyonumuzun ileri(forward) yonunde hizimiza gore ve rotasyonumuza gore hareket etmesini saglar. 
        }
        if(Input.GetKey(KeyCode.S))
        {
            movePos +=  Vector3.back * (Time.deltaTime * PlayerMovement.Speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movePos += Vector3.left* (Time.deltaTime * PlayerMovement.Speed);      
        }
        if (Input.GetKey(KeyCode.D))
        {
            movePos += Vector3.right * (Time.deltaTime * PlayerMovement.Speed);
        }
        
        rb.MovePosition(movePos);
    }
}
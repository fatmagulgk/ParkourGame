using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]//Ben player movement olarak player motorsuz yasayamam demek.Eðer bir yere player movement eklendiyse player motorda eklenir.
public class PlayerMovement : MonoBehaviour
{
    public float Speed = 3;
    public float JumpPower = 2;


}

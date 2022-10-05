using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float Speed;
   private Rigidbody rig;
   void Start()
   {
      rig = GetComponent<Rigidbody>();
   }

   void FixedUpdate()
   {
        Vector3 Position =  new Vector3(Input.GetAxisRaw("Horizontal"),0f, Input.GetAxisRaw("Vertical")); 
        rig.velocity = Position * Speed;
   }
}

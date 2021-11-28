using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBigSpace : MonoBehaviour
{
   void OnTriggerEnter(Collider collision){
       if(collision.gameObject.tag=="Big"){
           Physics.IgnoreCollision(collision, GetComponent<Collider>());
       }
       if(collision.gameObject.tag=="BigPlus"){
           Physics.IgnoreCollision(collision, GetComponent<Collider>());
       }
   }

   void OnTriggerStay(Collider collision){
       if(collision.gameObject.tag=="Big"){
           Physics.IgnoreCollision(collision, GetComponent<Collider>());
       }
       if(collision.gameObject.tag=="BigPlus"){
           Physics.IgnoreCollision(collision, GetComponent<Collider>());
       }
   }

   void OnTriggerExit(Collider collision){
       if(collision.gameObject.tag=="Big"){
           Physics.IgnoreCollision(collision, GetComponent<Collider>());
       }
       if(collision.gameObject.tag=="BigPlus"){
           Physics.IgnoreCollision(collision, GetComponent<Collider>());
       }
   }
}



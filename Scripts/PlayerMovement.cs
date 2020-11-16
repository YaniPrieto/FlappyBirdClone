using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpValue;

    private Rigidbody2D Player_rb;

    private void Awake() {
        Player_rb = GetComponent<Rigidbody2D>();
    }
   private void Update() {
       if (Input.GetKeyDown(KeyCode.Space)) {
           Jump();
       }
   }

   private void Jump() {
       Player_rb.velocity = Vector2.up * jumpValue;
   }
}

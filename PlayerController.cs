using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

  private BoxCollider2D boxCollider;

  void Start() {
    boxCollider = GetComponent<BoxCollider2D>();
  }

  void FixedUpdate() {
    float x = Input.GetAxisRaw("Horizontal");
    float y = Input.GetAxisRaw("Vertical");

    // moveDelta is reset every frame
    moveDelta = new Vector3(x, y, 0);

    // Change player sprite facing direction, default if right, change x to -1 if left
    if(moveDelta.x > 0)
      transform.localScale = Vector3.one;
    else if(moveDelta.x < 0)
      transform.localScale = new Vector3(-1, 1, 1);

    hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y),
                            Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Blocking", "Characters"));
    if(hit.collider == null) {
      transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
    }

    hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0),
                            Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Blocking", "Characters"));
    if(hit.collider == null) {
      transform.Translate(0, moveDelta.x * Time.deltaTime, 0);
    }
  }
}

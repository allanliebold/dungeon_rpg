using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraController : MonoBehaviour {

  // Object the camera will focus on, e.g. the Player
  public Transform lookAt;

  public float boundX = 0.3f, boundY = 0.15f;

  private void LateUpdate() {
    Vector3 delta = Vector3.zero;

    // Check if within bounds of X axis
    float deltaX = lookAt.position.x - transform.position.x;
    if(deltaX > boundX || deltaX < -boundX) {
      if(transform.position.x < lookAt.position.x) {
        delta.x = deltaX - boundX;
      } else {
        delta.x = deltaX + boundX;
      }
    }

    // Check if within bounds of Y axis
    float deltaY = lookAt.position.y - transform.position.y;
    if(deltaY > boundY || deltaY < -boundY) {
      if(transform.position.y < lookAt.position.y) {
        delta.y = deltay - boundy;
      } else {
        delta.y = deltay + boundy;
      }
    }

    transform.position += new Vector3(delta.x, delta.y, 0);
  }
}

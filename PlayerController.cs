using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

  private BoxCollider2D boxCollider;

  void Start() {
    boxCollider = GetComponent<BoxCollider2D>();
  }
}

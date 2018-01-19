using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Chest : Collectable {
  protected override void OnCollect(Collider2D collider) {
    collected = true;
    Debug.Log("Collected treasure.");
  }
}

using.UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collectable : CollisionObject {
  protected bool collected;

  protected override void OnCollide(Collider2D collider) {
    if(collider.name == "Player") {
      OnCollect();
    }
  }

  protected virtual void OnCollect() {

  }
}

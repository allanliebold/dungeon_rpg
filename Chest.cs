using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Chest : Collectable {

  public Sprite emptyChest;
  public int goldAmount = 5;

  protected override void OnCollect(Collider2D collider) {
    if(!collected) {
      collected = true;
      Debug.Log("Player collected" + goldAmount + " gold");
    }
  }
}

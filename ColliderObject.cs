using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollisionObject : MonoBehaviour{

  public ContactFilter2D filter;
  private BoxCollider2D boxCollider;
  private Collider2D[] hits = new Collider2D[10];

}

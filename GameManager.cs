using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game Manager : MonoBehaviour
{
  public static GameManager instance;

  private void Awake()
  {
    instance = this;
  }

  public List<Sprite> playerSprites;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : ColliderObject
{
    public string[] sceneNames;

    protected override void OnCollide(Collider2D coll) {
      if (coll.name == "Player" )
      {
        //Teleport the Player
        string sceneName = sceneNames[Random.Range(0, sceneNames.Length)];
        SceneManager.LoadScene(sceneName);
      }
    }

}

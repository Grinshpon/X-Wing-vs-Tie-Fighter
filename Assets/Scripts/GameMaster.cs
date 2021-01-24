using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
  //Singleton because this is a singleplayer game that will only ever have one gamemaster
  public static GameMaster Instance;

  public LaserPool laserPool;

  void Awake()
  {
    Instance = this;
    laserPool = new LaserPool(2000);
  }
}

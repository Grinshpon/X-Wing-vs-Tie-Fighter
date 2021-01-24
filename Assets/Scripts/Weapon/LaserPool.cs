using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPool
{
  Laser laserPrefab;
  Queue<Laser> laserPool;

  public LaserPool(int startingSize)
  {
    laserPrefab = Resources.Load<GameObject>("Prefabs/Laser").GetComponent<Laser>();

    laserPool = new Queue<Laser>(startingSize);
    for(int i = 0; i < startingSize; i++)
    {
      laserPool.Enqueue(GameObject.Instantiate(laserPrefab));
    }
  }

  public Laser SpawnLaser(Vector3 position, Quaternion rotation, int colorIx)
  {
    Laser laser = laserPool.Dequeue();
    laser.ResetAndFire(position, rotation, colorIx);

    laserPool.Enqueue(laser);
    return laser;
  }
}

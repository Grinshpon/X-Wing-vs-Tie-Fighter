using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//probably don't use directly, but have subclasses for various ships
public class WeaponsControl : MonoBehaviour
{
  public Transform[] cannons; //laser cannons
  //public Transform[] hardpoints; //missiles, torpedos, bombs, etc.

  protected float primaryFireTimer = 0f;
  public float primaryFireRate = 4f; //shots per second

  public virtual Laser Fire() {return null;}

  public Laser ManualFire(int ix, int colorIx)
  {
    if (primaryFireTimer <= 0f)
    {
      primaryFireTimer = 1/primaryFireRate;
      return GameMaster.Instance.laserPool.SpawnLaser(cannons[ix].position,cannons[ix].rotation, colorIx);
    }
    else return null;
  }

  void Update()
  {
    if (primaryFireTimer > 0f) primaryFireTimer -= Time.deltaTime;
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XWingWeapons : WeaponsControl
{
  int shooting = 0;

  public override Laser Fire()
  {
    if (primaryFireTimer <= 0f)
    {
      primaryFireTimer = 1/primaryFireRate;
      shooting = (shooting+1) % 4;
      return GameMaster.Instance.laserPool.SpawnLaser(cannons[shooting].position,cannons[shooting].rotation, 0);
    }
    else return null;
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  Transform tf;
  Rigidbody rb;
  public Transform neck;
  public Transform head;

  public float freeLookSpeed = 20f;
  public float snapBackMod = 4f;
  Vector3 neckRotation;
  Vector3 headRotation;

  ShipInputHandler inputHandler;
  ShipController ship;

  void Start()
  {
    tf = GetComponent<Transform>();
    rb = GetComponent<Rigidbody>();
    
    inputHandler = GetComponent<ShipInputHandler>();
    ship = GetComponent<ShipController>();
  }

  void Update()
  {
    float dt = Time.deltaTime;

    if (inputHandler.freeLook)
    {
      neckRotation.y = Mathf.Clamp(neckRotation.y + inputHandler.mouseInput.x * freeLookSpeed * dt, -135f, 135f);
      headRotation.x = Mathf.Clamp(headRotation.x - inputHandler.mouseInput.y * freeLookSpeed * dt, -90f, 90f);
    }
    else
    {
      Quaternion rotation = neck.localRotation * head.localRotation;
      rotation = Quaternion.RotateTowards(rotation, Quaternion.identity, snapBackMod * freeLookSpeed * dt);
      Vector3 eulerRot = rotation.eulerAngles;
      neckRotation = new Vector3(0,eulerRot.y,0);
      headRotation = new Vector3(eulerRot.x,0,0);

      //for now stick with a simplified control scheme, can alter later
      ship.stick.x = -inputHandler.mouseInput.y;
      ship.stick.y = inputHandler.mouseInput.x;
      ship.stick.z = -inputHandler.rollInput;
    }
    neck.localRotation = Quaternion.Euler(neckRotation);
    head.localRotation = Quaternion.Euler(headRotation);

    ship.targetThrottle = Mathf.MoveTowards(ship.targetThrottle,inputHandler.throttle,ship.throttleSpeed*dt);

    if (inputHandler.firePrimary)
    {
      ship.Fire();
    }
  }
}

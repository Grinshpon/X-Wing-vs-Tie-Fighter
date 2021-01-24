using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
  public const float FORCE_MULT = 100f;
  Transform tf;
  Rigidbody rb;
  WeaponsControl weapons;

  [Header("Stats")]
  public float maxSpeed = 100f;
  public float accel = 1000f;
  [Tooltip("(Pitch, Yaw, Roll)")]
  public Vector3 torqueMods = new Vector3(100f, 100f, 100f);
  public AnimationCurve turnEffectiveness;
  public float throttleSpeed = 2.0f;

  [Header("Control")]
  [Tooltip("(Pitch, Yaw, Roll)")]
  public Vector3 stick; // pitch, yaw, roll
  [Range(0,1)]
  public float targetThrottle = 0f;
  public float speed;

  float sqrSpeed;
  float sqrMaxSpeed;
  float throttleTrue;

  void Start()
  {
    tf = GetComponent<Transform>();
    rb = GetComponent<Rigidbody>();
    weapons = GetComponent<WeaponsControl>();
  }

  void Update()
  {
    float dt = Time.deltaTime;
    throttleTrue = Mathf.MoveTowards(throttleTrue, targetThrottle, throttleSpeed * dt);
  }

  void FixedUpdate()
  {
    HandleMovement();
    HandleTorque();
  }

  void HandleMovement()
  {
    sqrSpeed = rb.velocity.sqrMagnitude;
    speed = rb.velocity.magnitude;
    sqrMaxSpeed = Mathf.Pow(maxSpeed * throttleTrue,2);
    if (sqrSpeed < sqrMaxSpeed)
    {
      Vector3 forward = Vector3.forward * accel * throttleTrue * FORCE_MULT;
      rb.AddRelativeForce(forward);
    }
  }

  void HandleTorque()
  {
    Vector3 torque = MulComponents(stick,torqueMods) * turnEffectiveness.Evaluate(speed/maxSpeed) * FORCE_MULT;
    //Debug.Log(torque);
    rb.AddRelativeTorque(torque);
    //Debug.Log(speed/maxSpeed + ", " + turnEffectiveness.Evaluate(speed/maxSpeed));
  }

  Vector3 MulComponents(Vector3 u, Vector3 v)
  {
    return new Vector3(u.x*v.x, u.y*v.y, u.z*v.z);
  }

  public void Fire()
  {
    weapons.Fire();
  }
}

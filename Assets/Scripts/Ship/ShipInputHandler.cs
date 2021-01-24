using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInputHandler : MonoBehaviour
{
  ShipInput shipInput;
  public Vector2 mouseInput;
  public float rawThrottleInput;
  public float targetThrottle;
  public float throttle;
  public float rollInput;
  public bool freeLook;
  public bool firePrimary;

  void Start()
  {
    freeLook = false;
    throttle = 0f;
    Enable();
  }

  public void Enable()
  {
    if (shipInput == null)
    {
      shipInput = new ShipInput();
      shipInput.ShipControls.Mouse.performed += (ctx) => mouseInput = ctx.ReadValue<Vector2>();
      shipInput.ShipControls.Throttle.performed += (ctx) => UpdateThrottle(ctx.ReadValue<float>());
      shipInput.ShipControls.AD.performed += (ctx) => rollInput = ctx.ReadValue<float>();
      shipInput.ShipControls.FreeLook.performed += (ctx) => freeLook = !freeLook;
      shipInput.ShipControls.FirePrimary.performed += (ctx) => firePrimary = !firePrimary;
    }

    shipInput.Enable();
  }

  public void Disable()
  {
    if (shipInput != null) shipInput.Disable();
  }

  void UpdateThrottle(float rawThrottle)
  {
    rawThrottleInput = rawThrottle;
    if (rawThrottleInput > 0f) targetThrottle = 1f;
    else if (rawThrottleInput < 0f) targetThrottle = 0f;
    else targetThrottle = throttle;
  }

  void Update()
  {
    throttle = Mathf.MoveTowards(throttle,targetThrottle,Time.deltaTime);
  }
}

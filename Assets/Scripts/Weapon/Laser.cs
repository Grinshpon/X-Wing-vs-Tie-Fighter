using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Laser : MonoBehaviour
{
  //fly forward, report collisions to shooter, destroy self after a while
  Transform tf;
  Rigidbody rb;
  Material[] mats;

  int _emission;

  float timeActive;
  bool firing;

  public static Color[] colors = {
    new Color(1f,0f,0f),
    new Color(0.1f,0.8f,0.1f),
  };
  public float speed = 100f;
  public float timeTillDestroy = 10f; //in seconds

  void Awake()
  {
    _emission = Shader.PropertyToID("_EmissionColor");
    tf = GetComponent<Transform>();
    rb = GetComponent<Rigidbody>();
    mats = GetComponentsInChildren<Renderer>().Select(r => r.material).ToArray();
    gameObject.SetActive(false);
    //ResetAndFire(tf.position, Quaternion.identity, 0); //placeholder
  }

  public bool IsFiring()
  {
    return firing;
  }

  public void ResetAndFire(Vector3 origin, Quaternion rotation, int colorIx)
  {
    foreach (Material mat in mats)
    {
      mat.color = colors[colorIx];
      mat.SetColor(_emission, colors[colorIx]);
    }
    gameObject.SetActive(true);
    tf.position = origin;
    tf.rotation = rotation;
    timeActive = 0f;
    firing = true;
    rb.velocity = tf.forward * speed;
  }

  void Update()
  {
    if (firing)
    {
      timeActive += Time.deltaTime;
      if (timeActive >= timeTillDestroy)
      {
        Destroy();
      }
    }
  }

  public void Destroy()
  {
    firing = false;
    gameObject.SetActive(false);
  }

}

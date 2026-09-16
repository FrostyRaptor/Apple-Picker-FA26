using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Apple : MonoBehaviour
{
  public static float bottomY = -20f;

  // Start is called before the first frame update
  void Update()
  {
    if (transform.position.y < bottomY)
    {
      Destroy(this.gameObject);

      ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
      apScript.AppleMissed();
    }
  }
}

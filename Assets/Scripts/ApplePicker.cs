using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
  [Header("Inscribed")]
  public GameObject basketPrefab;
  public int numBaskets = 3;
  public float basketBottomY = -14f;
  public float basketSpacingY = 2f;
  public List<GameObject> basketList;

  // Start is called before the first frame update
  void Start()
  {
    basketList = new List<GameObject>();
    for (int i = 0; i < numBaskets; i++)
    {
      GameObject tBasketG0 = Instantiate<GameObject>(basketPrefab);
      Vector3 pos = Vector3.zero;
      pos.y = basketBottomY + (basketSpacingY * i);
      tBasketG0.transform.position = pos;
      basketList.Add(tBasketG0);
    }
  }

  public void AppleMissed()
  {
    GameObject[] appleArr = GameObject.FindGameObjectsWithTag("Apple");
    foreach (GameObject tempG0 in appleArr)
    {
      Destroy(tempG0);
    }

    int basketIndex = basketList.Count - 1;
    GameObject basketG0 = basketList[basketIndex];
    basketList.RemoveAt(basketIndex);
    Destroy(basketG0);

    if (basketList.Count == 0)
    {
      SceneManager.LoadScene("_Scene_0");
    }
  }
}

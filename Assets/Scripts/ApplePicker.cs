using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
  [Header("Inscribed")]
  public GameObject basketPrefab;
  public int numBaskets = 4;
  public float basketBottomY = -14f;
  public float basketSpacingY = 1.2f;
  public List<GameObject> basketList;

  // Start is called before the first frame update
  void Start()
  {
    basketList = new List<GameObject>();
    for (int i = 0; i < numBaskets; i++)
    {
      GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
      Vector3 pos = Vector3.zero;
      pos.y = basketBottomY + (basketSpacingY * i);
      tBasketGO.transform.position = pos;
      basketList.Add(tBasketGO);
    }
  }

  public void AppleMissed()
  {
    GameObject[] appleArr = GameObject.FindGameObjectsWithTag("Apple");
    foreach (GameObject tempGO in appleArr)
    {
      Destroy(tempGO);
    }

    GameObject[] branchArr = GameObject.FindGameObjectsWithTag("Branch");
    foreach (GameObject tempGO in branchArr)
    {
      Destroy(tempGO);
    }

    int basketIndex = basketList.Count - 1;
    GameObject basketGO = basketList[basketIndex];
    basketList.RemoveAt(basketIndex);
    Destroy(basketGO);

    if (basketList.Count == 0)
    {
      if (RoundCounter.ROUND < 4)
      {
        RoundCounter.IncreaseRoundCount();
        SceneManager.LoadScene("_Scene_0");
      }
      else
      {
        SceneManager.LoadScene("_Game_Over");
      }
    }
  }
}

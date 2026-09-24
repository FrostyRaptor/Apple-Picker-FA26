using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class RoundCounter : MonoBehaviour
{
  static private int _ROUND = 1;

  static private Text uiText;

  void Start()
  {
    uiText = GetComponent<Text>();
    UpdateRoundText();
  }

  static public int ROUND
  {
    get { return _ROUND; }
    private set
    {
      _ROUND = value;
      UpdateRoundText();
    }
  }

  static public void IncreaseRoundCount()
  {
    ROUND += 1;
  }

  static public void ResetRoundCount()
  {
    ROUND = 1;
  }

  static private void UpdateRoundText()
  {
    if (uiText != null)
    {
      uiText.text = "Round " + _ROUND.ToString("#,0");
    }
  }
}

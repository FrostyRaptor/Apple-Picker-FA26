using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
  public void RestartGame()
  {
    RoundCounter.ResetRoundCount();
    SceneManager.LoadScene("_Scene_0");
  }
}

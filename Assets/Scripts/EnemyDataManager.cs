using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDataManager : MonoBehaviour {

  [SerializeField]
  private int health;
  [SerializeField]
  private int attackStrength;

  private void UpdateHealth(int h) {
    health += h;
    if (health <= 0) {
      gameObject.SetActive(false);
    }
  }
}

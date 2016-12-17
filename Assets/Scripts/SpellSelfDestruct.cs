using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellSelfDestruct : MonoBehaviour {

	private void OnEnable () {
    StartCoroutine("SelfDestroy");
	}

  private void OnCollisionEnter2D(Collision2D other) {
    if (other.gameObject.tag == "enemy") {
      other.gameObject.SendMessage("UpdateHealth", -1);
    }
    gameObject.SetActive(false);
  }

  private IEnumerator SelfDestroy() {
    yield return new WaitForSeconds(2f);
    gameObject.SetActive(false);
  }
}

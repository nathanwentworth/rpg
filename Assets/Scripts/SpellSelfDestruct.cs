using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellSelfDestruct : MonoBehaviour {

	private void OnEnable () {
    StartCoroutine("SelfDestroy");
	}

  private IEnumerator SelfDestroy() {
    yield return new WaitForSeconds(2f);
    gameObject.SetActive(false);
  }
}

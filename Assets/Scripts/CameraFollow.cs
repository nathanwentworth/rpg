using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

  private Transform cam;
  [SerializeField]
  private Transform target;
  [SerializeField]
  private float xOffset;
  [SerializeField]
  private float yOffset;
  [SerializeField]
  private float bounds;
  [SerializeField]
  private float speed;

  private void Awake() {
    cam = GetComponent<Transform>();
  }

  private void FixedUpdate() {
    if (target == null) { return; }

    if (Vector2.Distance(cam.position, target.position) > bounds) {
      cam.position = new Vector3(
        Mathf.Lerp(cam.position.x, target.position.x + xOffset, Time.deltaTime * speed),
        Mathf.Lerp(cam.position.y, target.position.y + yOffset, Time.deltaTime * speed),
        -10);
    }
  }

}
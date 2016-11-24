using UnityEngine;
using System.Collections;

public class Shooting : PlayerMovement {

  public enum Spells {
    None,
    Fireball,
    Ice
  }
  public int ActiveSpell { get; set; }

}
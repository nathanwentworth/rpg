using UnityEngine;
using System.Collections;

public class DataManager {

  public enum Spells {
    None,
    Fireball,
    Ice
  }

  public static int ActiveSpell { get; set; }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnEx : MonoBehaviour
{
   public AudioSource myEx;
  public AudioClip hoverEx;
  public AudioClip clickEx;


  public void HoverSound()
  {
		myEx.PlayOneShot (hoverEx);
  }
  public void ClickSound()
  {
		myEx.PlayOneShot (clickEx);
  }
}

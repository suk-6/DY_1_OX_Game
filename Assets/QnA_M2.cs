using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QnA_M2 : MonoBehaviour
{
   private string data = "병준아 금연하자!";
   public Text q;

   private void Update() {
       q.text = data;
   }
}

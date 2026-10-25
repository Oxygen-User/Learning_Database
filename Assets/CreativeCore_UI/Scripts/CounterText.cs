using TMPro;
using UnityEngine;
using UnityEngine.UI; // Don't forget this line
public class CounterText : MonoBehaviour
{
   public TextMeshProUGUI countText;
      public int CorrectAnswer;
   public void CorrectAnswerGiven()
    {
        CorrectAnswer++ ;
    }

   public void Update()
   {
      countText.SetText("Correct Answers: " + CorrectAnswer.ToString());
   }
}
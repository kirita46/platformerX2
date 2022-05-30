using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class morabar : MonoBehaviour
{
    [SerializeField] 
  private Image HealthBarImage;
   
      public void SetHealthBarValue(int value)
      {
          HealthBarImage.fillAmount = 1 - 1 / value;
          if(HealthBarImage.fillAmount < 0.34f)
          {
              SetHealthBarColor(Color.red);
          }
          else if(HealthBarImage.fillAmount < 0.67f)
          {
              SetHealthBarColor(Color.yellow);
          }
          else
          {
              SetHealthBarColor(Color.green);
          }
      }
   
      private float GetHealthBarValue()
      {
          return HealthBarImage.fillAmount;
      }
   

      private void SetHealthBarColor(Color healthColor)
      {
          HealthBarImage.color = healthColor;
      }
      
  }
